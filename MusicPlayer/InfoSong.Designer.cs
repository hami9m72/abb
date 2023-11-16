namespace MusicPlayer
{
    partial class InfoSong
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(44, 30);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "lbName";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbArtist.Location = new System.Drawing.Point(46, 83);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(47, 16);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.Text = "lbArtist";
            this.lbArtist.Click += new System.EventHandler(this.lbArtist_Click);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCountry.Location = new System.Drawing.Point(46, 110);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(63, 16);
            this.lbCountry.TabIndex = 2;
            this.lbCountry.Text = "lbCountry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(44, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bình luận";
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDown.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(49, 149);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(109, 34);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Download";
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(49, 250);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(525, 22);
            this.txbComment.TabIndex = 6;
            // 
            // InfoSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbName);
            this.Name = "InfoSong";
            this.Size = new System.Drawing.Size(607, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.TextBox txbComment;
    }
}
