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
            this.SuspendLayout();
            // 
            // TxtMessageDemo
            // 
            this.TxtMessageDemo.Location = new System.Drawing.Point(5, 104);
            this.TxtMessageDemo.Multiline = true;
            this.TxtMessageDemo.Name = "TxtMessageDemo";
            this.TxtMessageDemo.Size = new System.Drawing.Size(1137, 519);
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
            // CHAT_APPLICATION_CLIENT_DEMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 622);
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
    }
}