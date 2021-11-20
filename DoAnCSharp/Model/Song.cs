using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Model
{
    public class Song
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Artist
        {
            public string id { get; set; }
            public string name { get; set; }
            public string link { get; set; }
            public bool spotlight { get; set; }
            public string alias { get; set; }
            public string thumbnail { get; set; }
            public string thumbnailM { get; set; }
            public int totalFollow { get; set; }
        }

        public class Genre
        {
            public string id { get; set; }
            public string name { get; set; }
            public string title { get; set; }
            public string alias { get; set; }
            public string link { get; set; }
        }

        public class Composer
        {
            public string id { get; set; }
            public string name { get; set; }
            public string link { get; set; }
            public bool spotlight { get; set; }
            public string alias { get; set; }
            public string playlistId { get; set; }
            public string cover { get; set; }
            public string thumbnail { get; set; }
            public int totalFollow { get; set; }
        }

        public class Album
        {
            public string encodeId { get; set; }
            public string title { get; set; }
            public string thumbnail { get; set; }
            public bool isoffical { get; set; }
            public string link { get; set; }
            public bool isIndie { get; set; }
            public string releaseDate { get; set; }
            public string sortDescription { get; set; }
            public bool PR { get; set; }
            public List<Artist> artists { get; set; }
            public string artistsNames { get; set; }
        }

        public class Streaming
        {
            public string _128 { get; set; }
            public string _320 { get; set; }
        }

        public class Root
        {
            public string encodeId { get; set; }
            public string title { get; set; }
            public string alias { get; set; }
            public bool isOffical { get; set; }
            public string username { get; set; }
            public string artistsNames { get; set; }
            public List<Artist> artists { get; set; }
            public bool isWorldWide { get; set; }
            public string thumbnailM { get; set; }
            public string link { get; set; }
            public string thumbnail { get; set; }
            public int duration { get; set; }
            public bool isZMA { get; set; }
            public bool zingChoise { get; set; }
            public bool isPrivate { get; set; }
            public bool preRelease { get; set; }
            public int releaseDate { get; set; }
            public List<object> indicators { get; set; }
            public int radioId { get; set; }
            public bool isIndie { get; set; }
            public int streamingStatus { get; set; }
            public bool allowAudioAds { get; set; }
            public bool hasLyric { get; set; }
            public int userid { get; set; }
            public List<Genre> genres { get; set; }
            public List<Composer> composers { get; set; }
            public Album album { get; set; }
            public bool isRBT { get; set; }
            public int like { get; set; }
            public int listen { get; set; }
            public bool liked { get; set; }
            public int comment { get; set; }
            public Streaming streaming { get; set; }
        }


    }
}
