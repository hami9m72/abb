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
        TagLib.File song;
        public MediaList()
        {
            InitializeComponent();
        }
        public MediaList(TagLib.File song)
        {
            InitializeComponent();
            this.song = song;
            if (song.Tag.Pictures.Length > 0 && song.Tag.Pictures != null)
            {
                pbImg.BackgroundImage = Helper.LoadImageFromByteArray(song.Tag.Pictures[0].Data.Data);
                pbImg.BackgroundImageLayout = ImageLayout.Stretch;
            }
            lbYear.Text = song.Tag.Year == 0 ? "" : song.Tag.Year.ToString();
            lbGenre.Text = song.Tag.JoinedGenres;
            lbAlbum.Text = song.Tag.Album;
            lbName.Text = song.Tag.Title;
            lbArtist.Text = song.Tag.JoinedPerformers;
            lbDuration.Text = TimeSpan.FromSeconds(song.Properties.Duration.TotalSeconds).ToString(@"mm\:ss");
        }




    }
}
