
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            this.poisonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(731, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(18, 492);
            this.panel7.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 492);
            this.panel3.TabIndex = 5;
            // 
            // poisonPanel1
            // 
            this.poisonPanel1.AutoScroll = true;
            this.poisonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.poisonPanel1.Controls.Add(this.panel3);
            this.poisonPanel1.Controls.Add(this.panel7);
            this.poisonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poisonPanel1.HorizontalScrollbar = true;
            this.poisonPanel1.HorizontalScrollbarBarColor = true;
            this.poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.HorizontalScrollbarSize = 10;
            this.poisonPanel1.Location = new System.Drawing.Point(0, 0);
            this.poisonPanel1.Name = "poisonPanel1";
            this.poisonPanel1.Size = new System.Drawing.Size(749, 492);
            this.poisonPanel1.TabIndex = 3;
            this.poisonPanel1.UseCustomBackColor = true;
            this.poisonPanel1.VerticalScrollbar = true;
            this.poisonPanel1.VerticalScrollbarBarColor = true;
            this.poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.poisonPanel1);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(749, 492);
            this.poisonPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
    }
}
