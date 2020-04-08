namespace SYSTEMDEMO
{
    partial class CHAT_APPLICATION_CLIENT_DEMO
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
            this.IPDEMO = new System.Windows.Forms.TextBox();
            this.PORTDEMO = new System.Windows.Forms.TextBox();
            this.ConnectBotton = new System.Windows.Forms.Button();
            this.SendTextDemo = new System.Windows.Forms.TextBox();
            this.SendBottonDemo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // TxtMessageDemo
            // 
            this.TxtMessageDemo.Location = new System.Drawing.Point(5, 73);
            this.TxtMessageDemo.Multiline = true;
            this.TxtMessageDemo.Name = "TxtMessageDemo";
            this.TxtMessageDemo.Size = new System.Drawing.Size(1122, 480);
            this.TxtMessageDemo.TabIndex = 0;
            // 
            // IPDEMO
            // 
            this.IPDEMO.Location = new System.Drawing.Point(9, 17);
            this.IPDEMO.Name = "IPDEMO";
            this.IPDEMO.Size = new System.Drawing.Size(61, 22);
            this.IPDEMO.TabIndex = 1;
            this.IPDEMO.Text = "127.0.0.1";
            // 
            // PORTDEMO
            // 
            this.PORTDEMO.Location = new System.Drawing.Point(9, 45);
            this.PORTDEMO.Name = "PORTDEMO";
            this.PORTDEMO.Size = new System.Drawing.Size(48, 22);
            this.PORTDEMO.TabIndex = 2;
            this.PORTDEMO.Text = "1443";
            // 
            // ConnectBotton
            // 
            this.ConnectBotton.Location = new System.Drawing.Point(983, 25);
            this.ConnectBotton.Name = "ConnectBotton";
            this.ConnectBotton.Size = new System.Drawing.Size(121, 41);
            this.ConnectBotton.TabIndex = 3;
            this.ConnectBotton.Text = "Connect";
            this.ConnectBotton.UseVisualStyleBackColor = true;
            this.ConnectBotton.Click += new System.EventHandler(this.ConnectBotton_Click);
            // 
            // SendTextDemo
            // 
            this.SendTextDemo.Location = new System.Drawing.Point(4, 561);
            this.SendTextDemo.Multiline = true;
            this.SendTextDemo.Name = "SendTextDemo";
            this.SendTextDemo.Size = new System.Drawing.Size(941, 49);
            this.SendTextDemo.TabIndex = 4;
            // 
            // SendBottonDemo
            // 
            this.SendBottonDemo.Location = new System.Drawing.Point(957, 568);
            this.SendBottonDemo.Name = "SendBottonDemo";
            this.SendBottonDemo.Size = new System.Drawing.Size(169, 41);
            this.SendBottonDemo.TabIndex = 5;
            this.SendBottonDemo.Text = "SEND";
            this.SendBottonDemo.UseVisualStyleBackColor = true;
            this.SendBottonDemo.Click += new System.EventHandler(this.SendBottonDemo_Click);
            // 
            // CHAT_APPLICATION_CLIENT_DEMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1139, 622);
            this.Controls.Add(this.SendBottonDemo);
            this.Controls.Add(this.SendTextDemo);
            this.Controls.Add(this.ConnectBotton);
            this.Controls.Add(this.PORTDEMO);
            this.Controls.Add(this.IPDEMO);
            this.Controls.Add(this.TxtMessageDemo);
            this.Name = "CHAT_APPLICATION_CLIENT_DEMO";
            this.Text = "CHAT APPLICATION CLIENT DEMO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMessageDemo;
        private System.Windows.Forms.TextBox IPDEMO;
        private System.Windows.Forms.TextBox PORTDEMO;
        private System.Windows.Forms.Button ConnectBotton;
        private System.Windows.Forms.TextBox SendTextDemo;
        private System.Windows.Forms.Button SendBottonDemo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}