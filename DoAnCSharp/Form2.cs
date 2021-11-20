using DoAnCSharp.Model;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class Form2 : Form
    {
        string outpath = "C:\\Users\\DAT\\Desktop\\music";

        private WaveIn recorder;
        private BufferedWaveProvider bufferedWaveProvider;
        private SavingWaveProvider savingWaveProvider;
        private WaveOut player;
        private VolumeSampleProvider volumeSampleProvider;
        public Form2()
        {
            InitializeComponent();
            for (int idx = 0; idx < WaveOut.DeviceCount; ++idx)
            {
                string devName = WaveOut.GetCapabilities(idx).ProductName;
                //cbTayNghe.Items.Add(devName);
                cbLoa.Items.Add(devName);
            }
            for (int idx = 0; idx < WaveIn.DeviceCount; ++idx)
            {
                string devName = WaveIn.GetCapabilities(idx).ProductName;
                cbMic.Items.Add(devName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // set up the recorder
            recorder = new WaveIn();
            recorder.DeviceNumber = cbMic.SelectedIndex;
            recorder.DataAvailable += RecorderOnDataAvailable;

            // set up our signal chain
            bufferedWaveProvider = new BufferedWaveProvider(recorder.WaveFormat);
            savingWaveProvider = new SavingWaveProvider(bufferedWaveProvider, Path.Combine(outpath, "temp.wav"));

            // set up playback
            player = new WaveOut();
            player.DeviceNumber = cbLoa.SelectedIndex;
            volumeSampleProvider =new VolumeSampleProvider(savingWaveProvider.ToSampleProvider());
            volumeSampleProvider.Volume = 1.0f;
            player.Init(volumeSampleProvider);

            // begin playback & record
            player.Play();
            recorder.StartRecording();

            btnStart.Enabled = false;
            btnEnd.Enabled = true;
        }

        private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
        {
            bufferedWaveProvider.AddSamples(waveInEventArgs.Buffer, 0, waveInEventArgs.BytesRecorded);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            // stop recording
            recorder.StopRecording();
            // stop playback
            player.Stop();
            // finalise the WAV file
            savingWaveProvider.Dispose();

            btnStart.Enabled = true;
            btnEnd.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (volumeSampleProvider != null)
                volumeSampleProvider.Volume = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var reader1 = new AudioFileReader(Path.Combine(outpath, "karaoke.mp3")))
            //using (var reader2 = new AudioFileReader(Path.Combine(outpath, "temp.wav")))
            //{
            //    var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
            //    WaveFileWriter.CreateWaveFile16("mixed.wav", mixer);
            //}
        }
    }
}
