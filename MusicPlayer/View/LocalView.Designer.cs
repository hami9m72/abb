
namespace MusicPlayer.View
{
    partial class LocalView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.poisonScrollBar1 = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 53);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // poisonScrollBar1
            // 
            this.poisonScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.poisonScrollBar1.LargeChange = 10;
            this.poisonScrollBar1.Location = new System.Drawing.Point(741, 53);
            this.poisonScrollBar1.Maximum = 100;
            this.poisonScrollBar1.Minimum = 0;
            this.poisonScrollBar1.MouseWheelBarPartitions = 10;
            this.poisonScrollBar1.Name = "poisonScrollBar1";
            this.poisonScrollBar1.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.poisonScrollBar1.ScrollbarSize = 8;
            this.poisonScrollBar1.Size = new System.Drawing.Size(8, 439);
            this.poisonScrollBar1.TabIndex = 1;
            this.poisonScrollBar1.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 439);
            this.panel2.TabIndex = 3;
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.AutoScroll = true;
            this.poisonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.poisonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonPanel1.HorizontalScrollbar = true;
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(36, 53);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(705, 439);
            this.poisonPanel1.TabIndex = 4;
            this.poisonPanel1.UseCustomBackColor = true;
            this.poisonPanel1.VerticalScrollbar = true;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // LocalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.poisonPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.poisonScrollBar1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LocalView";
            this.Size = new System.Drawing.Size(749, 492);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.PoisonScrollBar poisonScrollBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
    }
}
