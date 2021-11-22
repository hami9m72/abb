using DoAnCSharp.View.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View
{
    public partial class MyMusicView : UserControl
    {
        public MyMusicView()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                var view = new MediaList();
                view.Dock = DockStyle.Top;
                if (i % 2 == 0)
                    view.BackColor = Color.Red;
                else
                    view.BackColor = Color.Blue;
                poisonPanel1.Controls.Add(view);
            }
            poisonPanel1.MouseWheel += PoisonPanel1_MouseWheel;
            
            

        }

        private void PoisonPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            poisonScrollBar1.Maximum = poisonPanel1.VerticalScroll.Maximum;
            poisonScrollBar1.SmallChange = poisonPanel1.VerticalScroll.SmallChange;
            poisonScrollBar1.LargeChange = poisonPanel1.VerticalScroll.LargeChange;
            poisonScrollBar1.Value= poisonPanel1.VerticalScroll.Value;
            
        }

        

        private void poisonPanel1_VerticalScrolled(object sender, ScrollEventArgs e)
        {
            Console.WriteLine("1");
        }
    }
}
