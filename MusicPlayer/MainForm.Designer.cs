
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
            this.btnShuffer = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnRepeat = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnNext = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnBack = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnPlay = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackbarVolume = new ReaLTaiizor.Controls.HopeTrackBar();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnKaraoke = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle2 = new System.Windows.Forms.Panel();
            this.tTrackBar = new System.Windows.Forms.Timer(this.components);
            this.panelTitle1 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tabPageMedia = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPlaying = new System.Windows.Forms.TabPage();
            this.panelPlaying = new System.Windows.Forms.Panel();
            this.tabLyric = new System.Windows.Forms.TabPage();
            this.rtbLyric = new System.Windows.Forms.RichTextBox();
            this.timerLyric = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tlpMedia.SuspendLayout();
            this.panelSongInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.tabPageMedia.SuspendLayout();
            this.tabPlaying.SuspendLayout();
            this.tabLyric.SuspendLayout();
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
            this.trackBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseMove);
            this.trackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
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
            this.panel10.Controls.Add(this.btnShuffer);
            this.panel10.Controls.Add(this.btnRepeat);
            this.panel10.Controls.Add(this.btnNext);
            this.panel10.Controls.Add(this.btnBack);
            this.panel10.Controls.Add(this.btnPlay);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(504, 57);
            this.panel10.TabIndex = 0;
            // 
            // btnShuffer
            // 
            this.btnShuffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnShuffer.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_shuffle_24px;
            this.btnShuffer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShuffer.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnShuffer.BorderColor = System.Drawing.Color.White;
            this.btnShuffer.BorderColor2 = System.Drawing.Color.White;
            this.btnShuffer.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnShuffer.BorderSize = 0;
            this.btnShuffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShuffer.GradientAngle = 50F;
            this.btnShuffer.Location = new System.Drawing.Point(127, 5);
            this.btnShuffer.Name = "btnShuffer";
            this.btnShuffer.Size = new System.Drawing.Size(41, 41);
            this.btnShuffer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShuffer.TabIndex = 25;
            this.btnShuffer.TabStop = false;
            this.btnShuffer.Tag = "f";
            this.btnShuffer.Click += new System.EventHandler(this.btnShuffer_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRepeat.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_repeat_24px;
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRepeat.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnRepeat.BorderColor = System.Drawing.Color.White;
            this.btnRepeat.BorderColor2 = System.Drawing.Color.White;
            this.btnRepeat.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnRepeat.BorderSize = 0;
            this.btnRepeat.GradientAngle = 50F;
            this.btnRepeat.Location = new System.Drawing.Point(337, 5);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(41, 41);
            this.btnRepeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnRepeat.TabIndex = 24;
            this.btnRepeat.TabStop = false;
            this.btnRepeat.Tag = "off";
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            this.btnRepeat.MouseHover += new System.EventHandler(this.btnRepeat_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_end_24px;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnNext.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnNext.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnNext.BorderSize = 0;
            this.btnNext.GradientAngle = 50F;
            this.btnNext.Location = new System.Drawing.Point(290, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 41);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNext.TabIndex = 23;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBack.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_skip_to_start_24px;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.btnBack.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.BorderColor2 = System.Drawing.Color.HotPink;
            this.btnBack.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.btnBack.BorderSize = 0;
            this.btnBack.GradientAngle = 50F;
            this.btnBack.Location = new System.Drawing.Point(174, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(41, 41);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnBack.TabIndex = 22;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
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
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.trackbarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.trackbarVolume.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackbarVolume_MouseMove);
            this.trackbarVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackbarVolume_MouseUp);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panelMenu.Controls.Add(this.btnKaraoke);
            this.panelMenu.Controls.Add(this.btnPlaylist);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnSearch);
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
            // btnKaraoke
            // 
            this.btnKaraoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnKaraoke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaraoke.FlatAppearance.BorderSize = 0;
            this.btnKaraoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaraoke.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaraoke.Image = global::MusicPlayer.Properties.Resources.icons8_micro_24px;
            this.btnKaraoke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaraoke.Location = new System.Drawing.Point(0, 220);
            this.btnKaraoke.Margin = new System.Windows.Forms.Padding(0);
            this.btnKaraoke.Name = "btnKaraoke";
            this.btnKaraoke.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKaraoke.Size = new System.Drawing.Size(212, 53);
            this.btnKaraoke.TabIndex = 13;
            this.btnKaraoke.Text = "          Karaoke";
            this.btnKaraoke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaraoke.UseVisualStyleBackColor = false;
            this.btnKaraoke.Click += new System.EventHandler(this.btnKaraoke_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.Image = global::MusicPlayer.Properties.Resources.icons8_playlist_24px;
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 167);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(212, 53);
            this.btnPlaylist.TabIndex = 11;
            this.btnPlaylist.Text = "          Playlist";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Image = global::MusicPlayer.Properties.Resources.icons8_settings_24px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 461);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(212, 53);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "          Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::MusicPlayer.Properties.Resources.icons8_search_24px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 114);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(212, 53);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "          Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.panel2.Controls.Add(this.panelTitle2);
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
            this.label1.Location = new System.Drawing.Point(69, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "DPlayer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_music_96px_3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle2
            // 
            this.panelTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle2.Location = new System.Drawing.Point(0, 0);
            this.panelTitle2.Name = "panelTitle2";
            this.panelTitle2.Size = new System.Drawing.Size(212, 25);
            this.panelTitle2.TabIndex = 0;
            this.panelTitle2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // tTrackBar
            // 
            this.tTrackBar.Tick += new System.EventHandler(this.tTrackBar_Tick);
            // 
            // panelTitle1
            // 
            this.panelTitle1.Controls.Add(this.btnMin);
            this.panelTitle1.Controls.Add(this.btnMax);
            this.panelTitle1.Controls.Add(this.btnExit);
            this.panelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle1.Location = new System.Drawing.Point(212, 0);
            this.panelTitle1.Name = "panelTitle1";
            this.panelTitle1.Size = new System.Drawing.Size(749, 25);
            this.panelTitle1.TabIndex = 3;
            this.panelTitle1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::MusicPlayer.Properties.Resources.icons8_minus_16px;
            this.btnMin.Location = new System.Drawing.Point(599, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::MusicPlayer.Properties.Resources.icons8_rectangular_16px_1;
            this.btnMax.Location = new System.Drawing.Point(649, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 25);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::MusicPlayer.Properties.Resources.icons8_delete_16px;
            this.btnExit.Location = new System.Drawing.Point(699, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelContainer.Controls.Add(this.tabPageMedia);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(212, 25);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(749, 489);
            this.panelContainer.TabIndex = 5;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPageMedia.Controls.Add(this.tabPlaying);
            this.tabPageMedia.Controls.Add(this.tabLyric);
            this.tabPageMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageMedia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabPageMedia.ForeColorA = System.Drawing.Color.White;
            this.tabPageMedia.ForeColorB = System.Drawing.Color.Silver;
            this.tabPageMedia.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPageMedia.ItemSize = new System.Drawing.Size(120, 40);
            this.tabPageMedia.Location = new System.Drawing.Point(0, 0);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.SelectedIndex = 0;
            this.tabPageMedia.Size = new System.Drawing.Size(749, 489);
            this.tabPageMedia.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPageMedia.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.tabPageMedia.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            this.tabPageMedia.Visible = false;
            this.tabPageMedia.SelectedIndexChanged += new System.EventHandler(this.tabPageMedia_SelectedIndexChanged);
            // 
            // tabPlaying
            // 
            this.tabPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPlaying.Controls.Add(this.panelPlaying);
            this.tabPlaying.Location = new System.Drawing.Point(0, 40);
            this.tabPlaying.Name = "tabPlaying";
            this.tabPlaying.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaying.Size = new System.Drawing.Size(749, 449);
            this.tabPlaying.TabIndex = 0;
            this.tabPlaying.Text = "Danh sách phát";
            // 
            // panelPlaying
            // 
            this.panelPlaying.AutoScroll = true;
            this.panelPlaying.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlaying.Location = new System.Drawing.Point(3, 3);
            this.panelPlaying.Name = "panelPlaying";
            this.panelPlaying.Size = new System.Drawing.Size(743, 443);
            this.panelPlaying.TabIndex = 0;
            // 
            // tabLyric
            // 
            this.tabLyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabLyric.Controls.Add(this.rtbLyric);
            this.tabLyric.Location = new System.Drawing.Point(0, 40);
            this.tabLyric.Name = "tabLyric";
            this.tabLyric.Padding = new System.Windows.Forms.Padding(3);
            this.tabLyric.Size = new System.Drawing.Size(749, 449);
            this.tabLyric.TabIndex = 1;
            this.tabLyric.Text = "Lời bài hát";
            // 
            // rtbLyric
            // 
            this.rtbLyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.rtbLyric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLyric.DetectUrls = false;
            this.rtbLyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLyric.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLyric.ForeColor = System.Drawing.Color.White;
            this.rtbLyric.Location = new System.Drawing.Point(3, 3);
            this.rtbLyric.Name = "rtbLyric";
            this.rtbLyric.ReadOnly = true;
            this.rtbLyric.Size = new System.Drawing.Size(743, 443);
            this.rtbLyric.TabIndex = 1;
            this.rtbLyric.Text = "";
            // 
            // timerLyric
            // 
            this.timerLyric.Interval = 200;
            this.timerLyric.Tick += new System.EventHandler(this.timerLyric_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(961, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitle1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.tlpMedia.ResumeLayout(false);
            this.panelSongInfo.ResumeLayout(false);
            this.panelSongInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnShuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.tabPageMedia.ResumeLayout(false);
            this.tabPlaying.ResumeLayout(false);
            this.tabLyric.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tlpMedia;
        private System.Windows.Forms.Panel panelSongInfo;
        private System.Windows.Forms.PictureBox pbSong;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private ReaLTaiizor.Controls.HopeTrackBar trackBar;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.Label lbMinTime;
        private System.Windows.Forms.Panel panel10;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnShuffer;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnRepeat;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnNext;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnBack;
        private RJCodeAdvance.RJControls.RJCircularPictureBox btnPlay;
        private System.Windows.Forms.Panel panel12;
        private ReaLTaiizor.Controls.HopeTrackBar trackbarVolume;
        private System.Windows.Forms.Timer tTrackBar;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPlaylist;
        private AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.Panel panelTitle1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelContainer;
        private ReaLTaiizor.Controls.HopeTabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPlaying;
        private System.Windows.Forms.Panel panelPlaying;
        private System.Windows.Forms.TabPage tabLyric;
        private System.Windows.Forms.RichTextBox rtbLyric;
        private System.Windows.Forms.Timer timerLyric;
        private System.Windows.Forms.Button btnKaraoke;
    }
}
