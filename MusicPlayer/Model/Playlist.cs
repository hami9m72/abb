using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Playlist
    {
        public string id;
        public string name;
        public List<Media> medias;

        public Playlist(string id, string name)
        {
            this.id = id;
            this.name = name;
            this.medias = new List<Media>();
        }
    }
}
