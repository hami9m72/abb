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
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();
            int idx = 0;
            for (int i = 0; i < files.Length; i++)
            {
                var tfile = TagLib.File.Create(files[i]);
                if (tfile is TagLib.Mpeg.AudioFile)
                {
                    SongLocal song = new SongLocal(tfile);
                    var view = new MediaList(song, idx++, this);
                    view.Width -= 20;
                    flpSong.Controls.Add(view);
                    playlist.files.Add(song);
                }
            }
            Helper.HideScrollBar(flpSong, true, false);
            Console.WriteLine(idx);
        }

        private void flpSong_Resize(object sender, EventArgs e)
        {

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
