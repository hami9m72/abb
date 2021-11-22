using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class TestComponent : Form
    {
        public TestComponent()
        {
            InitializeComponent();
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://vnso-zn-5-tf-mp3-s1-zmp3.zadn.vn/c7eb60c7688681d8d897/413466781816047564?authen=exp=1637747236~acl=/c7eb60c7688681d8d897/*~hmac=c646ce2111862f6bb2758ac61fcdfe97&fs=MTYzNzU3NDQzNjUwNXx3ZWJWNnwwfDExMy4xNjmUsICdUngMTUyLjIwMg";
            
        }
    }
}
