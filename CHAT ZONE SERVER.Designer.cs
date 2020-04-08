namespace SYSTEMDEMO
{
    partial class ChatApplicationServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatApplicationServer));
            this.IPTEXT = new System.Windows.Forms.Label();
            this.PORTEXT = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.PORT = new System.Windows.Forms.TextBox();
            this.btnstartserver = new System.Windows.Forms.Button();
            this.TxtShowMaessenge = new System.Windows.Forms.TextBox();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // IPTEXT
            // 
            this.IPTEXT.AutoSize = true;
            this.IPTEXT.BackColor = System.Drawing.Color.Transparent;
            this.IPTEXT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTEXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPTEXT.Location = new System.Drawing.Point(143, 42);
            this.IPTEXT.Name = "IPTEXT";
            this.IPTEXT.Size = new System.Drawing.Size(233, 47);
            this.IPTEXT.TabIndex = 0;
            this.IPTEXT.Text = "IP ADDESS :";
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
            this.IP.Size = new System.Drawing.Size(232, 55);
            this.IP.TabIndex = 1;
            this.IP.Text = "127.0.0.1";
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
            // btnstartserver
            // 
            this.btnstartserver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstartserver.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnstartserver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnstartserver.Location = new System.Drawing.Point(693, 42);
            this.btnstartserver.Name = "btnstartserver";
            this.btnstartserver.Size = new System.Drawing.Size(278, 112);
            this.btnstartserver.TabIndex = 2;
            this.btnstartserver.Text = "Start";
            this.btnstartserver.UseVisualStyleBackColor = false;
            this.btnstartserver.Click += new System.EventHandler(this.btnstartserver_Click);
            // 
            // TxtShowMaessenge
            // 
            this.TxtShowMaessenge.BackColor = System.Drawing.Color.Black;
            this.TxtShowMaessenge.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F);
            this.TxtShowMaessenge.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtShowMaessenge.Location = new System.Drawing.Point(35, 176);
            this.TxtShowMaessenge.Multiline = true;
            this.TxtShowMaessenge.Name = "TxtShowMaessenge";
            this.TxtShowMaessenge.Size = new System.Drawing.Size(953, 324);
            this.TxtShowMaessenge.TabIndex = 3;
            this.TxtShowMaessenge.TextChanged += new System.EventHandler(this.TxtShowMessenge_TextChanged);
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(35, 506);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(803, 36);
            this.txtsend.TabIndex = 4;
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("Franxurter Totally Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Location = new System.Drawing.Point(860, 506);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(127, 35);
            this.sendbutton.TabIndex = 5;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ChatApplicationServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.TxtShowMaessenge);
            this.Controls.Add(this.btnstartserver);
            this.Controls.Add(this.PORT);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.PORTEXT);
            this.Controls.Add(this.IPTEXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChatApplicationServer";
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
        private System.Windows.Forms.Button btnstartserver;
        private System.Windows.Forms.TextBox TxtShowMaessenge;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Button sendbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}