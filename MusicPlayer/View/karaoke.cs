using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.View
{
    public partial class karaoke : Form
    {
        public karaoke()
        {
            InitializeComponent();
        }
        public karaoke(string url)
        {
            InitializeComponent();
            kPlayer.URL = url;
        }
    }
}
