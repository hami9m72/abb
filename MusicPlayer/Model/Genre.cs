using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Genre
    {
        public string id;
        public string title;

        public Genre(string id, string title)
        {
            this.id = id;
            this.title = title;
        }
    }
}
