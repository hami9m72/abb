using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Model
{
    public class Media
    {
        public string id;
        public string title;
        public string artistNames;
        public int duration; // second
        public bool isLocal;
        public string type;
        public string srcLink;
        public int releaseDate;// unix timestamp

        public override bool Equals(object obj)
        {
            return obj is Media media &&
                   srcLink == media.srcLink;
        }
    }
}
