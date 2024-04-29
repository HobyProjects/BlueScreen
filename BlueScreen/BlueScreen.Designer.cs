namespace BlueScreen
{
    partial class BlueScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblMessage1 = new System.Windows.Forms.Label();
            this.pbCrashImage_01 = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblMessage2 = new System.Windows.Forms.Label();
            this.pbCrashImage_02 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrashImage_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrashImage_02)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage1
            // 
            this.lblMessage1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMessage1.AutoSize = true;
            this.lblMessage1.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage1.ForeColor = System.Drawing.Color.White;
            this.lblMessage1.Location = new System.Drawing.Point(133, 247);
            this.lblMessage1.Name = "lblMessage1";
            this.lblMessage1.Size = new System.Drawing.Size(787, 135);
            this.lblMessage1.TabIndex = 0;
            this.lblMessage1.Text = "Your PC ran in to a problem and needs to restart. We\'re \r\njust collecting some er" +
    "ror info, and then we\'ll restart for\r\nyou.\r\n";
            // 
            // pbCrashImage_01
            // 
            this.pbCrashImage_01.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCrashImage_01.Image = global::BlueScreen.Properties.Resources.Crash_Image_1;
            this.pbCrashImage_01.Location = new System.Drawing.Point(101, 93);
            this.pbCrashImage_01.Name = "pbCrashImage_01";
            this.pbCrashImage_01.Size = new System.Drawing.Size(155, 151);
            this.pbCrashImage_01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrashImage_01.TabIndex = 1;
            this.pbCrashImage_01.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.White;
            this.lblProgress.Location = new System.Drawing.Point(133, 407);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(215, 45);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "20% complete";
            // 
            // lblMessage2
            // 
            this.lblMessage2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.White;
            this.lblMessage2.Location = new System.Drawing.Point(246, 482);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(690, 84);
            this.lblMessage2.TabIndex = 0;
            this.lblMessage2.Text = "For more information about this issue and possible fixes, visit https://www.windo" +
    "ws.com/stopcode\r\n\r\nif you call a support person, give them this info:\r\nStop code" +
    ": CRITICAL_PROCESS_DIED";
            // 
            // pbCrashImage_02
            // 
            this.pbCrashImage_02.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbCrashImage_02.Image = global::BlueScreen.Properties.Resources.Crash_Image_2;
            this.pbCrashImage_02.Location = new System.Drawing.Point(132, 464);
            this.pbCrashImage_02.Name = "pbCrashImage_02";
            this.pbCrashImage_02.Size = new System.Drawing.Size(124, 133);
            this.pbCrashImage_02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCrashImage_02.TabIndex = 1;
            this.pbCrashImage_02.TabStop = false;
            this.pbCrashImage_02.Click += new System.EventHandler(this.pbCrashImage_02_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BlueScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(1113, 765);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.pbCrashImage_02);
            this.Controls.Add(this.pbCrashImage_01);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblMessage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BlueScreen";
            this.Text = "BlueScreen";
            this.Load += new System.EventHandler(this.BlueScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrashImage_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrashImage_02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage1;
        private System.Windows.Forms.PictureBox pbCrashImage_01;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblMessage2;
        private System.Windows.Forms.PictureBox pbCrashImage_02;
        private System.Windows.Forms.Timer timer;
    }
}