namespace SYSTEMDEMO
{
    partial class ChatApplicationClientSize
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
            this.Connect = new System.Windows.Forms.Button();
            this.portclient = new System.Windows.Forms.TextBox();
            this.ipclient = new System.Windows.Forms.TextBox();
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
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Connect.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Connect.Location = new System.Drawing.Point(716, 27);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(251, 112);
            this.Connect.TabIndex = 10;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.btnstartserver_Click);
            // 
            // portclient
            // 
            this.portclient.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.portclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portclient.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.portclient.ForeColor = System.Drawing.SystemColors.Window;
            this.portclient.Location = new System.Drawing.Point(283, 100);
            this.portclient.Name = "portclient";
            this.portclient.Size = new System.Drawing.Size(105, 55);
            this.portclient.TabIndex = 8;
            this.portclient.Text = "1443";
            // 
            // ipclient
            // 
            this.ipclient.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ipclient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipclient.Font = new System.Drawing.Font("Franxurter Totally Medium", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ipclient.ForeColor = System.Drawing.SystemColors.Window;
            this.ipclient.Location = new System.Drawing.Point(283, 27);
            this.ipclient.Name = "ipclient";
            this.ipclient.Size = new System.Drawing.Size(400, 55);
            this.ipclient.TabIndex = 9;
            this.ipclient.Text = "127.0.0.1";
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
            // ChatApplicationClientSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.txtsend);
            this.Controls.Add(this.TxtShowMessenge);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.portclient);
            this.Controls.Add(this.ipclient);
            this.Controls.Add(this.PORTEXT);
            this.Controls.Add(this.IPTEXT);
            this.Name = "ChatApplicationClientSize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT ZONE CLIENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox portclient;
        private System.Windows.Forms.TextBox ipclient;
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