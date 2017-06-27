namespace RdpCracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.console = new System.Windows.Forms.RichTextBox();
            this.darkForm1 = new theme.DarkForm();
            this.darkGroupBox3 = new theme.DarkGroupBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeOutLog = new System.Windows.Forms.TextBox();
            this.timeOutTotal = new System.Windows.Forms.TextBox();
            this.info2 = new System.Windows.Forms.Label();
            this.load = new theme.DarkButton();
            this.start = new theme.DarkButton();
            this.info1 = new System.Windows.Forms.Label();
            this.darkGroupBox1 = new theme.DarkGroupBox();
            this.darkForm1.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.console.Location = new System.Drawing.Point(6, 19);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(438, 309);
            this.console.TabIndex = 4;
            this.console.Text = "";
            // 
            // darkForm1
            // 
            this.darkForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.darkForm1.Controls.Add(this.darkGroupBox3);
            this.darkForm1.Controls.Add(this.darkGroupBox1);
            this.darkForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.darkForm1.FixedSingle = false;
            this.darkForm1.ForeColor = System.Drawing.Color.Gainsboro;
            this.darkForm1.Location = new System.Drawing.Point(0, 0);
            this.darkForm1.Name = "darkForm1";
            this.darkForm1.Size = new System.Drawing.Size(475, 522);
            this.darkForm1.Stretch = true;
            this.darkForm1.TabIndex = 5;
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox3.Controls.Add(this.check2);
            this.darkGroupBox3.Controls.Add(this.label2);
            this.darkGroupBox3.Controls.Add(this.check1);
            this.darkGroupBox3.Controls.Add(this.label1);
            this.darkGroupBox3.Controls.Add(this.timeOutLog);
            this.darkGroupBox3.Controls.Add(this.timeOutTotal);
            this.darkGroupBox3.Controls.Add(this.info2);
            this.darkGroupBox3.Controls.Add(this.load);
            this.darkGroupBox3.Controls.Add(this.start);
            this.darkGroupBox3.Controls.Add(this.info1);
            this.darkGroupBox3.Location = new System.Drawing.Point(12, 39);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(450, 122);
            this.darkGroupBox3.TabIndex = 8;
            this.darkGroupBox3.TabStop = false;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(116, 88);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(106, 17);
            this.check2.TabIndex = 8;
            this.check2.Text = "Save Connected";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "LogWait:";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Checked = true;
            this.check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check1.Location = new System.Drawing.Point(9, 88);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(99, 17);
            this.check1.TabIndex = 9;
            this.check1.Text = "Save LoggedIn";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TimeOut:";
            // 
            // timeOutLog
            // 
            this.timeOutLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOutLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.timeOutLog.ForeColor = System.Drawing.Color.White;
            this.timeOutLog.Location = new System.Drawing.Point(349, 45);
            this.timeOutLog.Name = "timeOutLog";
            this.timeOutLog.Size = new System.Drawing.Size(89, 20);
            this.timeOutLog.TabIndex = 9;
            this.timeOutLog.Text = "6";
            // 
            // timeOutTotal
            // 
            this.timeOutTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeOutTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.timeOutTotal.ForeColor = System.Drawing.Color.White;
            this.timeOutTotal.Location = new System.Drawing.Point(349, 19);
            this.timeOutTotal.Name = "timeOutTotal";
            this.timeOutTotal.Size = new System.Drawing.Size(89, 20);
            this.timeOutTotal.TabIndex = 8;
            this.timeOutTotal.Text = "20";
            // 
            // info2
            // 
            this.info2.AutoSize = true;
            this.info2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info2.Location = new System.Drawing.Point(128, 16);
            this.info2.Name = "info2";
            this.info2.Size = new System.Drawing.Size(29, 16);
            this.info2.TabIndex = 7;
            this.info2.Text = "info";
            // 
            // load
            // 
            this.load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.load.Image = ((System.Drawing.Image)(resources.GetObject("load.Image")));
            this.load.Location = new System.Drawing.Point(296, 71);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(68, 34);
            this.load.TabIndex = 0;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.Location = new System.Drawing.Point(370, 71);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(68, 34);
            this.start.TabIndex = 6;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_onclick);
            // 
            // info1
            // 
            this.info1.AutoSize = true;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(6, 16);
            this.info1.Name = "info1";
            this.info1.Size = new System.Drawing.Size(29, 16);
            this.info1.TabIndex = 0;
            this.info1.Text = "info";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkGroupBox1.Controls.Add(this.console);
            this.darkGroupBox1.Location = new System.Drawing.Point(12, 167);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.darkGroupBox1.Size = new System.Drawing.Size(450, 342);
            this.darkGroupBox1.TabIndex = 5;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Console";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 522);
            this.Controls.Add(this.darkForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rdp Checker V1.0 by n0ise9914";
            this.darkForm1.ResumeLayout(false);
            this.darkGroupBox3.ResumeLayout(false);
            this.darkGroupBox3.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox console;
        private theme.DarkForm darkForm1;
        private theme.DarkGroupBox darkGroupBox1;
        private theme.DarkButton start;
        private theme.DarkGroupBox darkGroupBox3;
        private System.Windows.Forms.Label info1;
        private theme.DarkButton load;
        private System.Windows.Forms.Label info2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeOutLog;
        private System.Windows.Forms.TextBox timeOutTotal;
    }
}

