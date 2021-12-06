using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.View
{
    public partial class karaoke : Form
    {
        string outpath = "C:\\Users\\DAT\\Desktop\\music";
        string mediaName = "";
        private WaveIn recorder;
        // Redefine the capturer instance with a new instance of the LoopbackCapture class
        WasapiLoopbackCapture CaptureInstance;


        private BufferedWaveProvider bufferedWaveProvider;
        private SavingWaveProvider savingWaveProvider;
        private WaveOut player;
        private VolumeSampleProvider volumeSampleProvider;
        public karaoke()
        {
            InitializeComponent();
        }
        public karaoke(string url, string mediaName)
        {
            InitializeComponent();
            CenterToParent();
            kPlayer.settings.autoStart = false;
            kPlayer.URL = url;
            this.mediaName = mediaName;
            outpath = Data.karaokePath;
            for (int idx = 0; idx < WaveOut.DeviceCount; ++idx)
            {
                string devName = WaveOut.GetCapabilities(idx).ProductName;
                cbLoa.Items.Add(devName);
                cbLoa.SelectedIndex = 0;
            }
            for (int idx = 0; idx < WaveIn.DeviceCount; ++idx)
            {
                string devName = WaveIn.GetCapabilities(idx).ProductName;
                cbMic.Items.Add(devName);
                cbMic.SelectedIndex = 0;
            }
        }

        private bool start = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            start = !start;
            if (start)
            {
                kPlayer.Ctlcontrols.stop();
                btnStart.Text = "Dừng hát";
                var reader1 = new AudioFileReader(kPlayer.URL);

                // set up the recorder
                recorder = new WaveIn();
                recorder.WaveFormat = reader1.WaveFormat;
                recorder.DeviceNumber = cbMic.SelectedIndex;
                recorder.DataAvailable += RecorderOnDataAvailable;


                string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                mediaName = r.Replace(mediaName, "");

                // set up our signal chain
                bufferedWaveProvider = new BufferedWaveProvider(recorder.WaveFormat);
                savingWaveProvider = new SavingWaveProvider(bufferedWaveProvider, Path.Combine(outpath, $"{mediaName}_goc.wav"));

                // set up playback
                player = new WaveOut();
                player.DeviceNumber = cbLoa.SelectedIndex;
                volumeSampleProvider = new VolumeSampleProvider(savingWaveProvider.ToSampleProvider());
                volumeSampleProvider.Volume = 1.0f;


                ISampleProvider t = volumeSampleProvider;


                MixingSampleProvider mixer = new MixingSampleProvider(new[] { t, reader1 });

                player.Init(mixer);

                // begin playback & record
                player.Play();
                RecordSystemSound();
                recorder.StartRecording();



            }
            else
            {

                btnStart.Text = "Bắt đầu hát";
                // stop recording
                recorder.StopRecording();
                // stop playback
                player.Stop();
                // finalise the WAV file
                savingWaveProvider.Dispose();
                CaptureInstance.StopRecording();
                kPlayer.Ctlcontrols.stop();
            }

        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
        {
            kPlayer.settings.volume = 0;
            kPlayer.Ctlcontrols.play();
            bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        private void RecordSystemSound()
        {
            // Define the output wav file of the recorded audio
            string outputFilePath = Path.Combine(outpath, $"{mediaName}_mixed.wav");

            // Redefine the capturer instance with a new instance of the LoopbackCapture class
            CaptureInstance = new WasapiLoopbackCapture();

            // Redefine the audio writer instance with the given configuration
            WaveFileWriter RecordedAudioWriter = new WaveFileWriter(outputFilePath, CaptureInstance.WaveFormat);

            // When the capturer receives audio, start writing the buffer into the mentioned file
            CaptureInstance.DataAvailable += (s, a) =>
            {
                // Write buffer into the file of the writer instance
                RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            // When the Capturer Stops, dispose instances of the capturer and writer
            CaptureInstance.RecordingStopped += (s, a) =>
            {
                RecordedAudioWriter.Dispose();
                RecordedAudioWriter = null;
                CaptureInstance.Dispose();
            };

            // Start audio recording !
            CaptureInstance.StartRecording();
        }
    }
}
