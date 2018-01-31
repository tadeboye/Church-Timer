namespace Church_Timer
{
    partial class frmChurchTimer
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
            this.lblCurrent_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddMinutes = new System.Windows.Forms.Button();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tmrChurchTimer = new System.Windows.Forms.Timer(this.components);
            this.grpWarn = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtWarning_time = new System.Windows.Forms.TextBox();
            this.grpCritical = new System.Windows.Forms.GroupBox();
            this.txtCritical_time = new System.Windows.Forms.TextBox();
            this.grpWarning_level = new System.Windows.Forms.GroupBox();
            this.lblcontrollerTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpWarn.SuspendLayout();
            this.grpCritical.SuspendLayout();
            this.grpWarning_level.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrent_time
            // 
            this.lblCurrent_time.AutoSize = true;
            this.lblCurrent_time.Location = new System.Drawing.Point(14, 62);
            this.lblCurrent_time.Name = "lblCurrent_time";
            this.lblCurrent_time.Size = new System.Drawing.Size(107, 13);
            this.lblCurrent_time.TabIndex = 0;
            this.lblCurrent_time.Text = "will show current time";
            this.lblCurrent_time.Click += new System.EventHandler(this.lblCurrent_time_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddMinutes);
            this.groupBox1.Controls.Add(this.txtMinutes);
            this.groupBox1.Location = new System.Drawing.Point(31, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure Timer";
            // 
            // btnAddMinutes
            // 
            this.btnAddMinutes.Location = new System.Drawing.Point(15, 90);
            this.btnAddMinutes.Name = "btnAddMinutes";
            this.btnAddMinutes.Size = new System.Drawing.Size(73, 24);
            this.btnAddMinutes.TabIndex = 3;
            this.btnAddMinutes.Text = "ADD";
            this.btnAddMinutes.UseVisualStyleBackColor = true;
            this.btnAddMinutes.Click += new System.EventHandler(this.btnAddMinutes_Click);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(13, 30);
            this.txtMinutes.Multiline = true;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(75, 41);
            this.txtMinutes.TabIndex = 0;
            this.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(293, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrChurchTimer
            // 
            this.tmrChurchTimer.Interval = 1;
            // 
            // grpWarn
            // 
            this.grpWarn.BackColor = System.Drawing.Color.Transparent;
            this.grpWarn.Controls.Add(this.checkBox1);
            this.grpWarn.Controls.Add(this.txtWarning_time);
            this.grpWarn.ForeColor = System.Drawing.Color.Black;
            this.grpWarn.Location = new System.Drawing.Point(6, 12);
            this.grpWarn.Name = "grpWarn";
            this.grpWarn.Size = new System.Drawing.Size(95, 106);
            this.grpWarn.TabIndex = 0;
            this.grpWarn.TabStop = false;
            this.grpWarn.Text = "Warning";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show &Warning";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtWarning_time
            // 
            this.txtWarning_time.BackColor = System.Drawing.Color.Yellow;
            this.txtWarning_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarning_time.Location = new System.Drawing.Point(13, 20);
            this.txtWarning_time.Multiline = true;
            this.txtWarning_time.Name = "txtWarning_time";
            this.txtWarning_time.Size = new System.Drawing.Size(58, 41);
            this.txtWarning_time.TabIndex = 1;
            this.txtWarning_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWarning_time.TextChanged += new System.EventHandler(this.txtWarning_time_TextChanged);
            // 
            // grpCritical
            // 
            this.grpCritical.Controls.Add(this.txtCritical_time);
            this.grpCritical.Location = new System.Drawing.Point(107, 12);
            this.grpCritical.Name = "grpCritical";
            this.grpCritical.Size = new System.Drawing.Size(87, 105);
            this.grpCritical.TabIndex = 1;
            this.grpCritical.TabStop = false;
            this.grpCritical.Text = "Critical";
            // 
            // txtCritical_time
            // 
            this.txtCritical_time.BackColor = System.Drawing.Color.Red;
            this.txtCritical_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCritical_time.Location = new System.Drawing.Point(9, 20);
            this.txtCritical_time.Multiline = true;
            this.txtCritical_time.Name = "txtCritical_time";
            this.txtCritical_time.Size = new System.Drawing.Size(59, 41);
            this.txtCritical_time.TabIndex = 2;
            this.txtCritical_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCritical_time.TextChanged += new System.EventHandler(this.txtCritical_time_TextChanged);
            // 
            // grpWarning_level
            // 
            this.grpWarning_level.Controls.Add(this.grpCritical);
            this.grpWarning_level.Controls.Add(this.grpWarn);
            this.grpWarning_level.Location = new System.Drawing.Point(174, 124);
            this.grpWarning_level.Name = "grpWarning_level";
            this.grpWarning_level.Size = new System.Drawing.Size(200, 125);
            this.grpWarning_level.TabIndex = 4;
            this.grpWarning_level.TabStop = false;
            // 
            // lblcontrollerTime
            // 
            this.lblcontrollerTime.AutoSize = true;
            this.lblcontrollerTime.Location = new System.Drawing.Point(206, 24);
            this.lblcontrollerTime.Name = "lblcontrollerTime";
            this.lblcontrollerTime.Size = new System.Drawing.Size(0, 13);
            this.lblcontrollerTime.TabIndex = 7;
            this.lblcontrollerTime.Click += new System.EventHandler(this.lblcontrollerTime_Click);
            // 
            // frmChurchTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 326);
            this.Controls.Add(this.lblcontrollerTime);
            this.Controls.Add(this.grpWarning_level);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrent_time);
            this.Name = "frmChurchTimer";
            this.Text = "Church Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpWarn.ResumeLayout(false);
            this.grpWarn.PerformLayout();
            this.grpCritical.ResumeLayout(false);
            this.grpCritical.PerformLayout();
            this.grpWarning_level.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrent_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMinutes;
        public  System.Windows.Forms.TextBox txtMinutes;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Timer tmrChurchTimer;
        private System.Windows.Forms.GroupBox grpWarn;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox txtWarning_time;
        private System.Windows.Forms.GroupBox grpCritical;
        public System.Windows.Forms.TextBox txtCritical_time;
        private System.Windows.Forms.GroupBox grpWarning_level;
        public System.Windows.Forms.Label lblcontrollerTime;

    }
}

