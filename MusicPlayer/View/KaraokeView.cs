using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Streams;

namespace MusicPlayer.View
{
    public partial class KaraokeView : UserControl
    {
        YoutubeClient youtube;
        public KaraokeView()
        {
            InitializeComponent();
            youtube = new YoutubeClient();
        }

        public async void Search(string keyword)
        {
            if (keyword != "")
            {
                panelResult.Controls.Clear();
                txtSearch.Focus();
                txtSearch.Texts = keyword;
                var t = await youtube.Search.GetVideosAsync(txtSearch.Texts).CollectAsync(20);
                for (int i = t.Count - 1; i > -1; i--)
                {
                    var view = new KaraokeItem(t[i]);
                    view.Dock = DockStyle.Top;
                    panelResult.Controls.Add(view);
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            panelResult.Controls.Clear();
            var t = await youtube.Search.GetVideosAsync(txtSearch.Texts).CollectAsync(20);
            for (int i = t.Count - 1; i > -1; i--)
            {
                var view = new KaraokeItem(t[i]);
                view.Dock = DockStyle.Top;
                panelResult.Controls.Add(view);
            }

        }
    }
}
