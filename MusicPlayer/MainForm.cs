
using MusicPlayer.Model;
using MusicPlayer.Service;
using MusicPlayer.Utils;
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
        public Playlist isPlaying;
        public List<int> playingOrder;
        public int counter = 0;

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            btnLocal_Click(btnLocal, null);

        }
        #region Media player
        public void PlayMedia()
        {
            Song song = isPlaying.files[playingOrder[counter]];
            mPlayer.URL = song.GetSrc();
            if (song.GetThumbImg() is Image)
            {
                pbSong.BackgroundImage = song.GetThumbImg() as Image;
                pbSong.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (song.GetThumbImg() is string)
            {
                pbSong.BackgroundImage = null;
                pbSong.SizeMode = PictureBoxSizeMode.StretchImage;
                pbSong.LoadAsync(song.GetThumbImg().ToString());
            }
            else
            {
                pbSong.BackgroundImage = Properties.Resources.icons8_music_48px_1;
                pbSong.BackgroundImageLayout = ImageLayout.Center;
            }
            lbSongName.Text = song.GetTitle() + "\n" + song.GetArtistNameJoined();
        }
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

        private void trackbarVolume_MouseUp(object sender, MouseEventArgs e)
        {
            int newVol = 100 * e.X / (trackbarVolume.Width - 15);
            mPlayer.settings.volume = newVol;
            trackbarVolume.Value = newVol;
        }

        private void trackbarVolume_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mPlayer.settings.volume = trackbarVolume.Value;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPlaying != null && isPlaying.files.Count > 0)
            {
                if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    mPlayer.Ctlcontrols.pause();
                else if (mPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                    mPlayer.Ctlcontrols.play();

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (isPlaying != null && isPlaying.files.Count > 0)
            {
                counter++;
                if (counter > isPlaying.files.Count)
                    counter = 0;
                PlayMedia();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (isPlaying != null && isPlaying.files.Count > 0)
            {
                counter--;
                if (counter < 0)
                    counter = isPlaying.files.Count - 1;
                PlayMedia();
            }
        }
        private void btnShuffer_Click(object sender, EventArgs e)
        {
            if (isPlaying != null && isPlaying.files.Count > 0)
            {
                if (btnShuffer.Tag.ToString() == "f")
                {
                    ShufferPlaying();
                    LoadViewPlaying();
                    counter = 0;
                    PlayMedia();
                    btnShuffer.BackColor = Color.FromArgb(27, 28, 34);
                    btnShuffer.BorderSize = 1;
                    btnShuffer.Tag = "t";
                }
                else
                {
                    NormalPlaying();
                    LoadViewPlaying();
                    counter = 0;
                    PlayMedia();

                    btnShuffer.BackColor = Color.FromArgb(15, 15, 16);
                    btnShuffer.BorderSize = 0;
                    btnShuffer.Tag = "f";
                }



            }
        }


        #endregion

        #region Menu
        private void ClearMenu()
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                menuButton.BackColor = Color.FromArgb(25, 26, 31);
        }
        private void ActiveMenu(Button btn, Control view)
        {
            btn.BackColor = Color.FromArgb(255, 128, 0);
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            ClearMenu();
            LocalView view;
            if (!panelContainer.Controls.ContainsKey("LocalView"))
            {
                view = new LocalView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["LocalView"] as LocalView;
            ActiveMenu(sender as Button, view);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearMenu();

            HomeView view;
            if (!panelContainer.Controls.ContainsKey("HomeView"))
            {
                view = new HomeView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["HomeView"] as HomeView;
            ActiveMenu(sender as Button, view);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearMenu();
            SearchView view;
            if (!panelContainer.Controls.ContainsKey("SearchView"))
            {
                view = new SearchView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["SearchView"] as SearchView;
            ActiveMenu(sender as Button, view);
        }
        #endregion

        #region List playing
        private void panelSongInfo_Click(object sender, EventArgs e)
        {
            tabPageMedia.Visible = !tabPageMedia.Visible;
            if (tabPageMedia.Visible)
                tabPageMedia.BringToFront();
        }

        public void NormalPlaying()
        {
            playingOrder = Enumerable.Range(0, isPlaying.files.Count).ToList();
        }
        public void ShufferPlaying()
        {
            NormalPlaying();
            Helper.Shuffle(playingOrder);
        }


        public void LoadViewPlaying()
        {
            panelPlaying.Controls.Clear();
            for (int i = playingOrder.Count - 1; i > -1; i--)
            {
                Song song = isPlaying.files[playingOrder[i]];
                var view = new MediaList2(song, i);
                view.Dock = DockStyle.Top;
                panelPlaying.Controls.Add(view);
            }


        }
        #endregion

    }
}
