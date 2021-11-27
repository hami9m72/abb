
namespace MusicPlayer.View
{
    partial class HomeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpBanner = new System.Windows.Forms.TableLayoutPanel();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.poisonScrollBar1 = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.poisonPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlpBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.AutoScroll = true;
            this.poisonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.poisonPanel1.Controls.Add(this.panel1);
            this.poisonPanel1.Controls.Add(this.tlpBanner);
            this.poisonPanel1.Controls.Add(this.panel3);
            this.poisonPanel1.Controls.Add(this.panel7);
            this.poisonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonPanel1.HorizontalScrollbar = true;
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(0, 0);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(743, 492);
            this.poisonPanel1.TabIndex = 3;
            this.poisonPanel1.UseCustomBackColor = true;
            this.poisonPanel1.VerticalScrollbar = true;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(18, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Có thể bạn muốn nghe";
            // 
            // tlpBanner
            // 
            this.tlpBanner.ColumnCount = 3;
            this.tlpBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBanner.Controls.Add(this.pb3, 2, 0);
            this.tlpBanner.Controls.Add(this.pb2, 1, 0);
            this.tlpBanner.Controls.Add(this.pb1, 0, 0);
            this.tlpBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBanner.Location = new System.Drawing.Point(18, 0);
            this.tlpBanner.Name = "tlpBanner";
            this.tlpBanner.RowCount = 1;
            this.tlpBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpBanner.Size = new System.Drawing.Size(707, 150);
            this.tlpBanner.TabIndex = 2;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Yellow;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb3.Location = new System.Drawing.Point(479, 3);
            this.pb3.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(225, 144);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 0;
            this.pb3.TabStop = false;
            this.pb3.Tag = "2";
            this.pb3.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Yellow;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb2.Location = new System.Drawing.Point(244, 3);
            this.pb2.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(217, 144);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Tag = "1";
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Yellow;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb1.Location = new System.Drawing.Point(3, 3);
            this.pb1.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(223, 144);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            this.pb1.Tag = "0";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 492);
            this.panel3.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(725, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(18, 492);
            this.panel7.TabIndex = 6;
            // 
            // poisonScrollBar1
            // 
            this.poisonScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.poisonScrollBar1.LargeChange = 10;
            this.poisonScrollBar1.Location = new System.Drawing.Point(743, 0);
            this.poisonScrollBar1.Maximum = 100;
            this.poisonScrollBar1.Minimum = 0;
            this.poisonScrollBar1.MouseWheelBarPartitions = 10;
            this.poisonScrollBar1.Name = "poisonScrollBar1";
            this.poisonScrollBar1.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.poisonScrollBar1.ScrollbarSize = 6;
            this.poisonScrollBar1.Size = new System.Drawing.Size(6, 492);
            this.poisonScrollBar1.TabIndex = 2;
            this.poisonScrollBar1.UseSelectable = true;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonPanel1);
            this.Controls.Add(this.poisonScrollBar1);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(749, 492);
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.poisonPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpBanner;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private ReaLTaiizor.Controls.PoisonScrollBar poisonScrollBar1;
    }
}
