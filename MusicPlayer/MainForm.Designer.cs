
namespace MusicPlayer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpMedia = new System.Windows.Forms.TableLayoutPanel();
            this.panelSongInfo = new System.Windows.Forms.Panel();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pbSong = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.trackBar = new ReaLTaiizor.Controls.HopeTrackBar();
            this.lbMaxTime = new System.Windows.Forms.Label();
            this.lbMinTime = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox5 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox4 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox3 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox2 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnPlay = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackbarVolume = new ReaLTaiizor.Controls.HopeTrackBar();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tabPageMedia = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tTrackBar = new System.Windows.Forms.Timer(this.components);
            this.panelPlaying = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tlpMedia.SuspendLayout();
            this.panelSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.tabPageMedia.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.tlpMedia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 514);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 86);
            this.panel1.TabIndex = 0;
            // 
            // tlpMedia
            // 
            this.tlpMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.tlpMedia.ColumnCount = 3;
            this.tlpMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.40132F));
            this.tlpMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.06893F));
            this.tlpMedia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.43532F));
            this.tlpMedia.Controls.Add(this.panelSongInfo, 0, 0);
            this.tlpMedia.Controls.Add(this.panel8, 1, 0);
            this.tlpMedia.Controls.Add(this.panel12, 2, 0);
            this.tlpMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMedia.Location = new System.Drawing.Point(0, 0);
            this.tlpMedia.Name = "tlpMedia";
            this.tlpMedia.RowCount = 1;
            this.tlpMedia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMedia.Size = new System.Drawing.Size(961, 86);
            this.tlpMedia.TabIndex = 7;
            // 
            // panelSongInfo
            // 
            this.panelSongInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.panelSongInfo.Controls.Add(this.lbSongName);
            this.panelSongInfo.Controls.Add(this.pbSong);
            this.panelSongInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSongInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongInfo.Location = new System.Drawing.Point(0, 0);
            this.panelSongInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelSongInfo.Name = "panelSongInfo";
            this.panelSongInfo.Size = new System.Drawing.Size(244, 86);
            this.panelSongInfo.TabIndex = 0;
            this.panelSongInfo.Click += new System.EventHandler(this.panelSongInfo_Click);
            // 
            // lbSongName
            // 
            this.lbSongName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSongName.AutoSize = true;
            this.lbSongName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(109, 8);
            this.lbSongName.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 21);
            this.lbSongName.TabIndex = 3;
            this.lbSongName.Click += new System.EventHandler(this.panelSongInfo_Click);
            // 
            // pbSong
            // 
            this.pbSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSong.Location = new System.Drawing.Point(0, 0);
            this.pbSong.Name = "pbSong";
            this.pbSong.Size = new System.Drawing.Size(103, 86);
            this.pbSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSong.TabIndex = 0;
            this.pbSong.TabStop = false;
            this.pbSong.Click += new System.EventHandler(this.panelSongInfo_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(247, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(504, 80);
            this.panel8.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.trackBar);
            this.panel11.Controls.Add(this.lbMaxTime);
            this.panel11.Controls.Add(this.lbMinTime);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 57);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(504, 23);
            this.panel11.TabIndex = 1;
            // 
            // trackBar
            // 
            this.trackBar.AlwaysValueVisible = false;
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BallonArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackBar.BallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackBar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.trackBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.FillBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.trackBar.ForeColor = System.Drawing.Color.White;
            this.trackBar.HeadBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackBar.HeadColor = System.Drawing.Color.Black;
            this.trackBar.Location = new System.Drawing.Point(76, 4);
            this.trackBar.MaxValue = 1000;
            this.trackBar.MinValue = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.ShowValue = false;
            this.trackBar.Size = new System.Drawing.Size(362, 16);
            this.trackBar.TabIndex = 31;
            this.trackBar.Text = "hopeTrackBar1";
            this.trackBar.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackBar.UnknownColor = System.Drawing.Color.White;
            this.trackBar.Value = 0;
            // 
            // lbMaxTime
            // 
            this.lbMaxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaxTime.AutoSize = true;
            this.lbMaxTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTime.ForeColor = System.Drawing.Color.White;
            this.lbMaxTime.Location = new System.Drawing.Point(441, -2);
            this.lbMaxTime.Name = "lbMaxTime";
            this.lbMaxTime.Size = new System.Drawing.Size(49, 21);
            this.lbMaxTime.TabIndex = 30;
            this.lbMaxTime.Text = "00:00";
            // 
            // lbMinTime
            // 
            this.lbMinTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinTime.ForeColor = System.Drawing.Color.White;
            this.lbMinTime.Location = new System.Drawing.Point(0, -2);
            this.lbMinTime.Name = "lbMinTime";
            this.lbMinTime.Size = new System.Drawing.Size(70, 28);
            this.lbMinTime.TabIndex = 23;
            this.lbMinTime.Text = "00:00";
            this.lbMinTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.rjCircularPictureBox5);
            this.panel10.Controls.Add(this.rjCircularPictureBox4);
            this.panel10.Controls.Add(this.rjCircularPictureBox3);
            this.panel10.Controls.Add(this.rjCircularPictureBox2);
            this.panel10.Controls.Add(this.btnPlay);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(504, 57);
            this.panel10.TabIndex = 0;
            // 
            // rjCircularPictureBox5
            // 
            this.rjCircularPictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rjCircularPictureBox5.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_shuffle_24px;
            this.rjCircularPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjCircularPictureBox5.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox5.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox5.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox5.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox5.BorderSize = 0;
            this.rjCircularPictureBox5.GradientAngle = 50F;
            this.rjCircularPictureBox5.Location = new System.Drawing.Point(127, 5);
            this.rjCircularPictureBox5.Name = "rjCircularPictureBox5";
            this.rjCircularPictureBox5.Size = new System.Drawing.Size(41, 41);
            this.rjCircularPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox5.TabIndex = 25;
            this.rjCircularPictureBox5.TabStop = false;
            // 
            // rjCircularPictureBox4
            // 
            this.rjCircularPictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rjCircularPictureBox4.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_repeat_24px;
            this.rjCircularPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjCircularPictureBox4.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox4.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox4.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox4.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox4.BorderSize = 0;
            this.rjCircularPictureBox4.GradientAngle = 50F;
            this.rjCircularPictureBox4.Location = new System.Drawing.Point(337, 5);
            this.rjCircularPictureBox4.Name = "rjCircularPictureBox4";
            this.rjCircularPictureBox4.Size = new System.Drawing.Size(41, 41);
            this.rjCircularPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox4.TabIndex = 24;
            this.rjCircularPictureBox4.TabStop = false;
            // 
            // rjCircularPictureBox3
            // 
            this.rjCircularPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rjCircularPictureBox3.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_end_24px;
            this.rjCircularPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjCircularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox3.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox3.BorderSize = 0;
            this.rjCircularPictureBox3.GradientAngle = 50F;
            this.rjCircularPictureBox3.Location = new System.Drawing.Point(290, 5);
            this.rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            this.rjCircularPictureBox3.Size = new System.Drawing.Size(41, 41);
            this.rjCircularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox3.TabIndex = 23;
            this.rjCircularPictureBox3.TabStop = false;
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rjCircularPictureBox2.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_skip_to_start_24px;
            this.rjCircularPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 0;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(174, 5);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(41, 41);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox2.TabIndex = 22;
            this.rjCircularPictureBox2.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_play_32px;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnPlay.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnPlay.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnPlay.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnPlay.BorderSize = 2;
            this.btnPlay.GradientAngle = 50F;
            this.btnPlay.Location = new System.Drawing.Point(233, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(51, 51);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPlay.TabIndex = 21;
            this.btnPlay.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.mPlayer);
            this.panel12.Controls.Add(this.pictureBox2);
            this.panel12.Controls.Add(this.trackbarVolume);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(757, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(201, 80);
            this.panel12.TabIndex = 2;
            // 
            // mPlayer
            // 
            this.mPlayer.Enabled = true;
            this.mPlayer.Location = new System.Drawing.Point(15, 62);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mPlayer.OcxState")));
            this.mPlayer.Size = new System.Drawing.Size(10, 11);
            this.mPlayer.TabIndex = 5;
            this.mPlayer.Visible = false;
            this.mPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mPlayer_PlayStateChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_speaker_26px;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // trackbarVolume
            // 
            this.trackbarVolume.AlwaysValueVisible = false;
            this.trackbarVolume.BallonArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackbarVolume.BallonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackbarVolume.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
            this.trackbarVolume.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.trackbarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackbarVolume.FillBarColor = System.Drawing.Color.HotPink;
            this.trackbarVolume.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.trackbarVolume.ForeColor = System.Drawing.Color.White;
            this.trackbarVolume.HeadBorderColor = System.Drawing.Color.HotPink;
            this.trackbarVolume.HeadColor = System.Drawing.Color.Black;
            this.trackbarVolume.Location = new System.Drawing.Point(41, 7);
            this.trackbarVolume.MaxValue = 100;
            this.trackbarVolume.MinValue = 0;
            this.trackbarVolume.Name = "trackbarVolume";
            this.trackbarVolume.ShowValue = false;
            this.trackbarVolume.Size = new System.Drawing.Size(120, 16);
            this.trackbarVolume.TabIndex = 3;
            this.trackbarVolume.Text = "hopeTrackBar1";
            this.trackbarVolume.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.trackbarVolume.UnknownColor = System.Drawing.Color.White;
            this.trackbarVolume.Value = 50;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button7);
            this.panelMenu.Controls.Add(this.button6);
            this.panelMenu.Controls.Add(this.btnLocal);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(212, 514);
            this.panelMenu.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::MusicPlayer.Properties.Resources.icons8_love_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 220);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(212, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "          Yêu thích";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MusicPlayer.Properties.Resources.icons8_playlist_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "          Playlist";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::MusicPlayer.Properties.Resources.icons8_settings_24px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 461);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(212, 53);
            this.button7.TabIndex = 10;
            this.button7.Text = "          Cài đặt";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::MusicPlayer.Properties.Resources.icons8_search_24px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 114);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(212, 53);
            this.button6.TabIndex = 9;
            this.button6.Text = "          Tìm kiếm";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnLocal
            // 
            this.btnLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLocal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocal.FlatAppearance.BorderSize = 0;
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.Image = global::MusicPlayer.Properties.Resources.icons8_music_24px;
            this.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.Location = new System.Drawing.Point(0, 61);
            this.btnLocal.Margin = new System.Windows.Forms.Padding(0);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLocal.Size = new System.Drawing.Size(212, 53);
            this.btnLocal.TabIndex = 8;
            this.btnLocal.Text = "          Nhạc của tôi";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.UseVisualStyleBackColor = false;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 60);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "DPlayer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_music_96px_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelContainer.Controls.Add(this.tabPageMedia);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(212, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(749, 514);
            this.panelContainer.TabIndex = 4;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPageMedia.Controls.Add(this.tabPage1);
            this.tabPageMedia.Controls.Add(this.tabPage2);
            this.tabPageMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPageMedia.ForeColorA = System.Drawing.Color.White;
            this.tabPageMedia.ForeColorB = System.Drawing.Color.Silver;
            this.tabPageMedia.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageMedia.ItemSize = new System.Drawing.Size(120, 40);
            this.tabPageMedia.Location = new System.Drawing.Point(0, 0);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.SelectedIndex = 0;
            this.tabPageMedia.Size = new System.Drawing.Size(749, 514);
            this.tabPageMedia.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPageMedia.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPageMedia.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            this.tabPageMedia.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPage1.Controls.Add(this.panelPlaying);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách phát";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lời bài hát";
            // 
            // tTrackBar
            // 
            this.tTrackBar.Tick += new System.EventHandler(this.tTrackBar_Tick);
            // 
            // panelPlaying
            // 
            this.panelPlaying.AutoScroll = true;
            this.panelPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaying.Location = new System.Drawing.Point(3, 3);
            this.panelPlaying.Name = "panelPlaying";
            this.panelPlaying.Size = new System.Drawing.Size(743, 468);
            this.panelPlaying.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(961, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tlpMedia.ResumeLayout(false);
            this.panelSongInfo.ResumeLayout(false);
            this.panelSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.tabPageMedia.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tlpMedia;
        private System.Windows.Forms.Panel panelSongInfo;
        private System.Windows.Forms.PictureBox pbSong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private ReaLTaiizor.Controls.HopeTrackBar trackBar;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.Label lbMinTime;
        private System.Windows.Forms.Panel panel10;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox5;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox4;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox3;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox2;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnPlay;
        private System.Windows.Forms.Panel panel12;
        private ReaLTaiizor.Controls.HopeTrackBar trackbarVolume;
        private System.Windows.Forms.Timer tTrackBar;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private ReaLTaiizor.Controls.HopeTabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelPlaying;
    }
}
