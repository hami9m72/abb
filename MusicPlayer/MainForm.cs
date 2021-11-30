using MusicPlayer.Data;
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

        public MainForm()
        {
            InitializeComponent();
            instance = this;
            btnLocal_Click(btnLocal, null);
        }
        #region Media player
        public void PlayMedia()
        {
            Song song = DataRepo.GetIsPlayingSong();
            mPlayer.URL = song.GetSrc();
            if (song.GetThumbImg() is Image)
            {
                pbSong.BackgroundImage = song.GetThumbImg() as Image;
                pbSong.BackgroundImageLayout = ImageLayout.Stretch;
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
                trackBar.Value = (int)mPlayer.Ctlcontrols.currentPosition;
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


        #endregion


        private void panelSongInfo_Click(object sender, EventArgs e)
        {
            tabPageMedia.Visible = !tabPageMedia.Visible;
            if (tabPageMedia.Visible)
                tabPageMedia.BringToFront();
        }

        public void LoadViewPlaying()
        {
            flpPlaying.Controls.Clear();
            if (DataRepo.isPlaying != null)
            {
                for (int i = 0; i < DataRepo.playingOrder.Count; i++)
                {
                    Song song = DataRepo.isPlaying.files[DataRepo.playingOrder[i]];
                    var view = new MediaList(song, i);
                    view.Width -= 20;
                    flpPlaying.Controls.Add(view);
                }
            }
            Helper.HideScrollBar(flpPlaying, true, false);
        }





        private void flpPlaying_Resize(object sender, EventArgs e)
        {
            //foreach (Control c in flpPlaying.Controls)
            //    c.Width = flpPlaying.Width - 20;
        }


    }
}
