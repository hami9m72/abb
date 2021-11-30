
using MusicPlayer.Model;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.View
{
    public partial class MediaList1 : UserControl
    {
        public Song song;
        public Playlist local;
        public int idx;
        public LocalView parent;
        public MediaList1()
        {
            InitializeComponent();
        }

        public MediaList1(Song s, int idx, Playlist local)
        {
            InitializeComponent();
            this.song = s;
            this.local = local;
            this.idx = idx;
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            lbAlbum.Text = song.GetAlbumName();
            lbDuration.Text = song.GetFormatedDuration();
            if (song.GetThumbImg() is Image)
            {
                pbImg.BackgroundImage = song.GetThumbImg() as Image;
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
            }

        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            if (MainForm.Instance.isPlaying != null)
            {
                int old = MainForm.Instance.playingOrder[MainForm.Instance.counter];
                var ctls = parent.GetPanelSong().Controls;
                (ctls[ctls.Count - 1 - old] as MediaList1).DeActiveSongUI();
            }

            MainForm.Instance.isPlaying = local;
            MainForm.Instance.NormalPlaying();
            MainForm.Instance.counter = idx;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
            ActiveSongUI();
        }

        public void ActiveSongUI()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
                c.BackColor = Color.FromArgb(15, 15, 16);
            ChangeColorLabel(Color.FromArgb(1, 241, 250));
        }

        public void DeActiveSongUI()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
                c.BackColor = Color.FromArgb(37, 38, 44);
            ChangeColorLabel(Color.White);
        }

        private void ChangeColorLabel(Color color)
        {
            lbName.ForeColor = color;
            lbArtist.ForeColor = color;
            lbDuration.ForeColor = color;
            lbAlbum.ForeColor = color;
        }

        private void pbImg_MouseEnter(object sender, EventArgs e)
        {
            pbImg.Image = Properties.Resources.icons8_play_32px;
        }

        private void pbImg_MouseLeave(object sender, EventArgs e)
        {
            pbImg.Image = null;
        }

        private void ChangeColorLove(bool isLiked)
        {

        }

        private void pbTim_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            menu.Show(btnMore, 0, btnMore.Height);
        }
    }
}
