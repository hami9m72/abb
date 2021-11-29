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
        Playlist parent;
        TagLib.File song;
        int idx;
        public MediaList()
        {
            InitializeComponent();
        }
        public MediaList(TagLib.File song, int idx, Playlist parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.idx = idx;
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

        private void pbImg_Click(object sender, EventArgs e)
        {
            DataRepo.isPlaying = parent;
            DataRepo.idxPlaying = idx;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
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
