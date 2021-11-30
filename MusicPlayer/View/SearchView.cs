using MusicPlayer.Data;
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
    public partial class SearchView : UserControl
    {
        int page = 1;
        int total = 0;
        int counter = 0;

        Playlist search;

        public SearchView()
        {
            InitializeComponent();
            search = new Playlist("search");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            panelSearch.Controls.Clear();
            string keyword = txtSearch.Texts.Trim();
            if (keyword != "")
            {
                var data = await MediaService.GetDataFromURL($"http://localhost:3000/song/search2?q={keyword}&page={page}");
                if (data != null)
                {
                    for (int i = data["items"].Count() - 1; i > -1; i--)
                    {
                        Song song = new SongOnline(data["items"][i] as JObject);
                        var view = new MediaSearch(song, search);
                        view.Dock = DockStyle.Top;
                        panelSearch.Controls.Add(view);
                        search.files.Add(song);
                    }
                    search.files.Reverse();


                    //int total = Convert.ToInt32(data["total"].ToString());
                    //if (total > 100)
                    //    total = 100;


                    //int i = Convert.ToInt32(data["delItem"].ToString());
                    //while (i < total)
                    //{
                    //    var data2 = await MediaService.GetDataFromURL($"http://localhost:3000/song/search2?q={keyword}&page={++page}");

                    //}
                }

            }
        }
    }
}
