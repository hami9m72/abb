using MusicPlayer.Model;
using MusicPlayer.Service;
using MusicPlayer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private static MainForm instance;
        public static MainForm Instance { get => instance; }

        public MainForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            btnHome_Click(btnHome, null);
            instance = this;

        }


        #region Borderless form
        //Fields
        private int borderSize = 2;
        private Size formSize; //Keep form size when it is minimized and restored.Since the form is resized because it takes into account the size of the title bar and borders.
                               //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        #endregion



        #region 3 nút thanh title

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            formSize = Size;
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion



        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
            panelContainer.Invalidate();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
            HomeView view;
            if (panelContainer.Controls["HomeView"] == null)
            {
                view = new HomeView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["HomeView"] as HomeView;
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        public void SetMedia(string url)
        {
            mPlayer.URL = url;
            mPlayer.Ctlcontrols.play();
        }

        public async void SetMedia(Song song)
        {
            tTrackBar.Stop();
            mPlayer.Ctlcontrols.stop();
            l1 = "";
            l2 = "";
            idx = 0;
            idx1 = -1;
            idx2 = -1;
            t = 0;
            rtbSong.Text = "";
            if (song.encodeId != "" && song.encodeId != null)
            {
                lyric = await MediaService.GetSongLyric(song.encodeId);
                startTime = lyric.sentences[idx].words[0].startTime;
                endTime = lyric.sentences[idx].words.Last().endTime;

                l1 = lyric.sentences[0].fullSentence();
                l2 = lyric.sentences[1].fullSentence();
                panelL1.Invalidate();
                panelL2.Invalidate();
                pbSong.LoadAsync(song.thumbnailM);

                foreach (var item in lyric.sentences)
                    rtbSong.AppendText(item.fullSentence() + "\n");
                rtbSong.SelectAll();
                rtbSong.SelectionAlignment = HorizontalAlignment.Center;
            }
            else
            {
                pbSong.Image = null;
                pbSong.BackgroundImage = song.thumbnailMImg;
            }


            mPlayer.URL = song.streaming._128;
            lbSongName.Text = song.title + "\n" + song.artistsNames;
            //lbSongArtist.Text = song.artistsNames;

            mPlayer.Ctlcontrols.play();


        }

        #region Load Lyric
        Lyric lyric;
        int t = 0;
        private int startTime;
        private int endTime;
        string l1 = "";
        string l2 = "";
        int idx = 0;
        int idx1 = -1;
        int idx2 = -1;

        private void panelL1_Paint(object sender, PaintEventArgs e)
        {
            if (l1 != "")
            {
                Graphics g = e.Graphics;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Far;

                    MatchCollection mc = Regex.Matches(l1, @"[^\s]+");
                    CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                    format.SetMeasurableCharacterRanges(ranges);

                    using (Font font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Region[] regions = g.MeasureCharacterRanges(l1, font, panelL1.ClientRectangle, format);

                        for (int i = 0; i < ranges.Length; i++)
                        {
                            Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(g));
                            string word = l1.Substring(ranges[i].First, ranges[i].Length);
                            Color c = i <= idx1 ? Color.FromArgb(255, 237, 0) : Color.White;
                            TextRenderer.DrawText(g, word, font, WordBounds, c, flags);
                        }
                    }
                }
            }
        }
        private void panelL2_Paint(object sender, PaintEventArgs e)
        {
            if (l2 != "")
            {
                Graphics g = e.Graphics;
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.Top |
                                    TextFormatFlags.NoPadding | TextFormatFlags.NoClipping;

                using (StringFormat format = new StringFormat())
                {
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Near;

                    MatchCollection mc = Regex.Matches(l2, @"[^\s]+");
                    CharacterRange[] ranges = mc.Cast<Match>().Select(m => new CharacterRange(m.Index, m.Length)).ToArray();
                    format.SetMeasurableCharacterRanges(ranges);

                    using (Font font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular, GraphicsUnit.Point))
                    {
                        Region[] regions = g.MeasureCharacterRanges(l2, font, panelL1.ClientRectangle, format);

                        for (int i = 0; i < ranges.Length; i++)
                        {
                            Rectangle WordBounds = Rectangle.Round(regions[i].GetBounds(g));
                            string word = l2.Substring(ranges[i].First, ranges[i].Length);
                            Color c = i <= idx2 ? Color.FromArgb(255, 237, 0) : Color.White;
                            TextRenderer.DrawText(g, word, font, WordBounds, c, flags);
                        }
                    }
                }
            }
        }

        private void HighlightLine()
        {
            if (idx > 0)
            {
                int f = rtbSong.GetFirstCharIndexFromLine(idx - 1);
                int c = rtbSong.GetLineFromCharIndex(f);
                string cur = rtbSong.Lines[c];
                rtbSong.Select(f, cur.Length);

                rtbSong.SelectionColor = Color.White;
            }
            int firstcharindex = rtbSong.GetFirstCharIndexFromLine(idx);
            int currentline = rtbSong.GetLineFromCharIndex(firstcharindex);
            string currentlinetext = rtbSong.Lines[currentline];
            rtbSong.Select(firstcharindex, currentlinetext.Length);

            rtbSong.SelectionColor = Color.FromArgb(255, 237, 0);

            rtbSong.ScrollToCaret();
        }
        #endregion

        private void mPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.BackgroundImage = Properties.Resources.icons8_pause_32px;
                trackBar.MaxValue = (int)mPlayer.Ctlcontrols.currentItem.duration;
                lbMaxTime.Text = mPlayer.Ctlcontrols.currentItem.durationString;

                tTrackBar.Start();

            }
            else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                btnPlay.BackgroundImage = Properties.Resources.icons8_play_32px;
                tTrackBar.Stop();
            }
            else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                tTrackBar.Stop();
                trackBar.Value = 0;
                lbMinTime.Text = "00:00";
            }
        }

        private void tTrackBar_Tick(object sender, EventArgs e)
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lbMinTime.Text = mPlayer.Ctlcontrols.currentPositionString;
                if (barChange)
                    trackBar.Value = (int)mPlayer.Ctlcontrols.currentPosition;
            }
            if (lyric != null)
            {
                if (idx >= lyric.sentences.Count)
                {
                    tTrackBar.Stop();
                    return;
                }
                if (t >= lyric.sentences[0].words[0].startTime &&
                    t < lyric.sentences[0].words[0].endTime)
                {
                    idx1 = 0;
                    idx2 = 0;
                    HighlightLine();
                }
                if (t >= startTime && t < endTime)
                {
                    if (idx % 2 == 0)
                    {
                        if (idx >= lyric.sentences.Count)
                        {
                            tTrackBar.Stop();
                            return;
                        }
                        l2 = lyric.sentences[idx + 1].fullSentence();
                        idx2 = -1;
                        panelL2.Invalidate();
                        if (t >= lyric.sentences[idx].words[idx1].endTime)
                            idx1++;
                        panelL1.Invalidate();
                    }
                    else
                    {
                        if (idx >= lyric.sentences.Count)
                        {
                            tTrackBar.Stop();
                            return;
                        }
                        l1 = lyric.sentences[idx + 1].fullSentence();
                        panelL1.Invalidate();
                        idx1 = -1;
                        if (t >= lyric.sentences[idx].words[idx2].endTime)
                            idx2++;
                        panelL2.Invalidate();

                    }
                }
                if (t >= endTime)
                {
                    idx++;
                    if (idx % 2 == 0) idx1 = 0;
                    else idx2 = 0;
                    startTime = lyric.sentences[idx].words[0].startTime;
                    endTime = lyric.sentences[idx].words.Last().endTime;
                    HighlightLine();
                }
                t += tTrackBar.Interval + 10;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mPlayer.Ctlcontrols.pause();
            }
            else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                mPlayer.Ctlcontrols.play();
            }
        }


        private void panelSongInfo_Click(object sender, EventArgs e)
        {
            panelMedia.Visible = !panelMedia.Visible;
            if (panelMedia.Visible)
                panelMedia.BringToFront();
        }
        private bool barChange = true;
        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (mPlayer.currentMedia != null)
            {
                double cur = mPlayer.Ctlcontrols.currentItem.duration * e.X / (trackBar.Width - 15);
                mPlayer.Ctlcontrols.currentPosition = cur;
                lbMinTime.Text = mPlayer.Ctlcontrols.currentPositionString;
                barChange = true;
            }
        }

        private void trackBar_MouseMove(object sender, MouseEventArgs e)
        {

            if (mPlayer.currentMedia != null && e.Button == MouseButtons.Left)
            {
                barChange = false;
            }
        }

        private void ClearAllMenuCheck()
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                menuButton.BackColor = Color.FromArgb(25, 26, 31);
        }

        private void ActiveMenu(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            ClearAllMenuCheck();
            ActiveMenu(sender as Button);
            LocalView view;
            if (panelContainer.Controls["LocalView"] == null)
            {
                view = new LocalView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["LocalView"] as LocalView;
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }
    }
}
