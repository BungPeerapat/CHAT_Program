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
            this.ClientDemobotton = new System.Windows.Forms.Button();
            this.ServerDemobotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(340, 139);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(263, 60);
            this.SB.TabIndex = 0;
            this.SB.Text = "Server";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // CB
            // 
            this.CB.Location = new System.Drawing.Point(340, 321);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(263, 60);
            this.CB.TabIndex = 0;
            this.CB.Text = "Client";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // ClientDemobotton
            // 
            this.ClientDemobotton.Location = new System.Drawing.Point(250, 402);
            this.ClientDemobotton.Name = "ClientDemobotton";
            this.ClientDemobotton.Size = new System.Drawing.Size(454, 99);
            this.ClientDemobotton.TabIndex = 1;
            this.ClientDemobotton.Text = "ClientDemo";
            this.ClientDemobotton.UseVisualStyleBackColor = true;
            this.ClientDemobotton.Click += new System.EventHandler(this.ClientDemobotton_Click);
            // 
            // ServerDemobotton
            // 
            this.ServerDemobotton.Location = new System.Drawing.Point(250, 12);
            this.ServerDemobotton.Name = "ServerDemobotton";
            this.ServerDemobotton.Size = new System.Drawing.Size(454, 99);
            this.ServerDemobotton.TabIndex = 2;
            this.ServerDemobotton.Text = "ServerDemo";
            this.ServerDemobotton.UseVisualStyleBackColor = true;
            this.ServerDemobotton.Click += new System.EventHandler(this.ServerDemobotton_Click);
            // 
            // MainServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(967, 539);
            this.Controls.Add(this.ServerDemobotton);
            this.Controls.Add(this.ClientDemobotton);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.SB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainServer";
            this.Text = "RATDEMO MADE BY MASHIRO [ ADMIN ]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.Button CB;
        private System.Windows.Forms.Button ClientDemobotton;
        private System.Windows.Forms.Button ServerDemobotton;
    }
}

