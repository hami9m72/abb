using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Search;
using YoutubeExplode.Videos.Streams;

namespace MusicPlayer.View
{
    public partial class KaraokeItem : UserControl
    {
        VideoSearchResult vidResult;
        YoutubeClient youtube;
        public KaraokeItem()
        {
            InitializeComponent();
        }

        public KaraokeItem(VideoSearchResult result)
        {
            InitializeComponent();
            vidResult = result;
            youtube = new YoutubeClient();
            pbImg.LoadAsync(vidResult.Thumbnails[0].Url);
            lbTitle.Text = vidResult.Title;
            lbArtist.Text = vidResult.Author.Title;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(vidResult.Id.Value);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            karaoke kara = new karaoke(streamInfo.Url);
            kara.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
