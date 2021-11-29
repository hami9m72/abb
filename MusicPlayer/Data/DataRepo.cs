using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Data
{
    public static class DataRepo
    {
        public static Playlist isPlaying;
        public static int idxPlaying = -1;


        public static TagLib.File GetIsPlayingSong()
        {
            return isPlaying.files[idxPlaying];
        }
    }
}
