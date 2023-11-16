
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
        Playlist playlist1;
        Playlist playlist2;
        Playlist playlist3;

        public LocalView()
        {
            InitializeComponent();
            playlist1 = new Playlist("local");
            playlist2 = new Playlist("downloaded");
            playlist3 = new Playlist("karaoke");
            comboBox1.SelectedIndex = 0;
        }
        public void LocalView_Load(object sender, EventArgs e)
        {
            LoadTabLocal();
            LoadTabDownload();
            LoadTabKaraoke();
        }

        public void LoadTabLocal()
        {
            panelSong.Controls.Clear();
            if (Data.localPath.Count > 0)
            {
                playlist1.files.Clear();
                if (Data.localPath.Count > 0)
                    LoadLocalSong(Data.localPath, panelSong, playlist1);
            }
            else
            {
                playlist1.files.Clear();
            }
        }

        public void LoadTabDownload()
        {
            panelDownload.Controls.Clear();
            if (Data.downloadPath != "")
            {
                playlist2.files.Clear();
                if (Data.downloadPath != "")
                    LoadLocalSong(new List<string> { Data.downloadPath }, panelDownload, playlist2);
            }
            else
            {
                playlist2.files.Clear();
            }
        }

        public void LoadTabKaraoke()
        {
            panelKaraoke.Controls.Clear();
            if (Data.downloadPath != "")
            {
                playlist3.files.Clear();
                if (Data.karaokePath != "")
                    LoadLocalSong(new List<string> { Data.karaokePath }, panelKaraoke, playlist3);
            }
            else
            {
                playlist3.files.Clear();
            }
        }

        private void LoadLocalSong(List<string> paths, Panel panel, Playlist p)
        {
            List<string> files = new List<string>();
            foreach (var path in paths)
            {
                var extensions = Helper.GetAllSupportFile();
                var temp = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                        .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()))
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
                    var view = new MediaList1(song, i, p);
                    view.parent = this;
                    view.Dock = DockStyle.Top;
                    panel.Controls.Add(view);
                    tmp.Add(song);
                }
                for (int i = tmp.Count - 1; i > -1; i--)
                    p.files.Add(tmp[i]);
            }
        }

        public Panel GetPanelSong()
        {
            return panelSong;
        }

        private void btnShuffer_Click(object sender, EventArgs e)
        {
            MainForm.Instance.isPlaying = playlist1;
            MainForm.Instance.ShufferPlaying();
            MainForm.Instance.counter = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewPlaying();
        }

        private void panelSong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
