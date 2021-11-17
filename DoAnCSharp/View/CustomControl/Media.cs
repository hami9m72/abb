using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCSharp.View.CustomControl
{
    public partial class Media : UserControl
    {
        public Media()
        {
            InitializeComponent();
            materialRichTextBox1.SelectAll();
            materialRichTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
