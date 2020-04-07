namespace SYSTEMDEMO
{
    partial class ChatApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatApplication));
            this.IPTEXT = new System.Windows.Forms.Label();
            this.PORTEXT = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IPTEXT
            // 
            this.IPTEXT.AutoSize = true;
            this.IPTEXT.BackColor = System.Drawing.Color.Transparent;
            this.IPTEXT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTEXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPTEXT.Location = new System.Drawing.Point(305, 42);
            this.IPTEXT.Name = "IPTEXT";
            this.IPTEXT.Size = new System.Drawing.Size(86, 47);
            this.IPTEXT.TabIndex = 0;
            this.IPTEXT.Text = "IP : ";
            // 
            // PORTEXT
            // 
            this.PORTEXT.AutoSize = true;
            this.PORTEXT.BackColor = System.Drawing.Color.Transparent;
            this.PORTEXT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F);
            this.PORTEXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PORTEXT.Location = new System.Drawing.Point(237, 115);
            this.PORTEXT.Name = "PORTEXT";
            this.PORTEXT.Size = new System.Drawing.Size(139, 47);
            this.PORTEXT.TabIndex = 0;
            this.PORTEXT.Text = "PORT :";
            // 
            // IP
            // 
            this.IP.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IP.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IP.ForeColor = System.Drawing.SystemColors.Window;
            this.IP.Location = new System.Drawing.Point(421, 42);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(389, 55);
            this.IP.TabIndex = 1;
            this.IP.Text = "mashirotan.ddns.net";
            // 
            // PORT
            // 
            this.PORT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PORT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PORT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PORT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PORT.ForeColor = System.Drawing.SystemColors.Window;
            this.PORT.Location = new System.Drawing.Point(421, 115);
            this.PORT.Name = "PORT";
            this.PORT.Size = new System.Drawing.Size(105, 55);
            this.PORT.TabIndex = 1;
            this.PORT.Text = "1443";
            // 
            // ChatApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.PORTEXT);
            this.Controls.Add(this.IPTEXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChatApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT ZONE [SERVER]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPTEXT;
        private System.Windows.Forms.Label PORTEXT;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox PORT;
    }
}