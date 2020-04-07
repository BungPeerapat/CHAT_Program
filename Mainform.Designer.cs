namespace SYSTEMDEMO
{
    partial class MainServer
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
            this.SB = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(503, 147);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(263, 60);
            this.SB.TabIndex = 0;
            this.SB.Text = "Server";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // CB
            // 
            this.CB.Location = new System.Drawing.Point(503, 298);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(263, 60);
            this.CB.TabIndex = 0;
            this.CB.Text = "Client";
            this.CB.UseVisualStyleBackColor = true;
            // 
            // MainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1396, 530);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.SB);
            this.Name = "MainServer";
            this.Text = "RATDEMO MADE BY MASHIRO [ ADMIN ]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.Button CB;
    }
}

