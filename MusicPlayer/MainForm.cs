using MusicPlayer.Model;
using MusicPlayer.Service;
using MusicPlayer.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        private static MainForm instance;
        public static MainForm Instance { get => instance; }

        public MainForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void ClearMenu()
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                menuButton.BackColor = Color.FromArgb(25, 26, 31);
        }
        private void ActiveMenu(Button btn, Control view)
        {
            btn.BackColor = Color.FromArgb(255, 128, 0);
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            ClearMenu();
            LocalView view;
            if (!panelContainer.Controls.ContainsKey("LocalView"))
            {
                view = new LocalView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["LocalView"] as LocalView;
            ActiveMenu(sender as Button, view);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClearMenu();

            HomeView view;
            if (!panelContainer.Controls.ContainsKey("HomeView"))
            {
                view = new HomeView();
                panelContainer.Controls.Add(view);
            }
            else
                view = panelContainer.Controls["HomeView"] as HomeView;
            ActiveMenu(sender as Button, view);
        }
    }
}
