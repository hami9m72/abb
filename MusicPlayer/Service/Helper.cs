using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Utils
{
    public class Helper
    {
        public static string defaultPath = "C:\\Users\\DAT\\Desktop\\music\\Top 100 VPop";
        public static string FormatTime(double time)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            return t.ToString(@"hh\:mm\:ss");
        }

        public static async Task<Image> GetImageFromURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            HttpResponseMessage res = await httpClient.SendAsync(req);
            return Image.FromStream(await res.Content.ReadAsStreamAsync());
        }

        public static string[] SupportFile =
        {
            "Windows Media Metafiles (.asx, .wax, .wvx, .wmx, wpl)",
            "Windows Media formats (.asf, .wma, .wmv, .wm)",
            "Microsoft Digital Video Recording (.dvr-ms)",
            "Windows Media Download Package (.wmd)",
            "Audio Visual Interleave (.avi)",
            "Moving Pictures Experts Group (.mpg, .mpeg, .m1v, .mp2, .mp3, .mpa, .mpe, .m3u)",
            "Musical Instrument Digital Interface (.mid, .midi, .rmi)",
            "Audio Interchange File Format (.aif, .aifc, .aiff)",
            "Sun Microsystems and NeXT (.au, .snd)",
            "Audio for Windows (.wav)",
            "CD Audio Track (.cda)",
            "Indeo Video Technology (.ivf)",
            "Windows Media Player Skins (.wmz, .wms)",
            "QuickTime Movie file (.mov)",
            "MP4 Audio file (.m4a)",
            "MP4 Video file (.mp4, .m4v, .mp4v, .3g2, .3gp2, .3gp, .3gpp)",
            "Windows audio file (.aac, .adt, .adts)",
            "MPEG-2 TS Video file (.m2ts)",
            "Free Lossless Audio Codec (.flac)"
        };

        public static List<string> GetAllSupportFile()
        {
            List<string> result = new List<string>();
            foreach (string ext in SupportFile)
            {
                var temp1 = ext.Split(new char[] { '(', ')' });
                var temp2 = temp1[temp1.Length - 2].Split(',');
                foreach (var t in temp2)
                    result.Add(t.Trim());
            }
            return result;
        }

        public static Song ConvertFromLocalFile(string path)
        {
            var tfile = TagLib.File.Create(path);
            Image pic;
            if (tfile is TagLib.Mpeg.AudioFile)
            {
                if (tfile.Tag.Pictures.Length > 0 && tfile.Tag.Pictures != null)
                {
                    MemoryStream ms = new MemoryStream(tfile.Tag.Pictures[0].Data.Data);
                    pic = Image.FromStream(ms);
                }
                else
                    pic = Properties.Resources.icons8_music_48px_1;
            }
            else
                pic = Properties.Resources.icons8_video_48px;

            string songName = "";
            if (tfile.Tag.Title != null)
                songName = tfile.Tag.Title;
            else
                songName = Path.GetFileNameWithoutExtension(path);

            string artistName = "";
            if (tfile.Tag.JoinedPerformers != null)
                artistName = tfile.Tag.JoinedPerformers;

            Song song = new Song();
            song.streaming = new Streaming();
            song.streaming._128 = path;
            song.thumbnailMImg = pic;
            song.title = songName;
            song.artistsNames = artistName;

            return song;
        }
    }
}
