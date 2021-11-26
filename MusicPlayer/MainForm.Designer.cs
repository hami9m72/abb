
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelLyric = new System.Windows.Forms.Panel();
            this.tlpMedia = new System.Windows.Forms.TableLayoutPanel();
            this.panelSongInfo = new System.Windows.Forms.Panel();
            this.lbSongArtist = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.trackBar = new ReaLTaiizor.Controls.HopeTrackBar();
            this.lbMaxTime = new System.Windows.Forms.Label();
            this.lbMinTime = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.trackbarVolume = new ReaLTaiizor.Controls.HopeTrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMin = new RJCodeAdvance.RJControls.RJButton();
            this.btnMax = new RJCodeAdvance.RJControls.RJButton();
            this.btnExit = new RJCodeAdvance.RJControls.RJButton();
            this.pbSong = new System.Windows.Forms.PictureBox();
            this.rjCircularPictureBox5 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox4 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox3 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rjCircularPictureBox2 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.btnPlay = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.hopeTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpMedia.SuspendLayout();
            this.panelSongInfo.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
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
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.btnMin);
            this.panelTitle.Controls.Add(this.btnMax);
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(961, 22);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 492);
            this.panel3.TabIndex = 2;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 1);
            this.panel5.TabIndex = 7;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panelMedia);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(212, 22);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(749, 492);
            this.panelContainer.TabIndex = 4;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.hopeTabPage1);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMedia.Location = new System.Drawing.Point(0, 0);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(749, 492);
            this.panelMedia.TabIndex = 0;
            // 
            // hopeTabPage1
            // 
            this.hopeTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.hopeTabPage1.Controls.Add(this.tabPage1);
            this.hopeTabPage1.Controls.Add(this.tabPage2);
            this.hopeTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hopeTabPage1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTabPage1.ForeColorA = System.Drawing.Color.White;
            this.hopeTabPage1.ForeColorB = System.Drawing.Color.Silver;
            this.hopeTabPage1.ForeColorC = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ItemSize = new System.Drawing.Size(120, 40);
            this.hopeTabPage1.Location = new System.Drawing.Point(0, 0);
            this.hopeTabPage1.Name = "hopeTabPage1";
            this.hopeTabPage1.Padding = new System.Drawing.Point(0, 0);
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(749, 492);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.TabIndex = 0;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.mPlayer);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(749, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách phát";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(503, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(246, 452);
            this.panel6.TabIndex = 1;
            // 
            // mPlayer
            // 
            this.mPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPlayer.Enabled = true;
            this.mPlayer.Location = new System.Drawing.Point(0, 0);
            this.mPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.mPlayer.Name = "mPlayer";
            this.mPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mPlayer.OcxState")));
            this.mPlayer.Size = new System.Drawing.Size(749, 452);
            this.mPlayer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelLyric);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(749, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Karaoke";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelLyric
            // 
            this.panelLyric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panelLyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLyric.Location = new System.Drawing.Point(0, 0);
            this.panelLyric.Margin = new System.Windows.Forms.Padding(0);
            this.panelLyric.Name = "panelLyric";
            this.panelLyric.Size = new System.Drawing.Size(749, 452);
            this.panelLyric.TabIndex = 0;
            this.panelLyric.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLyric_Paint);
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
            this.panelSongInfo.Controls.Add(this.lbSongArtist);
            this.panelSongInfo.Controls.Add(this.lbSongName);
            this.panelSongInfo.Controls.Add(this.pbSong);
            this.panelSongInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSongInfo.Location = new System.Drawing.Point(0, 0);
            this.panelSongInfo.Margin = new System.Windows.Forms.Padding(0);
            this.panelSongInfo.Name = "panelSongInfo";
            this.panelSongInfo.Size = new System.Drawing.Size(244, 86);
            this.panelSongInfo.TabIndex = 0;
            this.panelSongInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSongInfo_Paint);
            // 
            // lbSongArtist
            // 
            this.lbSongArtist.AutoSize = true;
            this.lbSongArtist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongArtist.ForeColor = System.Drawing.Color.White;
            this.lbSongArtist.Location = new System.Drawing.Point(123, 64);
            this.lbSongArtist.Name = "lbSongArtist";
            this.lbSongArtist.Size = new System.Drawing.Size(0, 19);
            this.lbSongArtist.TabIndex = 2;
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(123, 29);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(0, 21);
            this.lbSongName.TabIndex = 1;
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
            // panel12
            // 
            this.panel12.Controls.Add(this.button8);
            this.panel12.Controls.Add(this.trackbarVolume);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(757, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(201, 80);
            this.panel12.TabIndex = 2;
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
            this.trackbarVolume.Location = new System.Drawing.Point(56, 29);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = global::MusicPlayer.Properties.Resources.icons8_settings_24px;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 439);
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
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::MusicPlayer.Properties.Resources.icons8_playlist_24px;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 326);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(212, 53);
            this.button6.TabIndex = 9;
            this.button6.Text = "          Playlist";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::MusicPlayer.Properties.Resources.icons8_monitor_24px;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 273);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(212, 53);
            this.button5.TabIndex = 8;
            this.button5.Text = "          Local";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::MusicPlayer.Properties.Resources.icons8_bar_chart_24px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 219);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(212, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "          BXH";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::MusicPlayer.Properties.Resources.icons8_list_24px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(212, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "          Thể loại";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::MusicPlayer.Properties.Resources.icons8_search_24px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 113);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(212, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "          Tìm kiếm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MusicPlayer.Properties.Resources.icons8_home_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(212, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "          Trang chủ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnMin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnMin.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_minus_16px;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMin.BorderRadius = 0;
            this.btnMin.BorderSize = 0;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(799, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(54, 22);
            this.btnMin.TabIndex = 2;
            this.btnMin.TextColor = System.Drawing.Color.White;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnMax.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnMax.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_rectangular_16px_1;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMax.BorderRadius = 0;
            this.btnMax.BorderSize = 0;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(853, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(54, 22);
            this.btnMax.TabIndex = 1;
            this.btnMax.TextColor = System.Drawing.Color.White;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.btnExit.BackgroundImage = global::MusicPlayer.Properties.Resources.icons8_delete_16px;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 0;
            this.btnExit.BorderSize = 0;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(907, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 22);
            this.btnExit.TabIndex = 0;
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbSong
            // 
            this.pbSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbSong.Location = new System.Drawing.Point(0, 0);
            this.pbSong.Name = "pbSong";
            this.pbSong.Size = new System.Drawing.Size(117, 86);
            this.pbSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSong.TabIndex = 0;
            this.pbSong.TabStop = false;
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
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(55, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(961, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mPlayer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tlpMedia.ResumeLayout(false);
            this.panelSongInfo.ResumeLayout(false);
            this.panelSongInfo.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panel3;
        private RJCodeAdvance.RJControls.RJButton btnExit;
        private RJCodeAdvance.RJControls.RJButton btnMin;
        private RJCodeAdvance.RJControls.RJButton btnMax;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMedia;
        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel6;
        private AxWMPLib.AxWindowsMediaPlayer mPlayer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelLyric;
        private System.Windows.Forms.TableLayoutPanel tlpMedia;
        private System.Windows.Forms.Panel panelSongInfo;
        private System.Windows.Forms.Label lbSongArtist;
        private System.Windows.Forms.Label lbSongName;
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
        private System.Windows.Forms.Button button8;
    }
}
