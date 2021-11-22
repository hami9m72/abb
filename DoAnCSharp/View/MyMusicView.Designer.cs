﻿
namespace DoAnCSharp.View
{
    partial class MyMusicView
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
            this.hopeTabPage1 = new ReaLTaiizor.Controls.HopeTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.poisonScrollBar1 = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hopeTabPage1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.hopeTabPage1.SelectedIndex = 0;
            this.hopeTabPage1.Size = new System.Drawing.Size(832, 499);
            this.hopeTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hopeTabPage1.TabIndex = 0;
            this.hopeTabPage1.ThemeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.ThemeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTabPage1.TitleTextState = ReaLTaiizor.Controls.HopeTabPage.TextState.Normal;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.tabPage1.Controls.Add(this.poisonScrollBar1);
            this.tabPage1.Controls.Add(this.poisonPanel1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // poisonScrollBar1
            // 
            this.poisonScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.poisonScrollBar1.LargeChange = 10;
            this.poisonScrollBar1.Location = new System.Drawing.Point(823, 51);
            this.poisonScrollBar1.Maximum = 100;
            this.poisonScrollBar1.Minimum = 0;
            this.poisonScrollBar1.MouseWheelBarPartitions = 10;
            this.poisonScrollBar1.Name = "poisonScrollBar1";
            this.poisonScrollBar1.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.poisonScrollBar1.ScrollbarSize = 6;
            this.poisonScrollBar1.Size = new System.Drawing.Size(6, 405);
            this.poisonScrollBar1.TabIndex = 2;
            this.poisonScrollBar1.UseSelectable = true;
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.AutoScroll = true;
            this.poisonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonPanel1.HorizontalScrollbar = true;
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(3, 51);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(826, 405);
            this.poisonPanel1.TabIndex = 1;
            this.poisonPanel1.UseCustomBackColor = true;
            this.poisonPanel1.VerticalScrollbar = true;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            this.poisonPanel1.VerticalScrolled += new System.EventHandler<System.Windows.Forms.ScrollEventArgs>(this.poisonPanel1_VerticalScrolled);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 48);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MyMusicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hopeTabPage1);
            this.Name = "MyMusicView";
            this.Size = new System.Drawing.Size(832, 499);
            this.hopeTabPage1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTabPage hopeTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.PoisonScrollBar poisonScrollBar1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
    }
}
