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
        private Media media;
        public MediaList()
        {
            InitializeComponent();
        }

        public MediaList(Media media)
        {
            InitializeComponent();
            this.media = media;
            lbName.Text = media.title;
            lbArtist.Text = media.artistNames;
            lbDuraton.Text = TimeSpan.FromSeconds(media.duration).ToString(@"mm\:ss");

            if (media.type == "song")
            {
                Song s = media as Song;
                if (s.thumbImg is string)
                    pbImg.LoadAsync(s.thumbImg.ToString());
                else
                    pbImg.BackgroundImage = s.thumbImg as Image;
            }

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
            MainForm.Instance.AddMediaToCurrPlaylist(media);
            MainForm.Instance.PlayMedia();
        }
    }
}
