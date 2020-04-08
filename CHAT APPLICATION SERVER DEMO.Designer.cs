namespace SYSTEMDEMO
{
    partial class CHAT_APPLICATION_SERVER_DEMO
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
            this.TxtMessageDemo = new System.Windows.Forms.TextBox();
            this.SendTextDemo = new System.Windows.Forms.TextBox();
            this.SendTextBotton = new System.Windows.Forms.Button();
            this.IPSERVER = new System.Windows.Forms.TextBox();
            this.PORTSERVER = new System.Windows.Forms.TextBox();
            this.CreateServerBotton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TxtMessageDemo
            // 
            this.TxtMessageDemo.Font = new System.Drawing.Font("Franxurter Totally Medium", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessageDemo.Location = new System.Drawing.Point(12, 67);
            this.TxtMessageDemo.Multiline = true;
            this.TxtMessageDemo.Name = "TxtMessageDemo";
            this.TxtMessageDemo.Size = new System.Drawing.Size(947, 419);
            this.TxtMessageDemo.TabIndex = 0;
            // 
            // SendTextDemo
            // 
            this.SendTextDemo.Font = new System.Drawing.Font("Franxurter Totally Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextDemo.Location = new System.Drawing.Point(12, 492);
            this.SendTextDemo.Multiline = true;
            this.SendTextDemo.Name = "SendTextDemo";
            this.SendTextDemo.Size = new System.Drawing.Size(798, 40);
            this.SendTextDemo.TabIndex = 1;
            // 
            // SendTextBotton
            // 
            this.SendTextBotton.Font = new System.Drawing.Font("Franxurter Totally Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendTextBotton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SendTextBotton.Location = new System.Drawing.Point(830, 495);
            this.SendTextBotton.Name = "SendTextBotton";
            this.SendTextBotton.Size = new System.Drawing.Size(128, 36);
            this.SendTextBotton.TabIndex = 2;
            this.SendTextBotton.Text = "SEND";
            this.SendTextBotton.UseVisualStyleBackColor = true;
            this.SendTextBotton.Click += new System.EventHandler(this.SendTextBotton_Click);
            // 
            // IPSERVER
            // 
            this.IPSERVER.Location = new System.Drawing.Point(12, 11);
            this.IPSERVER.Name = "IPSERVER";
            this.IPSERVER.Size = new System.Drawing.Size(99, 22);
            this.IPSERVER.TabIndex = 3;
            this.IPSERVER.Text = "127.0.0.1";
            // 
            // PORTSERVER
            // 
            this.PORTSERVER.Location = new System.Drawing.Point(12, 39);
            this.PORTSERVER.Name = "PORTSERVER";
            this.PORTSERVER.Size = new System.Drawing.Size(60, 22);
            this.PORTSERVER.TabIndex = 4;
            this.PORTSERVER.Text = "1443";
            // 
            // CreateServerBotton
            // 
            this.CreateServerBotton.Font = new System.Drawing.Font("Franxurter Totally Medium", 16.2F);
            this.CreateServerBotton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateServerBotton.Location = new System.Drawing.Point(830, 12);
            this.CreateServerBotton.Name = "CreateServerBotton";
            this.CreateServerBotton.Size = new System.Drawing.Size(128, 49);
            this.CreateServerBotton.TabIndex = 5;
            this.CreateServerBotton.Text = "Create";
            this.CreateServerBotton.UseVisualStyleBackColor = true;
            this.CreateServerBotton.Click += new System.EventHandler(this.CreateServerBotton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // CHAT_APPLICATION_SERVER_DEMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(971, 543);
            this.Controls.Add(this.CreateServerBotton);
            this.Controls.Add(this.PORTSERVER);
            this.Controls.Add(this.IPSERVER);
            this.Controls.Add(this.SendTextBotton);
            this.Controls.Add(this.SendTextDemo);
            this.Controls.Add(this.TxtMessageDemo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "CHAT_APPLICATION_SERVER_DEMO";
            this.Text = "CHAT APPLICATION SERVER DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMessageDemo;
        private System.Windows.Forms.TextBox SendTextDemo;
        private System.Windows.Forms.Button SendTextBotton;
        private System.Windows.Forms.TextBox IPSERVER;
        private System.Windows.Forms.TextBox PORTSERVER;
        private System.Windows.Forms.Button CreateServerBotton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}