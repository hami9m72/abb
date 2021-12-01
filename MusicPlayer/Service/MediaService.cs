using MusicPlayer.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Service
{
    public class MediaService
    {
        public static async Task<JObject> GetDataFromURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            // Add our custom headers
            requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JObject.Parse(await response.Content.ReadAsStringAsync());
            return null;
        }

        //public static async Task<Song> GetSongDetail(string songId)
        //{
        //    try
        //    {
        //        var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/full/{songId}");
        //        List<Artist> artists = new List<Artist>();
        //        foreach (var item in data["artists"])
        //        {
        //            artists.Add(new Artist(
        //                item["id"].ToString(),
        //                item["name"].ToString(),
        //                item["thumbnailM"].ToString()
        //            ));
        //        }
        //        List<Genre> genres = new List<Genre>();
        //        foreach (var item in data["genres"])
        //        {
        //            genres.Add(new Genre(
        //                item["id"].ToString(),
        //                item["title"].ToString()
        //            ));
        //        }
        //        Album album = new Album(
        //                data["album"]["encodeId"].ToString(),
        //                data["album"]["title"].ToString(),
        //                data["album"]["thumbnail"].ToString(),
        //                artists,
        //                data["album"]["artistsNames"].ToString(),
        //                data["album"]["releaseDate"].ToString()
        //         );

        //        Song song = new Song
        //        {
        //            id = data["encodeId"].ToString(),
        //            title = data["title"].ToString(),
        //            artistNames = data["artistsNames"].ToString(),
        //            isLocal = false,
        //            duration = Convert.ToInt32(data["duration"].ToString()),
        //            thumbImg = data["thumbnailM"].ToString(),
        //            srcLink = data["streaming"]["128"].ToString(),
        //            releaseDate = Convert.ToInt32(data["releaseDate"].ToString()),
        //            artists = artists,
        //            album = album,
        //            genres = genres,
        //            hasLyric = data["hasLyric"].ToString() == "True"
        //        };
        //        return song;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //}

        public static async Task<Lyric> GetSongLyric(string songId)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{songId}");
                return JsonConvert.DeserializeObject<Lyric>(data.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //public static async Task<Streaming> GetSongStream(string songId)
        //{
        //    try
        //    {
        //        var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/stream/{songId}");
        //        return JsonConvert.DeserializeObject<Streaming>(data.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //}

        //public static async Task<List<Song>> GetSongs(List<string> lstID)
        //{
        //    List<Song> songs = new List<Song>();
        //    foreach (var id in lstID)
        //        songs.Add(await GetSongDetail(id));
        //    return songs;
        //}


    }
}
