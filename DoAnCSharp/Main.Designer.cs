
namespace DoAnCSharp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar = new ReaLTaiizor.Controls.HopeTrackBar();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.royalEllipseButton1 = new ReaLTaiizor.Controls.RoyalEllipseButton();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMin = new ReaLTaiizor.Controls.ForeverButton();
            this.btnMax = new ReaLTaiizor.Controls.ForeverButton();
            this.btnQuit = new ReaLTaiizor.Controls.ForeverButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(235, 1080);
            this.panel1.MinimumSize = new System.Drawing.Size(72, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 467);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.trackBar);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.royalEllipseButton1);
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 87);
            this.panel2.TabIndex = 1;
            // 
            // trackBar
            // 
            this.trackBar.AlwaysValueVisible = false;
            this.trackBar.BallonArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.trackBar.BallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.trackBar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.trackBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(7)))));
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.FillBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.trackBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.trackBar.ForeColor = System.Drawing.Color.White;
            this.trackBar.HeadBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.trackBar.HeadColor = System.Drawing.Color.Black;
            this.trackBar.Location = new System.Drawing.Point(271, 60);
            this.trackBar.MaxValue = 1000;
            this.trackBar.MinValue = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.ShowValue = false;
            this.trackBar.Size = new System.Drawing.Size(401, 16);
            this.trackBar.TabIndex = 3;
            this.trackBar.Text = "hopeTrackBar1";
            this.trackBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar.UnknownColor = System.Drawing.Color.White;
            this.trackBar.Value = 0;
            this.trackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseMove);
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(769, 35);
            this.button1.Name = "button1";
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // royalEllipseButton1
            // 
            this.royalEllipseButton1.BackColor = System.Drawing.Color.Black;
            this.royalEllipseButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.royalEllipseButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.royalEllipseButton1.BorderThickness = 3;
            this.royalEllipseButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalEllipseButton1.DrawBorder = true;
            this.royalEllipseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.royalEllipseButton1.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.royalEllipseButton1.Image = ((System.Drawing.Image)(resources.GetObject("royalEllipseButton1.Image")));
            this.royalEllipseButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageOnly;
            this.royalEllipseButton1.Location = new System.Drawing.Point(449, 4);
            this.royalEllipseButton1.Name = "royalEllipseButton1";
            this.royalEllipseButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.royalEllipseButton1.PressedForeColor = System.Drawing.Color.White;
            this.royalEllipseButton1.Size = new System.Drawing.Size(45, 45);
            this.royalEllipseButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.royalEllipseButton1.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.panelTitle.Controls.Add(this.btnMin);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnQuit);
            this.panelTitle.Location = new System.Drawing.Point(235, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(709, 39);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.BaseColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.btnMin.Location = new System.Drawing.Point(592, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rounded = false;
            this.btnMin.Size = new System.Drawing.Size(18, 18);
            this.btnMin.TabIndex = 7;
            this.btnMin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.BaseColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.btnMax.Location = new System.Drawing.Point(636, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Rounded = false;
            this.btnMax.Size = new System.Drawing.Size(18, 18);
            this.btnMax.TabIndex = 6;
            this.btnMax.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.BaseColor = System.Drawing.Color.Transparent;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.btnQuit.Location = new System.Drawing.Point(680, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Rounded = false;
            this.btnQuit.Size = new System.Drawing.Size(18, 18);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.MaximumSize = new System.Drawing.Size(235, 39);
            this.panel3.MinimumSize = new System.Drawing.Size(72, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 39);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mPlayer);
            this.panel5.Location = new System.Drawing.Point(331, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 344);
            this.panel5.TabIndex = 8;
            // 
            // mPlayer
            // 
            this.mPlayer.Enabled = true;
            this.mPlayer.Location = new System.Drawing.Point(3, 0);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mPlayer.OcxState")));
            this.mPlayer.Size = new System.Drawing.Size(441, 341);
            this.mPlayer.TabIndex = 0;
            this.mPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mPlayer_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(945, 593);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitle;
        private ReaLTaiizor.Controls.ForeverButton btnQuit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.ForeverButton btnMin;
        private ReaLTaiizor.Controls.ForeverButton btnMax;
        private ReaLTaiizor.Controls.RoyalEllipseButton royalEllipseButton1;
        private ReaLTaiizor.Controls.Button button1;
        private System.Windows.Forms.Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.HopeTrackBar trackBar;
    }
}