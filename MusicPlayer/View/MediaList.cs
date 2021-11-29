using MusicPlayer.Model;
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
        private Song song;
        public MediaList()
        {
            InitializeComponent();
        }

        public MediaList(Image img, Song s)
        {
            InitializeComponent();
            pbImg.BackgroundImage = img;
            song = s;
            lbName.Text = song.title;
            lbArtist.Text = song.artistsNames;
            label1.Text = TimeSpan.FromSeconds(song.duration).ToString(@"mm\:ss");
            //lbGen.Text = song.genres[0].name;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            pbImg.Image = Properties.Resources.icons8_play_32px;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            pbImg.Image = null;
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetMedia(song);
        }
    }
}
