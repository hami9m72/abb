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
        private Playlist playlist;
        public LocalView()
        {
            InitializeComponent();
            playlist = new Playlist("local", "Local Playlist");
            playlist.medias = new List<Media>();
            LoadLocalSong(Helper.defaultPath);
            poisonPanel1.MouseWheel += PoisonPanel1_MouseWheel;
        }



        private void LoadLocalSong(string path)
        {
            var extensions = Helper.GetAllSupportFile();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();

            for (int i = files.Length - 1; i > -1; i--)
            {
                Media media = null;
                var tfile = TagLib.File.Create(files[i]);
                if (tfile is TagLib.Mpeg.AudioFile)
                {
                    Song song = new Song();
                    if (tfile.Tag.Pictures.Length > 0 && tfile.Tag.Pictures != null)
                    {
                        MemoryStream ms = new MemoryStream(tfile.Tag.Pictures[0].Data.Data);
                        song.thumbImg = Image.FromStream(ms);
                    }
                    else
                        song.thumbImg = Properties.Resources.icons8_music_48px_1;
                    if (tfile.Tag.Genres != null && tfile.Tag.Genres.Length > 0)
                    {
                        song.genres = new List<Genre>();
                        foreach (var item in tfile.Tag.Genres)
                        {
                            var gen = new Genre("", item);
                        }
                    }


                    song.title = Helper.NotNullAndNotEmpty(tfile.Tag.Title) ? tfile.Tag.Title : Path.GetFileNameWithoutExtension(files[i]);
                    song.artistNames = Helper.NotNullAndNotEmpty(tfile.Tag.JoinedPerformers) ? tfile.Tag.JoinedPerformers : "Unknown";
                    song.srcLink = files[i];
                    song.duration = (int)tfile.Properties.Duration.TotalSeconds;
                    song.isLocal = true;
                    media = song;
                }

                playlist.medias.Add(media);
                var view = new MediaList(media);
                view.Dock = DockStyle.Top;
                poisonPanel1.Controls.Add(view);
            }

            playlist.medias.Reverse();
        }

        private void PoisonPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            poisonScrollBar1.Maximum = poisonPanel1.VerticalScroll.Maximum;
            poisonScrollBar1.SmallChange = poisonPanel1.VerticalScroll.SmallChange;
            poisonScrollBar1.LargeChange = poisonPanel1.VerticalScroll.LargeChange;
            poisonScrollBar1.Value = poisonPanel1.VerticalScroll.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.Instance.playlist = playlist;
            MainForm.Instance.currIdx = 0;
            MainForm.Instance.PlayMedia();
            MainForm.Instance.LoadViewCurrentPlaylist();
        }
    }
}
