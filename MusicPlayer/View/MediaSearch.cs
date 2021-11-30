using MusicPlayer.Data;
using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.View
{
    public partial class MediaSearch : UserControl
    {
        public Song song;
        Playlist parent;
        public MediaSearch()
        {
            InitializeComponent();
        }

        public MediaSearch(Song s, Playlist parent)
        {
            InitializeComponent();
            song = s;
            this.parent = parent;
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            if (song.GetThumbImg() is string)
            {
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImg.LoadAsync(song.GetThumbImg().ToString());
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var client = new WebClient())
                {
                    client.DownloadFileAsync(new Uri(song.GetSrc()), dialog.SelectedPath + "\\" + song.GetTitle() + "-" + song.GetArtistNameJoined() + ".mp3");
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainForm.Instance.LoadViewPlaying();
            DataRepo.isPlaying = parent;
            int idx = parent.files.IndexOf(song);
            DataRepo.idxPlaying = idx;
            DataRepo.NormalPlaying();
            MainForm.Instance.PlayMedia();
        }
    }
}
