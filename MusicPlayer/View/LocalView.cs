
using MusicPlayer.DataRepo;
using MusicPlayer.Model;
using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            comboBox1.SelectedIndex = 0;
        }
        public void LocalView_Load(object sender, EventArgs e)
        {
            panelSong.Controls.Clear();
            if (Data.localPath.Count > 0)
            {
                playlist.files.Clear();
                LoadLocalSong(Data.localPath);
            }
            else
            {
                playlist.files.Clear();
            }

        }
        private void LoadLocalSong(List<string> paths)
        {
            List<string> files = new List<string>();
            foreach (var path in paths)
            {
                var extensions = Helper.GetAllSupportFile();
                var temp = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                        .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()) && (TagLib.File.Create(f) is TagLib.Mpeg.AudioFile))
                                        .ToArray();
                if (temp.Length > 0)
                    files.AddRange(temp);
            }
            if (files.Count > 0)
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                files = files.OrderBy(f => Path.GetFileName(f), StringComparer.Create(culture, false)).ToList();
                List<Song> tmp = new List<Song>();
                for (int i = files.Count - 1; i > -1; i--)
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
