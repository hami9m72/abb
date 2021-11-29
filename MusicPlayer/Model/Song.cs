using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Song : Media
    {
        public object thumbImg;
        public Lyric lyric;
        public List<Artist> artists;
        public List<Genre> genres;
        public Album album;
        public bool hasLyric;

        public Song()
        {
            type = "song";
        }
    }
}
