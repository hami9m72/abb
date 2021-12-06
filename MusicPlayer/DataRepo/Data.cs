using MusicPlayer.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MusicPlayer.DataRepo
{
    public static class Data
    {
        #region setting
        public static string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "/dplayer";
        public static List<string> localPath = new List<string>();
        public static string downloadPath = "";
        public static string karaokePath = "";

        public static void SaveSetting()
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
            using (StreamWriter writetext = new StreamWriter(basePath + "/setting.txt"))
            {
                writetext.WriteLine(string.Join(";", localPath));
                writetext.WriteLine(downloadPath);
                writetext.WriteLine(karaokePath);
            }
        }

        public static void LoadSetting()
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
            if (File.Exists(basePath + "/setting.txt"))
            {
                using (StreamReader readtext = new StreamReader(basePath + "/setting.txt"))
                {
                    localPath.AddRange(readtext.ReadLine().Split(';').ToArray());
                    downloadPath = readtext.ReadLine();
                    karaokePath = readtext.ReadLine();
                }
            }

        }
        #endregion

        public static List<Playlist> MyPlaylist = new List<Playlist>();
        public static void CreatePlayList(string name)
        {
            MyPlaylist.Add(new Playlist(name));
        }
        public static void AddSongToPlayList(int idx, Song song)
        {
            MyPlaylist[idx].files.Add(song);
        }
        public static void SaveMyPlayList()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Playlists");
            xmlDoc.AppendChild(rootNode);

            foreach (var playlist in MyPlaylist)
            {
                XmlNode pNode = xmlDoc.CreateElement("Playlist");
                XmlAttribute attribute = xmlDoc.CreateAttribute("name");
                attribute.Value = playlist.name;
                pNode.Attributes.Append(attribute);

                foreach (var path in playlist.files.Select(e => e.GetSrc()))
                {
                    XmlNode pathNode = xmlDoc.CreateElement("Path");
                    pathNode.InnerText = path;
                    pNode.AppendChild(pathNode);
                }
                rootNode.AppendChild(pNode);
            }
            xmlDoc.Save(basePath + "/playlists.xml");
        }
        public static void LoadMyPlayList()
        {
            if (File.Exists(basePath + "/playlists.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(basePath + "/playlists.xml");
                XmlNodeList pNodes = xmlDoc.SelectNodes("//Playlist");
                foreach (XmlNode p in pNodes)
                {
                    Playlist playlist = new Playlist(p.Attributes["name"].Value);
                    foreach (XmlNode s in p.ChildNodes)
                    {
                        if (File.Exists(s.InnerText))
                        {
                            TagLib.File file = TagLib.File.Create(s.InnerText);
                            Song song = new SongLocal(file);
                            playlist.files.Add(song);
                        }

                    }
                    MyPlaylist.Add(playlist);
                }
            }
        }
    }
}
