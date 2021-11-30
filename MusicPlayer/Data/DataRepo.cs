using MusicPlayer.Model;
using MusicPlayer.Utils;
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
        public static List<int> playingOrder;


        public static Playlist favorite = new Playlist("favorite");

        public static Song GetIsPlayingSong()
        {
            return isPlaying.files[idxPlaying];
        }

        public static void ShufferPlaying()
        {
            List<int> values = Enumerable.Range(0, isPlaying.files.Count).ToList();
            Helper.Shuffle(values);
            playingOrder = values;
        }
        public static void NormalPlaying()
        {
            playingOrder = Enumerable.Range(0, isPlaying.files.Count).ToList();
        }


        public static void AddToFavorite(Song song)
        {
            favorite.files.Add(song);

        }

        public static bool DelFromFavorite(Song song)
        {
            return favorite.files.Remove(song);
        }
    }
}
