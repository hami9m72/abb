using DoAnCSharp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class karaoke : Form
    {
        Lyric lyric;
        int t = 0;
        int idx1 = 0;
        int idx2 = 0;

        string link;

        Graphics g;

        public karaoke()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string songID = comboBox1.SelectedItem.ToString().Split('-')[1].Trim();
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{songID}");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            lyric = JsonConvert.DeserializeObject<Lyric>(await response.Content.ReadAsStringAsync());
            label3.Text = "0";
            var words = lyric.sentences[lyric.sentences.Count - 1].words;
            label4.Text = words[words.Count - 1].endTime.ToString();
            hopeTrackBar1.MaxValue = words[words.Count - 1].endTime;
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"https://dat-zing-mp3-api.herokuapp.com/song/stream/{songID}");
            response = await httpClient.SendAsync(req);
            link = JsonConvert.DeserializeObject<Streaming>(await response.Content.ReadAsStringAsync())._128;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string txt = lyric.sentences[idx1].fullSentence() + "\n" + lyric.sentences[idx1 + 1].fullSentence();
            //Draw(panel1, panel1.CreateGraphics(), txt, -1, Color.Blue, Color.Black);
            axWindowsMediaPlayer1.URL = link;
            startTime = lyric.sentences[0].words[0].startTime;
            endTime = lyric.sentences[1].words.Last().endTime;

        }

        private int startTime;
        private int endTime;


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (t >= startTime && t < endTime)
            {

                int temp = idx2;
                int temp2 = idx1;
                if (temp >= lyric.sentences[idx1].words.Count)
                {
                    temp = idx2 - lyric.sentences[idx1].words.Count;
                    temp2 += 1;
                }
                if (t >= lyric.sentences[temp2].words[temp].endTime)
                {
                    idx2++;
                    string text = lyric.sentences[idx1].fullSentence() + " \n" + lyric.sentences[idx1 + 1].fullSentence();
                    panel1.Refresh();
                    Draw(panel1, g, text, idx2, Color.Blue, Color.Black);
                }

            }
            if (t >= endTime - timer1.Interval)
            {
                idx1 += 2;
                idx2 = 0;
                if (idx1 >= lyric.sentences.Count)
                {
                    timer1.Stop();
                    return;
                }
                startTime = lyric.sentences[idx1].words[0].startTime;
                endTime = lyric.sentences[idx1 + 1].words.Last().endTime;
            }

            t += timer1.Interval + 15;
        }





        private void Draw(Control control, Graphics g, string text, int idx, Color color1, Color color2)
        {
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                MatchCollection mc = Regex.Matches(text, @"[^\s]+");
                CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                format.SetMeasurableCharacterRanges(ranges);

                using (Font font = new Font("Times New Roman", 40, FontStyle.Regular, GraphicsUnit.Point))
                {
                    Region[] regions = g.MeasureCharacterRanges(text, font, control.ClientRectangle, format);

                    for (int i = 0; i < ranges.Length; i++)
                    {
                        Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(g));
                        string word = text.Substring(ranges[i].First, ranges[i].Length);
                        Color c = i <= idx ? color1 : color2;
                        TextRenderer.DrawText(g, word, font, WordBounds, c, flags);
                    }
                }
            }

        }
        bool start = true;
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (start && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                t = 0;
                timer1.Start();
                start = false;
            }
        }
    }
}
