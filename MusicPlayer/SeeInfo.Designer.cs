namespace MusicPlayer
{
    partial class SeeInfo
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
            this.txbComment = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbComment
            // 
            this.txbComment.Location = new System.Drawing.Point(26, 258);
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(525, 22);
            this.txbComment.TabIndex = 12;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDown.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(26, 157);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(109, 34);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "Download";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(21, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bình luận";
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCountry.Location = new System.Drawing.Point(23, 118);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(63, 16);
            this.lbCountry.TabIndex = 9;
            this.lbCountry.Text = "lbCountry";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbArtist.Location = new System.Drawing.Point(23, 91);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(47, 16);
            this.lbArtist.TabIndex = 8;
            this.lbArtist.Text = "lbArtist";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(21, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 29);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "lbName";
            // 
            // SeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbComment);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbName);
            this.Name = "SeeInfo";
            this.Text = "SeeInfo";
            this.Load += new System.EventHandler(this.SeeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbComment;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbName;

    }
}