
using MusicPlayer.Model;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using TagLib.Id3v2;

namespace MusicPlayer.View
{
    public partial class LocalView : UserControl
    {
        Playlist playlist;
        public LocalView()
        {
            InitializeComponent();
            playlist = new Playlist("local");
        }
        private void LocalView_Load(object sender, EventArgs e)
        {
            LoadLocalSong("C:\\Users\\DAT\\Desktop\\music\\Top 100 VPop");
        }
        private void LoadLocalSong(string path)
        {
            var extensions = Helper.GetAllSupportFile();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()) && (TagLib.File.Create(f) is TagLib.Mpeg.AudioFile))
                                    .ToArray();

            List<Song> tmp = new List<Song>();
            for (int i = files.Length - 1; i > -1; i--)
            {
                var tfile = TagLib.File.Create(files[i]);
                SongLocal song = new SongLocal(tfile);
                var view = new MediaList1(song, i, playlist);
                view.parent = this;
                view.Dock = DockStyle.Top;
                panelSong.Controls.Add(view);
                tmp.Add(song);
            }
            for (int i = tmp.Count - 1; i > -1; i--)
                playlist.files.Add(tmp[i]);
        }

        public Panel GetPanelSong()
        {
            return panelSong;
        }

        private void btnShuffer_Click(object sender, EventArgs e)
        {
            MainForm.Instance.isPlaying = playlist;
            MainForm.Instance.ShufferPlaying();
            MainForm.Instance.counter = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }
    }
}
