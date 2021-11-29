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
        private Media media;
        public MediaListSmall()
        {
            InitializeComponent();
        }
        public MediaListSmall(Media media)
        {
            InitializeComponent();
            this.media = media;
            lbTitle.Text = media.title;
            lbArtist.Text = media.artistNames;
            lbDuration.Text = TimeSpan.FromSeconds(media.duration).ToString(@"mm\:ss");
            if (media.type == "song")
            {
                Song s = media as Song;
                if (s.thumbImg is string)
                    pbThumb.LoadAsync(s.thumbImg as string);
                else
                    pbThumb.BackgroundImage = s.thumbImg as Image;
            }

        }

    }
}
