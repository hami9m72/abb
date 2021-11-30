using MusicPlayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MusicPlayer.Model
{
    public class SongLocal : Song
    {
        public File file;

        public SongLocal(File file)
        {
            this.file = file;
        }

        public override string GetAlbumName()
        {
            return file.Tag.Album;
        }

        public override string GetArtistNameJoined()
        {
            return file.Tag.JoinedPerformers;
        }

        public override int GetDuration()
        {
            return (int)file.Properties.Duration.TotalSeconds;
        }

        public override string GetFormatedDuration()
        {
            return TimeSpan.FromSeconds(GetDuration()).ToString(@"mm\:ss");
        }

        public override string GetSrc()
        {
            return file.Name;
        }

        public override object GetThumbImg()
        {
            if (file.Tag.Pictures.Length > 0)
                return Helper.LoadImageFromByteArray(file.Tag.Pictures[0].Data.Data);
            return null;
        }

        public override string GetTitle()
        {
            return file.Tag.Title;
        }
    }
}
