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
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class karaoke : Form
    {
        Lyric lyric;
        int t = 0;
        int idx1 = 0;
        int idx2 = 0;

        public karaoke()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{textBox1.Text}"); ;
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            lyric = JsonConvert.DeserializeObject<Lyric>(await response.Content.ReadAsStringAsync());
            label3.Text = "0";
            var words = lyric.sentences[lyric.sentences.Count - 1].words;
            label4.Text = words[words.Count - 1].endTime.ToString();
            hopeTrackBar1.MaxValue = words[words.Count - 1].endTime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt = lyric.sentences[idx1].fullSentence() + "\n" + lyric.sentences[idx1 + 1].fullSentence();
            Draw(panel1, panel1.CreateGraphics(), txt, -1, Color.Blue, Color.Black);
            axWindowsMediaPlayer1.URL = "C:\\Users\\DAT\\Desktop\\music\\thaylong.mp3";
            timer1.Start();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            t += timer1.Interval;
            hopeTrackBar1.Value = t;
            label3.Text = t.ToString();
            if (t >= int.Parse(label4.Text) || idx1 >= lyric.sentences.Count)
            {
                timer1.Stop();
                return;
            }

            if (t >= lyric.sentences[idx1].words[idx2].startTime && t < lyric.sentences[idx1].words[idx2].endTime)
            {
                panel1.Refresh();
                string txt = lyric.sentences[idx1].fullSentence() + "\n" + lyric.sentences[idx1 + 1].fullSentence();
                await Draw(panel1, panel1.CreateGraphics(), txt, idx2, Color.Blue, Color.Black);
            }
            else if (t >= lyric.sentences[idx1].words[idx2].endTime)
            {
                idx2++;
            }
            if (idx2 >= lyric.sentences[idx1].words.Count)
            {
                idx1++;
                idx2 = 0;
            }

        }

        private async Task<int> Draw(Control control, Graphics g, string text, int idx, Color color1, Color color2)
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
                        Color c = i == idx ? color1 : color2;
                        TextRenderer.DrawText(g, word, font, WordBounds, c, flags);

                    }
                }
            }
            return 1;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string txt = "Dat Dep trai bo doi\nCan ca the gioi";
            Draw(panel1, panel1.CreateGraphics(), txt, 2, Color.Blue, Color.Black);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string txt = "Dat Dep trai bo doi\nCan ca the gioi";
            Draw(panel1, panel1.CreateGraphics(), txt, Convert.ToInt32(numericUpDown1.Value), Color.Blue, Color.Black);
        }
    }
}
