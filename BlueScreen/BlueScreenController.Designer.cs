namespace BlueScreen
{
    partial class BlueScreenController
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
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.rbShutdown = new System.Windows.Forms.RadioButton();
            this.rbRestart = new System.Windows.Forms.RadioButton();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTakeAction = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.rbAfter = new System.Windows.Forms.RadioButton();
            this.rbOnStartup = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAction.SuspendLayout();
            this.gbTakeAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.rbShutdown);
            this.gbAction.Controls.Add(this.rbRestart);
            this.gbAction.Controls.Add(this.rbSleep);
            this.gbAction.Location = new System.Drawing.Point(20, 20);
            this.gbAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAction.Size = new System.Drawing.Size(335, 72);
            this.gbAction.TabIndex = 0;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Action";
            // 
            // rbShutdown
            // 
            this.rbShutdown.AutoSize = true;
            this.rbShutdown.Location = new System.Drawing.Point(217, 32);
            this.rbShutdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbShutdown.Name = "rbShutdown";
            this.rbShutdown.Size = new System.Drawing.Size(97, 25);
            this.rbShutdown.TabIndex = 1;
            this.rbShutdown.Text = "Shutdown";
            this.rbShutdown.UseVisualStyleBackColor = true;
            // 
            // rbRestart
            // 
            this.rbRestart.AutoSize = true;
            this.rbRestart.Location = new System.Drawing.Point(113, 32);
            this.rbRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRestart.Name = "rbRestart";
            this.rbRestart.Size = new System.Drawing.Size(75, 25);
            this.rbRestart.TabIndex = 1;
            this.rbRestart.Text = "Restart";
            this.rbRestart.UseVisualStyleBackColor = true;
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.Checked = true;
            this.rbSleep.Location = new System.Drawing.Point(18, 32);
            this.rbSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(65, 25);
            this.rbSleep.TabIndex = 1;
            this.rbSleep.TabStop = true;
            this.rbSleep.Text = "Sleep";
            this.rbSleep.UseVisualStyleBackColor = true;
            // 
            // gbTakeAction
            // 
            this.gbTakeAction.Controls.Add(this.label1);
            this.gbTakeAction.Controls.Add(this.nudTime);
            this.gbTakeAction.Controls.Add(this.rbAfter);
            this.gbTakeAction.Controls.Add(this.rbOnStartup);
            this.gbTakeAction.Location = new System.Drawing.Point(20, 102);
            this.gbTakeAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTakeAction.Name = "gbTakeAction";
            this.gbTakeAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTakeAction.Size = new System.Drawing.Size(335, 106);
            this.gbTakeAction.TabIndex = 0;
            this.gbTakeAction.TabStop = false;
            this.gbTakeAction.Text = "Take Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min ( Maximum 10min )";
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(75, 65);
            this.nudTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(77, 29);
            this.nudTime.TabIndex = 2;
            this.nudTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbAfter
            // 
            this.rbAfter.AutoSize = true;
            this.rbAfter.Checked = true;
            this.rbAfter.Location = new System.Drawing.Point(18, 67);
            this.rbAfter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbAfter.Name = "rbAfter";
            this.rbAfter.Size = new System.Drawing.Size(61, 25);
            this.rbAfter.TabIndex = 1;
            this.rbAfter.TabStop = true;
            this.rbAfter.Text = "After";
            this.rbAfter.UseVisualStyleBackColor = true;
            this.rbAfter.CheckedChanged += new System.EventHandler(this.rbAfter_CheckedChanged);
            // 
            // rbOnStartup
            // 
            this.rbOnStartup.AutoSize = true;
            this.rbOnStartup.Location = new System.Drawing.Point(18, 32);
            this.rbOnStartup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOnStartup.Name = "rbOnStartup";
            this.rbOnStartup.Size = new System.Drawing.Size(101, 25);
            this.rbOnStartup.TabIndex = 1;
            this.rbOnStartup.Text = "On Startup";
            this.rbOnStartup.UseVisualStyleBackColor = true;
            this.rbOnStartup.CheckedChanged += new System.EventHandler(this.rbOnStartup_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(20, 216);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(95, 35);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(226, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit BlueScreen";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BlueScreenController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbTakeAction);
            this.Controls.Add(this.gbAction);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 275);
            this.Name = "BlueScreenController";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlueScreenController";
            this.Load += new System.EventHandler(this.BlueScreenController_Load);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.gbTakeAction.ResumeLayout(false);
            this.gbTakeAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.RadioButton rbShutdown;
        private System.Windows.Forms.RadioButton rbRestart;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbTakeAction;
        private System.Windows.Forms.RadioButton rbAfter;
        private System.Windows.Forms.RadioButton rbOnStartup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnExit;
    }
}