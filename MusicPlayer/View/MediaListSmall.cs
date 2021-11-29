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
    public partial class MediaListSmall : UserControl
    {
        private Song song;
        public MediaListSmall()
        {
            InitializeComponent();
        }
        public MediaListSmall(Song s)
        {
            InitializeComponent();
            song = s;
            label1.Text = song.title;
            label2.Text = song.artistsNames;
            label3.Text = TimeSpan.FromSeconds(song.duration).ToString(@"mm\:ss");
            if (s.thumbnailMImg != null)
                pictureBox1.BackgroundImage = s.thumbnailMImg;
            else
                pictureBox1.LoadAsync(s.thumbnailM);
        }

    }
}
