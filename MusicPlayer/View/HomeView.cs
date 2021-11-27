using MusicPlayer.Model;
using MusicPlayer.Service;
using Newtonsoft.Json.Linq;
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
    public partial class HomeView : UserControl
    {
        private JObject data;

        public HomeView()
        {
            InitializeComponent();
        }

        private async void HomeView_Load(object sender, EventArgs e)
        {

            data = await MediaService.GetDataFromURL("https://dat-zing-mp3-api.herokuapp.com/home/1");
            int i = 0;
            foreach (var item in data["items"][0]["items"])
            {
                if (item["type"].ToString() == "1")
                {
                    var pb = tlpBanner.Controls[i++] as PictureBox;
                    pb.LoadAsync(item["banner"].ToString());
                    pb.Tag = item["encodeId"];
                }
                if (i == 3) break;
            }
        }

        private async void pb1_Click(object sender, EventArgs e)
        {
            Song song = await MediaService.GetSongDetail((sender as PictureBox).Tag.ToString());
            MainForm.Instance.SetMedia(song);
        }
    }
}
