namespace AutoShutDown
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCPUMax = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.triggerTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rbtnShutdown = new System.Windows.Forms.RadioButton();
            this.rbtnHibernate = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Location = new System.Drawing.Point(371, 6);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 53);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max Cpu";
            // 
            // tbCPUMax
            // 
            this.tbCPUMax.Location = new System.Drawing.Point(83, 6);
            this.tbCPUMax.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPUMax.Name = "tbCPUMax";
            this.tbCPUMax.Size = new System.Drawing.Size(76, 23);
            this.tbCPUMax.TabIndex = 2;
            this.tbCPUMax.Text = "15";
            this.tbCPUMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(83, 36);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(76, 23);
            this.tbTime.TabIndex = 4;
            this.tbTime.Text = "2";
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            // 
            // tbDisplay
            // 
            this.tbDisplay.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.30769F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbDisplay.Location = new System.Drawing.Point(482, 6);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.Size = new System.Drawing.Size(117, 53);
            this.tbDisplay.TabIndex = 5;
            this.tbDisplay.Text = "00:00";
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // triggerTimer
            // 
            this.triggerTimer.Interval = 1000;
            this.triggerTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rbtnShutdown);
            this.groupBox.Controls.Add(this.rbtnHibernate);
            this.groupBox.Location = new System.Drawing.Point(166, 6);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(198, 53);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Options";
            // 
            // rbtnShutdown
            // 
            this.rbtnShutdown.AutoSize = true;
            this.rbtnShutdown.Location = new System.Drawing.Point(101, 20);
            this.rbtnShutdown.Name = "rbtnShutdown";
            this.rbtnShutdown.Size = new System.Drawing.Size(88, 21);
            this.rbtnShutdown.TabIndex = 1;
            this.rbtnShutdown.Text = "Shutdown";
            this.rbtnShutdown.UseVisualStyleBackColor = true;
            // 
            // rbtnHibernate
            // 
            this.rbtnHibernate.AutoSize = true;
            this.rbtnHibernate.Checked = true;
            this.rbtnHibernate.Location = new System.Drawing.Point(7, 20);
            this.rbtnHibernate.Name = "rbtnHibernate";
            this.rbtnHibernate.Size = new System.Drawing.Size(88, 21);
            this.rbtnHibernate.TabIndex = 0;
            this.rbtnHibernate.TabStop = true;
            this.rbtnHibernate.Text = "Hibernate";
            this.rbtnHibernate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 66);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCPUMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.692307F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AutoShutdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCPUMax;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Timer triggerTimer;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rbtnHibernate;
        private System.Windows.Forms.RadioButton rbtnShutdown;
    }
}

