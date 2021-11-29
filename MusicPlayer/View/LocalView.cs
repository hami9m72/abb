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
            DataRepo.isPlaying = playlist;
            LoadLocalSong("C:\\Users\\DAT\\Desktop\\music\\Top 100 VPop");
            MainForm.Instance.LoadViewPlaying();
        }

        private void LoadLocalSong(string path)
        {
            var extensions = Helper.GetAllSupportFile();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();
            int idx = 0;
            for (int i = 0; i < files.Length; i++)
            {
                var tfile = TagLib.File.Create(files[i]);
                if (tfile is TagLib.Mpeg.AudioFile)
                {
                    var view = new MediaList(tfile, idx++, playlist);
                    view.Width -= 20;
                    flpSong.Controls.Add(view);
                    playlist.files.Add(tfile);
                }
            }
            Helper.HideScrollBar(flpSong, true, false);

        }

        private void flpSong_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flpSong.Controls)
                c.Width = flpSong.Width - 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playlist temp = new Playlist("shuffer");
            foreach (var it in playlist.files)
                temp.files.Add(it);
            Helper.Shuffle(temp.files);
            DataRepo.isPlaying = temp;
            DataRepo.idxPlaying = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }
    }
}
