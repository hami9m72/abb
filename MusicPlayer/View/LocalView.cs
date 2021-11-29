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
        public LocalView()
        {
            InitializeComponent();
            LoadLocalSong(Helper.defaultPath);
            poisonPanel1.MouseWheel += PoisonPanel1_MouseWheel;
        }

        private void LoadLocalSong(string path)
        {
            var extensions = Helper.GetAllSupportFile();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                var tfile = TagLib.File.Create(files[i]);
                Image pic;
                if (tfile is TagLib.Mpeg.AudioFile)
                {
                    if (tfile.Tag.Pictures.Length > 0 && tfile.Tag.Pictures != null)
                    {
                        MemoryStream ms = new MemoryStream(tfile.Tag.Pictures[0].Data.Data);
                        pic = Image.FromStream(ms);
                    }
                    else
                        pic = Properties.Resources.icons8_music_48px_1;
                }
                else
                    pic = Properties.Resources.icons8_video_48px;

                string songName = "";
                if (tfile.Tag.Title != null)
                    songName = tfile.Tag.Title;
                else
                    songName = Path.GetFileNameWithoutExtension(files[i]);

                string artistName = "";
                if (tfile.Tag.JoinedPerformers != null)
                    artistName = tfile.Tag.JoinedPerformers;

                Song song = new Song();
                song.streaming = new Streaming();
                song.streaming._128 = files[i];
                song.thumbnailMImg = pic;
                song.title = songName;
                song.artistsNames = artistName;
                song.genres = new List<Genre>();
                song.duration = (int)tfile.Properties.Duration.TotalSeconds;
                foreach (var item in tfile.Tag.Genres)
                {
                    var gen = new Genre();
                    gen.name = item;
                    song.genres.Add(gen);
                }

                var view = new MediaList(pic, song);
                view.Dock = DockStyle.Top;
                poisonPanel1.Controls.Add(view);
            }
        }

        private void PoisonPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            poisonScrollBar1.Maximum = poisonPanel1.VerticalScroll.Maximum;
            poisonScrollBar1.SmallChange = poisonPanel1.VerticalScroll.SmallChange;
            poisonScrollBar1.LargeChange = poisonPanel1.VerticalScroll.LargeChange;
            poisonScrollBar1.Value = poisonPanel1.VerticalScroll.Value;
        }
    }
}
