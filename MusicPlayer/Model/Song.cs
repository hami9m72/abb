using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public abstract class Song
    {
        public bool isLiked = false;
        public abstract string GetTitle();
        public abstract string GetAlbumName();
        public abstract string GetArtistNameJoined();
        public abstract string GetSrc();
        public abstract object GetThumbImg();
        public abstract int GetDuration();
        public abstract string GetFormatedDuration();
    }
}
