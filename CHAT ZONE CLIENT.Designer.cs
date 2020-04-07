namespace SYSTEMDEMO
{
    partial class ChatClientSize
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
            this.btnstartserver = new System.Windows.Forms.Button();
            this.PORTCLIENT = new System.Windows.Forms.TextBox();
            this.IPCLIENT = new System.Windows.Forms.TextBox();
            this.PORTEXT = new System.Windows.Forms.Label();
            this.IPTEXT = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.sendbutton = new System.Windows.Forms.Button();
            this.txtsend = new System.Windows.Forms.TextBox();
            this.TxtShowMessenge = new System.Windows.Forms.TextBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnstartserver
            // 
            this.btnstartserver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstartserver.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnstartserver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnstartserver.Location = new System.Drawing.Point(689, 27);
            this.btnstartserver.Name = "btnstartserver";
            this.btnstartserver.Size = new System.Drawing.Size(278, 112);
            this.btnstartserver.TabIndex = 10;
            this.btnstartserver.Text = "Connect";
            this.btnstartserver.UseVisualStyleBackColor = false;
            this.btnstartserver.Click += new System.EventHandler(this.btnstartserver_Click);
            // 
            // PORTCLIENT
            // 
            this.PORTCLIENT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PORTCLIENT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PORTCLIENT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PORTCLIENT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.PORTCLIENT.ForeColor = System.Drawing.SystemColors.Window;
            this.PORTCLIENT.Location = new System.Drawing.Point(283, 100);
            this.PORTCLIENT.Name = "PORTCLIENT";
            this.PORTCLIENT.Size = new System.Drawing.Size(105, 55);
            this.PORTCLIENT.TabIndex = 8;
            this.PORTCLIENT.Text = "1443";
            // 
            // IPCLIENT
            // 
            this.IPCLIENT.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.IPCLIENT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPCLIENT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IPCLIENT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IPCLIENT.ForeColor = System.Drawing.SystemColors.Window;
            this.IPCLIENT.Location = new System.Drawing.Point(283, 27);
            this.IPCLIENT.Name = "IPCLIENT";
            this.IPCLIENT.Size = new System.Drawing.Size(400, 55);
            this.IPCLIENT.TabIndex = 9;
            this.IPCLIENT.Text = "mashirotan.ddns.net";
            // 
            // PORTEXT
            // 
            this.PORTEXT.AutoSize = true;
            this.PORTEXT.BackColor = System.Drawing.Color.Transparent;
            this.PORTEXT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F);
            this.PORTEXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PORTEXT.Location = new System.Drawing.Point(129, 100);
            this.PORTEXT.Name = "PORTEXT";
            this.PORTEXT.Size = new System.Drawing.Size(139, 47);
            this.PORTEXT.TabIndex = 6;
            this.PORTEXT.Text = "PORT :";
            // 
            // IPTEXT
            // 
            this.IPTEXT.AutoSize = true;
            this.IPTEXT.BackColor = System.Drawing.Color.Transparent;
            this.IPTEXT.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTEXT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPTEXT.Location = new System.Drawing.Point(35, 27);
            this.IPTEXT.Name = "IPTEXT";
            this.IPTEXT.Size = new System.Drawing.Size(233, 47);
            this.IPTEXT.TabIndex = 7;
            this.IPTEXT.Text = "IP ADDESS :";
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("Franxurter Totally Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Location = new System.Drawing.Point(855, 491);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(127, 35);
            this.sendbutton.TabIndex = 13;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(30, 491);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(803, 36);
            this.txtsend.TabIndex = 12;
            // 
            // TxtShowMessenge
            // 
            this.TxtShowMessenge.BackColor = System.Drawing.Color.Black;
            this.TxtShowMessenge.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F);
            this.TxtShowMessenge.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtShowMessenge.Location = new System.Drawing.Point(30, 161);
            this.TxtShowMessenge.Multiline = true;
            this.TxtShowMessenge.Name = "TxtShowMessenge";
            this.TxtShowMessenge.Size = new System.Drawing.Size(953, 324);
            this.TxtShowMessenge.TabIndex = 11;
            // 
            // ChatClientSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.TxtShowMessenge);
            this.Controls.Add(this.btnstartserver);
            this.Controls.Add(this.PORTCLIENT);
            this.Controls.Add(this.IPCLIENT);
            this.Controls.Add(this.PORTEXT);
            this.Controls.Add(this.IPTEXT);
            this.Name = "ChatClientSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT ZONE CLIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnstartserver;
        private System.Windows.Forms.TextBox PORTCLIENT;
        private System.Windows.Forms.TextBox IPCLIENT;
        private System.Windows.Forms.Label PORTEXT;
        private System.Windows.Forms.Label IPTEXT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.TextBox TxtShowMessenge;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}