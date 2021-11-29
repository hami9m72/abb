using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Playlist
    {
        public string name;
        public List<TagLib.File> files;

        public Playlist()
        {

        }

        public Playlist(string name)
        {
            this.name = name;
            files = new List<TagLib.File>();
        }
    }
}
