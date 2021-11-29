
namespace MusicPlayer.View
{
    partial class MediaListSmall
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
            this.lbDuration = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.pbThumb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.lbDuration);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.lbArtist);
            this.panel1.Controls.Add(this.pbThumb);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 50);
            this.panel1.TabIndex = 0;
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.ForeColor = System.Drawing.Color.White;
            this.lbDuration.Location = new System.Drawing.Point(227, 29);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(43, 17);
            this.lbDuration.TabIndex = 8;
            this.lbDuration.Text = "label3";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(55, 4);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(52, 21);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "label1";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.ForeColor = System.Drawing.Color.White;
            this.lbArtist.Location = new System.Drawing.Point(56, 29);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(43, 17);
            this.lbArtist.TabIndex = 6;
            this.lbArtist.Text = "label2";
            // 
            // pbThumb
            // 
            this.pbThumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbThumb.Location = new System.Drawing.Point(0, 0);
            this.pbThumb.Name = "pbThumb";
            this.pbThumb.Size = new System.Drawing.Size(50, 50);
            this.pbThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbThumb.TabIndex = 5;
            this.pbThumb.TabStop = false;
            // 
            // MediaListSmall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel1);
            this.Name = "MediaListSmall";
            this.Size = new System.Drawing.Size(279, 57);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.PictureBox pbThumb;
    }
}
