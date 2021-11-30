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
            else if (song.GetThumbImg() is string)
            {
                pbImg.BackgroundImage = null;
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImg.LoadAsync(song.GetThumbImg().ToString());
            }
            ChangeColorLove(song.isLiked);
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            if (parent != null)
            {
                DataRepo.NormalPlaying();
                MainForm.Instance.LoadViewPlaying();
            }
            DataRepo.idxPlaying = idx;
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

        private void ChangeColorLove(bool isLiked)
        {
            if (isLiked)
                pbTim.BackgroundImage = Properties.Resources.icons8_heart_24px;
            else
                pbTim.BackgroundImage = Properties.Resources.icons8_love_24px;
        }

        private void pbTim_Click(object sender, EventArgs e)
        {
            song.isLiked = !song.isLiked;
            ChangeColorLove(song.isLiked);
            if (song.isLiked)
                DataRepo.AddToFavorite(song);
            else
                DataRepo.DelFromFavorite(song);
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            menu.Show(btnMore, 0, btnMore.Height);
        }
    }
}
