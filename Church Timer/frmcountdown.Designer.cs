namespace Church_Timer
{
    partial class frmcountdown
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCountdown = new System.Windows.Forms.Label();
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblWarning_time = new System.Windows.Forms.Label();
            this.lblCritical_time = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.tmrCountdownSeconds = new System.Windows.Forms.Timer(this.components);
            this.btnCloseCountdown = new System.Windows.Forms.Button();
            this.lblTimeUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCountdown
            // 
            this.lblCountdown.Font = new System.Drawing.Font("Digital-7", 480F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCountdown.Location = new System.Drawing.Point(47, 119);
            this.lblCountdown.Margin = new System.Windows.Forms.Padding(0);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(1280, 600);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "test";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCountdown.Click += new System.EventHandler(this.lblCountdown_Click);
            // 
            // tmrCountdown
            // 
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            // 
            // lblWarning_time
            // 
            this.lblWarning_time.AutoSize = true;
            this.lblWarning_time.Location = new System.Drawing.Point(96, 9);
            this.lblWarning_time.Name = "lblWarning_time";
            this.lblWarning_time.Size = new System.Drawing.Size(69, 13);
            this.lblWarning_time.TabIndex = 1;
            this.lblWarning_time.Text = "warning_time";
            this.lblWarning_time.Visible = false;
            // 
            // lblCritical_time
            // 
            this.lblCritical_time.AutoSize = true;
            this.lblCritical_time.Location = new System.Drawing.Point(200, 7);
            this.lblCritical_time.Name = "lblCritical_time";
            this.lblCritical_time.Size = new System.Drawing.Size(62, 13);
            this.lblCritical_time.TabIndex = 2;
            this.lblCritical_time.Text = "critical_time";
            this.lblCritical_time.Visible = false;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Digital-7", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSeconds.Location = new System.Drawing.Point(1071, 630);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(0, 329);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblSeconds.Click += new System.EventHandler(this.label1_Click);
            // 
            // tmrCountdownSeconds
            // 
            this.tmrCountdownSeconds.Enabled = true;
            this.tmrCountdownSeconds.Interval = 1000;
            this.tmrCountdownSeconds.Tick += new System.EventHandler(this.tmrCountdownSeconds_Tick);
            // 
            // btnCloseCountdown
            // 
            this.btnCloseCountdown.Location = new System.Drawing.Point(99, 741);
            this.btnCloseCountdown.Name = "btnCloseCountdown";
            this.btnCloseCountdown.Size = new System.Drawing.Size(75, 23);
            this.btnCloseCountdown.TabIndex = 4;
            this.btnCloseCountdown.Text = "&Close";
            this.btnCloseCountdown.UseVisualStyleBackColor = true;
            this.btnCloseCountdown.Click += new System.EventHandler(this.btnCloseCountdown_Click);
            // 
            // lblTimeUp
            // 
            this.lblTimeUp.AutoSize = true;
            this.lblTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeUp.Location = new System.Drawing.Point(-5, 291);
            this.lblTimeUp.Name = "lblTimeUp";
            this.lblTimeUp.Size = new System.Drawing.Size(1310, 302);
            this.lblTimeUp.TabIndex = 5;
            this.lblTimeUp.Text = "Time up!!!";
            this.lblTimeUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeUp.Visible = false;
            // 
            // frmcountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.btnCloseCountdown);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblCritical_time);
            this.Controls.Add(this.lblWarning_time);
            this.Controls.Add(this.lblCountdown);
            this.Controls.Add(this.lblTimeUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmcountdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmcountdown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCountdown;
        public System.Windows.Forms.Timer tmrCountdown;
        public System.Windows.Forms.Label lblWarning_time;
        public System.Windows.Forms.Label lblCritical_time;
        private System.Windows.Forms.Label lblSeconds;
        public System.Windows.Forms.Timer tmrCountdownSeconds;
        private System.Windows.Forms.Button btnCloseCountdown;
        public System.Windows.Forms.Label lblTimeUp;
        
    }
}