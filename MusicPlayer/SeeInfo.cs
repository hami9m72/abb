using MusicPlayer.Model;
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
namespace MusicPlayer
{
    public partial class SeeInfo : Form
    {
        Song song2;
        public SeeInfo(Song song)
        {
            InitializeComponent();
            song2 = song;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void SeeInfo_Load(object sender, EventArgs e)
        {
            lbCountry.Text = song2.GetAlbumName();
            lbArtist.Text = GetSongArtist(song2.GetSrc());
            lbName.Text = Path.GetFileNameWithoutExtension(song2.GetSrc());
            
        }
        private string GetSongArtist(string filePath)
        {
            try
            {
                TagLib.File file = TagLib.File.Create(filePath);

                string artist = string.Join(", ", file.Tag.Performers);

                return artist;
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
