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
    public partial class MediaList2 : UserControl
    {
        Song song;
        int idx;
        public MediaList2()
        {
            InitializeComponent();
        }

        public MediaList2(Song song, int idx)
        {
            InitializeComponent();
            this.song = song;
            this.idx = idx;

        }
        private async void MediaList2_Load(object sender, EventArgs e)
        {
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            lbAlbum.Text = song.GetAlbumName();
            lbDuration.Text = song.GetFormatedDuration();
            if (song.GetThumbImg() is Image)
            {
                pbImg.BackgroundImage = song.GetThumbImg() as Image;
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (song.GetThumbImg() is string)
            {
                pbImg.BackgroundImage = await Helper.LoadImagefromURL(song.GetThumbImg().ToString());
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            MainForm.Instance.counter = idx;
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
