using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Album
    {
        public string id;
        public string title;
        public object thumbImg;
        public List<Artist> artists;
        public string artistsNames;
        public string releaseDate;

        public Album(string id, string title, object thumbImg, List<Artist> artists, string artistsNames, string releaseDate)
        {
            this.id = id;
            this.title = title;
            this.thumbImg = thumbImg;
            this.artists = artists;
            this.artistsNames = artistsNames;
            this.releaseDate = releaseDate;
        }
    }
}
