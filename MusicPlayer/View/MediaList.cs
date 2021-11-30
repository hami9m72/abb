using MusicPlayer.Data;
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
    public partial class MediaList : UserControl
    {
        public Song song;
        public int idx;
        Control parent;
        public MediaList()
        {
            InitializeComponent();
        }

        public MediaList(Song s, int idx, Control parent = null)
        {
            InitializeComponent();
            song = s;
            this.idx = idx;
            this.parent = parent;
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            lbAlbum.Text = song.GetAlbumName();
            lbDuration.Text = song.GetFormatedDuration();
            if (song.GetThumbImg() is Image)
            {
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
                pbImg.BackgroundImage = song.GetThumbImg() as Image;
            }
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                DataRepo.NormalPlaying();
                MainForm.Instance.LoadViewPlaying();
            }
            DataRepo.idxPlaying = DataRepo.playingOrder[idx];
            MainForm.Instance.PlayMedia();
        }

        private void pbImg_MouseEnter(object sender, EventArgs e)
        {
            pbImg.Image = Properties.Resources.icons8_play_32px;
        }

        private void pbImg_MouseLeave(object sender, EventArgs e)
        {
            pbImg.Image = null;
        }
    }
}
