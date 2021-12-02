
namespace MusicPlayer.View
{
    partial class karaoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(karaoke));
            this.kPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.kPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // kPlayer
            // 
            this.kPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kPlayer.Enabled = true;
            this.kPlayer.Location = new System.Drawing.Point(0, 0);
            this.kPlayer.Name = "kPlayer";
            this.kPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("kPlayer.OcxState")));
            this.kPlayer.Size = new System.Drawing.Size(766, 527);
            this.kPlayer.TabIndex = 0;
            // 
            // karaoke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 527);
            this.Controls.Add(this.kPlayer);
            this.Name = "karaoke";
            this.Text = "karaoke";
            ((System.ComponentModel.ISupportInitialize)(this.kPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer kPlayer;
    }
}