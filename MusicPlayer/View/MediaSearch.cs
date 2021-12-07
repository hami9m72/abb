
using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using MusicPlayer.Service;
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
using TagLib;
using TagLib.Id3v2;

namespace MusicPlayer.View
{
    public partial class MediaSearch : UserControl
    {
        public Song song;
        Playlist parent;
        int idx;
        string filepath = "";
        string downpath = "";
        public MediaSearch()
        {
            InitializeComponent();
        }

        public MediaSearch(Song s, int idx, Playlist parent)
        {
            InitializeComponent();
            song = s;
            this.parent = parent;
            this.idx = idx;
            downpath = Data.downloadPath;
            lbName.Text = song.GetTitle();
            lbArtist.Text = song.GetArtistNameJoined();
            if (song.GetThumbImg() is string)
            {
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImg.LoadAsync(song.GetThumbImg().ToString());
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (downpath == "")
            {
                var dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    downpath = dialog.SelectedPath;
                    Data.downloadPath = dialog.SelectedPath;
                    filepath = dialog.SelectedPath + "\\" + song.GetTitle() + "-" + song.GetArtistNameJoined() + ".mp3";
                }
            }
            else
                filepath = downpath + "\\" + song.GetTitle() + "-" + song.GetArtistNameJoined() + ".mp3";
            try
            {
                var data = await MediaService.GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/stream/{song.GetEncodedId()}");
                if (data != null)
                {
                    using (var client = new WebClient())
                    {
                        song.SetSrc(data["128"].ToString());
                        client.DownloadFileCompleted += Client_DownloadFileCompleted;
                        client.DownloadFileAsync(new Uri(song.GetSrc()), filepath);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra.\nVui lòng thử lại sau", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Download lỗi:\n{ex.Message}", "Thông báo");
            }


        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download thành công", "Thông báo");
            var tfile = File.Create(filepath);
            TagLib.Id3v2.Tag t = (TagLib.Id3v2.Tag)tfile.GetTag(TagTypes.Id3v2); // You can add a true parameter to the GetTag function if the file doesn't already have a tag.
            PrivateFrame p = PrivateFrame.Get(t, "EncodedId", true);
            p.PrivateData = Encoding.Unicode.GetBytes(song.GetEncodedId());
            tfile.Save(); // This is optional.
            var view = MainForm.Instance.GetContainerView("LocalView") as LocalView;
            view.LoadTabDownload();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MainForm.Instance.isPlaying = parent;
            MainForm.Instance.NormalPlaying();
            MainForm.Instance.counter = idx;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }

        private async void MediaSearch_Load(object sender, EventArgs e)
        {
            //string url = await MediaService.GetSongStream(song.GetEncodedId());
            //song.SetSrc(url);
        }
    }
}
