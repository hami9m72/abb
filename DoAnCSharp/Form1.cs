using DoAnCSharp.GoogleDriveAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var files = DriveHelper.GetFilesInFloder(textBox1.Text);
            // "https://drive.google.com/uc?id=14H59EJconqc17YUreMOFFkr5oj93sAsn&export=download"

            //mPlayer.URL = files[0].WebContentLink;
            StreamMp3("14H59EJconqc17YUreMOFFkr5oj93sAsn");
            mPlayer.Controls.p
        }

        private void StreamMp3(object fileID)
        {

            var url = $"https://www.googleapis.com/drive/v3/files/{fileID}?alt=media";
            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.PreAuthenticate = true;
            webRequest.Headers.Add("Authorization", "Bearer " + DriveHelper.GetAccessToken());
            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException e)
            {
                if (e.Status != WebExceptionStatus.RequestCanceled)
                {
                    Console.WriteLine(e.Message);
                }
                return;
            }
        }
    }
}
