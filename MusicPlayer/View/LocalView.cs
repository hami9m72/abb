using MusicPlayer.Data;
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
            DataRepo.isPlaying = playlist;
            DataRepo.idxPlaying = 0;
            DataRepo.NormalPlaying();
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
                var view = new MediaList(song, i, this);
                view.Dock = DockStyle.Top;
                panelSong.Controls.Add(view);
                tmp.Add(song);
            }
            for (int i = tmp.Count - 1; i > -1; i--)
                playlist.files.Add(tmp[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRepo.ShufferPlaying();
            DataRepo.idxPlaying = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }


    }
}
