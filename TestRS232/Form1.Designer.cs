namespace RobotControlCIT255Project
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtTestBox = new System.Windows.Forms.TextBox();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.pBarDistance = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GpBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDanceMode = new System.Windows.Forms.Button();
            this.radAutomatic = new System.Windows.Forms.RadioButton();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.GpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConnect.Location = new System.Drawing.Point(0, 357);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(510, 42);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtTestBox
            // 
            this.txtTestBox.Location = new System.Drawing.Point(54, 6);
            this.txtTestBox.Name = "txtTestBox";
            this.txtTestBox.Size = new System.Drawing.Size(30, 22);
            this.txtTestBox.TabIndex = 1;
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(198, 190);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(71, 43);
            this.btnBackward.TabIndex = 2;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(103, 122);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(72, 42);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDisconnect.Location = new System.Drawing.Point(0, 330);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(510, 27);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(198, 122);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(71, 42);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(302, 122);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(77, 42);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(198, 64);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(71, 44);
            this.btnForward.TabIndex = 7;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // pBarDistance
            // 
            this.pBarDistance.Location = new System.Drawing.Point(24, 34);
            this.pBarDistance.Name = "pBarDistance";
            this.pBarDistance.Size = new System.Drawing.Size(465, 24);
            this.pBarDistance.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 22);
            this.textBox1.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // GpBox
            // 
            this.GpBox.Controls.Add(this.button2);
            this.GpBox.Controls.Add(this.button1);
            this.GpBox.Location = new System.Drawing.Point(75, 239);
            this.GpBox.Name = "GpBox";
            this.GpBox.Size = new System.Drawing.Size(414, 91);
            this.GpBox.TabIndex = 12;
            this.GpBox.TabStop = false;
            this.GpBox.Text = "Dance Motion";
            this.GpBox.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Samba";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "FreeStyle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDanceMode
            // 
            this.btnDanceMode.Location = new System.Drawing.Point(12, 237);
            this.btnDanceMode.Name = "btnDanceMode";
            this.btnDanceMode.Size = new System.Drawing.Size(57, 32);
            this.btnDanceMode.TabIndex = 13;
            this.btnDanceMode.Text = "Dance Mode";
            this.btnDanceMode.UseVisualStyleBackColor = true;
            this.btnDanceMode.Click += new System.EventHandler(this.btnDanceMode_Click);
            // 
            // radAutomatic
            // 
            this.radAutomatic.AutoSize = true;
            this.radAutomatic.Location = new System.Drawing.Point(123, 12);
            this.radAutomatic.Name = "radAutomatic";
            this.radAutomatic.Size = new System.Drawing.Size(71, 16);
            this.radAutomatic.TabIndex = 14;
            this.radAutomatic.TabStop = true;
            this.radAutomatic.Text = "Automatic";
            this.radAutomatic.UseVisualStyleBackColor = true;
            this.radAutomatic.CheckedChanged += new System.EventHandler(this.radAutomatic_CheckedChanged);
            this.radAutomatic.Click += new System.EventHandler(this.radAutomatic_Click);
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point(269, 10);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(58, 16);
            this.radManual.TabIndex = 15;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            this.radManual.CheckedChanged += new System.EventHandler(this.radManual_CheckedChanged);
            this.radManual.Click += new System.EventHandler(this.radManual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "80cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "0cm";
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(396, 87);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(62, 20);
            this.btnManual.TabIndex = 18;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 399);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radManual);
            this.Controls.Add(this.radAutomatic);
            this.Controls.Add(this.btnDanceMode);
            this.Controls.Add(this.GpBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pBarDistance);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.txtTestBox);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "R.Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtTestBox;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.ProgressBar pBarDistance;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnMoveNextWin;
        private System.Windows.Forms.GroupBox GpBox;
        private System.Windows.Forms.Button btnDanceMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radAutomatic;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManual;
    }
}

