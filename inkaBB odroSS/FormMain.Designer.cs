namespace inkaBB_odroSS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLeft = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPeriod = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxHour = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelSep2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxMinute = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSecond = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.timerForegroundWindow = new System.Windows.Forms.Timer(this.components);
            this.listBoxExcludedPrograms = new System.Windows.Forms.ListBox();
            this.listBoxIncludedPrograms = new System.Windows.Forms.ListBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLeft,
            this.toolStripButtonRight,
            this.toolStripSeparator2,
            this.toolStripLabelPeriod,
            this.toolStripTextBoxHour,
            this.toolStripLabelSep2,
            this.toolStripTextBoxMinute,
            this.toolStripLabel4,
            this.toolStripTextBoxSecond,
            this.toolStripLabel1,
            this.toolStripButtonStart,
            this.toolStripSeparator1,
            this.toolStripButtonAbout});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(616, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonLeft
            // 
            this.toolStripButtonLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLeft.Enabled = false;
            this.toolStripButtonLeft.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLeft.Image")));
            this.toolStripButtonLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLeft.Name = "toolStripButtonLeft";
            this.toolStripButtonLeft.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLeft.Text = "Exclude";
            this.toolStripButtonLeft.Click += new System.EventHandler(this.toolStripButtonLeft_Click);
            // 
            // toolStripButtonRight
            // 
            this.toolStripButtonRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRight.Enabled = false;
            this.toolStripButtonRight.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRight.Image")));
            this.toolStripButtonRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRight.Name = "toolStripButtonRight";
            this.toolStripButtonRight.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRight.Text = "Include";
            this.toolStripButtonRight.Click += new System.EventHandler(this.toolStripButtonRight_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelPeriod
            // 
            this.toolStripLabelPeriod.Name = "toolStripLabelPeriod";
            this.toolStripLabelPeriod.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabelPeriod.Text = "Period:";
            // 
            // toolStripTextBoxHour
            // 
            this.toolStripTextBoxHour.Name = "toolStripTextBoxHour";
            this.toolStripTextBoxHour.Size = new System.Drawing.Size(30, 25);
            // 
            // toolStripLabelSep2
            // 
            this.toolStripLabelSep2.Name = "toolStripLabelSep2";
            this.toolStripLabelSep2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabelSep2.Text = ":";
            // 
            // toolStripTextBoxMinute
            // 
            this.toolStripTextBoxMinute.Name = "toolStripTextBoxMinute";
            this.toolStripTextBoxMinute.Size = new System.Drawing.Size(30, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel4.Text = ":";
            // 
            // toolStripTextBoxSecond
            // 
            this.toolStripTextBoxSecond.Name = "toolStripTextBoxSecond";
            this.toolStripTextBoxSecond.Size = new System.Drawing.Size(30, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Run";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // timerForegroundWindow
            // 
            this.timerForegroundWindow.Interval = 3000;
            this.timerForegroundWindow.Tick += new System.EventHandler(this.timerForegroundWindow_Tick);
            // 
            // listBoxExcludedPrograms
            // 
            this.listBoxExcludedPrograms.FormattingEnabled = true;
            this.listBoxExcludedPrograms.Location = new System.Drawing.Point(0, 53);
            this.listBoxExcludedPrograms.Name = "listBoxExcludedPrograms";
            this.listBoxExcludedPrograms.Size = new System.Drawing.Size(304, 212);
            this.listBoxExcludedPrograms.TabIndex = 3;
            this.listBoxExcludedPrograms.SelectedIndexChanged += new System.EventHandler(this.listBoxExcludedPrograms_SelectedIndexChanged);
            // 
            // listBoxIncludedPrograms
            // 
            this.listBoxIncludedPrograms.FormattingEnabled = true;
            this.listBoxIncludedPrograms.Location = new System.Drawing.Point(310, 53);
            this.listBoxIncludedPrograms.Name = "listBoxIncludedPrograms";
            this.listBoxIncludedPrograms.Size = new System.Drawing.Size(304, 212);
            this.listBoxIncludedPrograms.TabIndex = 4;
            this.listBoxIncludedPrograms.SelectedIndexChanged += new System.EventHandler(this.listBoxIncludedPrograms_SelectedIndexChanged);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opened windows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Allowed windows:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(616, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxIncludedPrograms);
            this.Controls.Add(this.listBoxExcludedPrograms);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "inkaBB odroSS";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPeriod;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxHour;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSep2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxMinute;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSecond;
        private System.Windows.Forms.ToolStripSeparator toolStripLabel1;
        private System.Windows.Forms.Timer timerForegroundWindow;
        private System.Windows.Forms.ListBox listBoxExcludedPrograms;
        private System.Windows.Forms.ToolStripButton toolStripButtonLeft;
        private System.Windows.Forms.ToolStripButton toolStripButtonRight;
        private System.Windows.Forms.ListBox listBoxIncludedPrograms;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

