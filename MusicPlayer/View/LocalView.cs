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
            LoadLocalSong("C:\\Users\\DAT\\Desktop\\music\\Top 100 VPop");
        }

        private void LoadLocalSong(string path)
        {
            var extensions = Helper.GetAllSupportFile();
            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.Contains(Path.GetExtension(f).ToLower())).ToArray();
            int k = 0;
            for (int i = files.Length - 1; i > -1; i--)
            {
                var tfile = TagLib.File.Create(files[i]);
                if (tfile is TagLib.Mpeg.AudioFile)
                {
                    var view = new MediaList(tfile);
                    view.Dock = DockStyle.Top;
                    pSong.Controls.Add(view);
                }

            }


        }


    }
}
