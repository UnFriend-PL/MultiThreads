namespace MultiTheards
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.threadLabel1 = new System.Windows.Forms.Label();
            this.RunThread1 = new System.Windows.Forms.Button();
            this.RunThread2 = new System.Windows.Forms.Button();
            this.threadLabel2 = new System.Windows.Forms.Label();
            this.RunThread3 = new System.Windows.Forms.Button();
            this.threadLabel3 = new System.Windows.Forms.Label();
            this.RunThread4 = new System.Windows.Forms.Button();
            this.threadLabel4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.loggerLabel = new System.Windows.Forms.Label();
            this.LoggerTextbox = new System.Windows.Forms.TextBox();
            this.StopThread1 = new System.Windows.Forms.Button();
            this.StopThread2 = new System.Windows.Forms.Button();
            this.StopThread3 = new System.Windows.Forms.Button();
            this.StopThread4 = new System.Windows.Forms.Button();
            this.AvaibleThreadsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // threadLabel1
            // 
            this.threadLabel1.AutoSize = true;
            this.threadLabel1.Location = new System.Drawing.Point(25, 28);
            this.threadLabel1.Name = "threadLabel1";
            this.threadLabel1.Size = new System.Drawing.Size(52, 15);
            this.threadLabel1.TabIndex = 0;
            this.threadLabel1.Text = "Thread 1";
            // 
            // RunThread1
            // 
            this.RunThread1.Location = new System.Drawing.Point(210, 21);
            this.RunThread1.Name = "RunThread1";
            this.RunThread1.Size = new System.Drawing.Size(75, 29);
            this.RunThread1.TabIndex = 1;
            this.RunThread1.Text = "Run";
            this.RunThread1.UseVisualStyleBackColor = true;
            this.RunThread1.Click += new System.EventHandler(this.Thread_Click);
            // 
            // RunThread2
            // 
            this.RunThread2.Location = new System.Drawing.Point(210, 56);
            this.RunThread2.Name = "RunThread2";
            this.RunThread2.Size = new System.Drawing.Size(75, 29);
            this.RunThread2.TabIndex = 3;
            this.RunThread2.Text = "Run";
            this.RunThread2.UseVisualStyleBackColor = true;
            this.RunThread2.Click += new System.EventHandler(this.Thread_Click);
            // 
            // threadLabel2
            // 
            this.threadLabel2.AutoSize = true;
            this.threadLabel2.Location = new System.Drawing.Point(25, 63);
            this.threadLabel2.Name = "threadLabel2";
            this.threadLabel2.Size = new System.Drawing.Size(52, 15);
            this.threadLabel2.TabIndex = 2;
            this.threadLabel2.Text = "Thread 2";
            // 
            // RunThread3
            // 
            this.RunThread3.Location = new System.Drawing.Point(210, 91);
            this.RunThread3.Name = "RunThread3";
            this.RunThread3.Size = new System.Drawing.Size(75, 29);
            this.RunThread3.TabIndex = 5;
            this.RunThread3.Text = "Run";
            this.RunThread3.UseVisualStyleBackColor = true;
            this.RunThread3.Click += new System.EventHandler(this.Thread_Click);
            // 
            // threadLabel3
            // 
            this.threadLabel3.AutoSize = true;
            this.threadLabel3.Location = new System.Drawing.Point(25, 98);
            this.threadLabel3.Name = "threadLabel3";
            this.threadLabel3.Size = new System.Drawing.Size(52, 15);
            this.threadLabel3.TabIndex = 4;
            this.threadLabel3.Text = "Thread 3";
            // 
            // RunThread4
            // 
            this.RunThread4.Location = new System.Drawing.Point(210, 126);
            this.RunThread4.Name = "RunThread4";
            this.RunThread4.Size = new System.Drawing.Size(75, 29);
            this.RunThread4.TabIndex = 7;
            this.RunThread4.Text = "Run";
            this.RunThread4.UseVisualStyleBackColor = true;
            this.RunThread4.Click += new System.EventHandler(this.Thread_Click);
            // 
            // threadLabel4
            // 
            this.threadLabel4.AutoSize = true;
            this.threadLabel4.Location = new System.Drawing.Point(25, 133);
            this.threadLabel4.Name = "threadLabel4";
            this.threadLabel4.Size = new System.Drawing.Size(52, 15);
            this.threadLabel4.TabIndex = 6;
            this.threadLabel4.Text = "Thread 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(682, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(528, 588);
            this.textBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(83, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 23);
            this.comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(83, 130);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 23);
            this.comboBox4.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(348, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 301);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(682, 38);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(45, 15);
            this.outputLabel.TabIndex = 14;
            this.outputLabel.Text = "Output";
            // 
            // loggerLabel
            // 
            this.loggerLabel.AutoSize = true;
            this.loggerLabel.Location = new System.Drawing.Point(25, 180);
            this.loggerLabel.Name = "loggerLabel";
            this.loggerLabel.Size = new System.Drawing.Size(44, 15);
            this.loggerLabel.TabIndex = 15;
            this.loggerLabel.Text = "Logger";
            // 
            // LoggerTextbox
            // 
            this.LoggerTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoggerTextbox.Location = new System.Drawing.Point(25, 198);
            this.LoggerTextbox.Multiline = true;
            this.LoggerTextbox.Name = "LoggerTextbox";
            this.LoggerTextbox.ReadOnly = true;
            this.LoggerTextbox.Size = new System.Drawing.Size(295, 446);
            this.LoggerTextbox.TabIndex = 16;
            // 
            // StopThread1
            // 
            this.StopThread1.Enabled = false;
            this.StopThread1.Location = new System.Drawing.Point(291, 21);
            this.StopThread1.Name = "StopThread1";
            this.StopThread1.Size = new System.Drawing.Size(75, 29);
            this.StopThread1.TabIndex = 17;
            this.StopThread1.Text = "Stop";
            this.StopThread1.UseVisualStyleBackColor = true;
            this.StopThread1.Click += new System.EventHandler(this.Thread_Click);
            // 
            // StopThread2
            // 
            this.StopThread2.Enabled = false;
            this.StopThread2.Location = new System.Drawing.Point(291, 56);
            this.StopThread2.Name = "StopThread2";
            this.StopThread2.Size = new System.Drawing.Size(75, 29);
            this.StopThread2.TabIndex = 18;
            this.StopThread2.Text = "Stop";
            this.StopThread2.UseVisualStyleBackColor = true;
            this.StopThread2.Click += new System.EventHandler(this.Thread_Click);
            // 
            // StopThread3
            // 
            this.StopThread3.Enabled = false;
            this.StopThread3.Location = new System.Drawing.Point(291, 91);
            this.StopThread3.Name = "StopThread3";
            this.StopThread3.Size = new System.Drawing.Size(75, 29);
            this.StopThread3.TabIndex = 19;
            this.StopThread3.Text = "Stop";
            this.StopThread3.UseVisualStyleBackColor = true;
            this.StopThread3.Click += new System.EventHandler(this.Thread_Click);
            // 
            // StopThread4
            // 
            this.StopThread4.Enabled = false;
            this.StopThread4.Location = new System.Drawing.Point(291, 126);
            this.StopThread4.Name = "StopThread4";
            this.StopThread4.Size = new System.Drawing.Size(75, 29);
            this.StopThread4.TabIndex = 20;
            this.StopThread4.Text = "Stop";
            this.StopThread4.UseVisualStyleBackColor = true;
            this.StopThread4.Click += new System.EventHandler(this.Thread_Click);
            // 
            // AvaibleThreadsLabel
            // 
            this.AvaibleThreadsLabel.AutoSize = true;
            this.AvaibleThreadsLabel.Location = new System.Drawing.Point(418, 28);
            this.AvaibleThreadsLabel.Name = "AvaibleThreadsLabel";
            this.AvaibleThreadsLabel.Size = new System.Drawing.Size(0, 15);
            this.AvaibleThreadsLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 670);
            this.Controls.Add(this.AvaibleThreadsLabel);
            this.Controls.Add(this.StopThread4);
            this.Controls.Add(this.StopThread3);
            this.Controls.Add(this.StopThread2);
            this.Controls.Add(this.StopThread1);
            this.Controls.Add(this.LoggerTextbox);
            this.Controls.Add(this.loggerLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RunThread4);
            this.Controls.Add(this.threadLabel4);
            this.Controls.Add(this.RunThread3);
            this.Controls.Add(this.threadLabel3);
            this.Controls.Add(this.RunThread2);
            this.Controls.Add(this.threadLabel2);
            this.Controls.Add(this.RunThread1);
            this.Controls.Add(this.threadLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label threadLabel1;
        private Button RunThread1;
        private Button RunThread2;
        private Label threadLabel2;
        private Button RunThread3;
        private Label threadLabel3;
        private Button RunThread4;
        private Label threadLabel4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private Label outputLabel;
        private Label loggerLabel;
        private TextBox LoggerTextbox;
        private Button StopThread1;
        private Button StopThread2;
        private Button StopThread3;
        private Button StopThread4;
        private Label AvaibleThreadsLabel;
    }
}