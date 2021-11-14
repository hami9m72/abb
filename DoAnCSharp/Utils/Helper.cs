using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Utils
{
    public class Helper
    {
        public static string FormatTime(double time)
        {
            TimeSpan t= TimeSpan.FromSeconds(time);
            return t.ToString(@"hh\:mm\:ss");
        }
    }
}
