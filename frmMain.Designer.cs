namespace BeenTogether
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnShare = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxGirl = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBoxBoy = new System.Windows.Forms.PictureBox();
            this.pictureBoxBK = new System.Windows.Forms.PictureBox();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblCT = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblBt = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Days = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGirl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.BackColor = System.Drawing.Color.LightPink;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.Indigo;
            this.btnShare.Image = global::BeenTogether.Properties.Resources.share;
            this.btnShare.Location = new System.Drawing.Point(382, 11);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(39, 33);
            this.btnShare.TabIndex = 11;
            this.btnShare.UseCompatibleTextRendering = true;
            this.btnShare.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "BeenTogether";
            // 
            // pictureBoxGirl
            // 
            this.pictureBoxGirl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxGirl.BackColor = System.Drawing.Color.LightPink;
            this.pictureBoxGirl.Image = global::BeenTogether.Properties.Resources.girl;
            this.pictureBoxGirl.Location = new System.Drawing.Point(285, 53);
            this.pictureBoxGirl.Name = "pictureBoxGirl";
            this.pictureBoxGirl.Size = new System.Drawing.Size(125, 123);
            this.pictureBoxGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGirl.TabIndex = 10;
            this.pictureBoxGirl.TabStop = false;
            this.pictureBoxGirl.Click += new System.EventHandler(this.pictureBoxGirl_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.BackColor = System.Drawing.Color.LightPink;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Indigo;
            this.btnSetting.Image = global::BeenTogether.Properties.Resources.settings;
            this.btnSetting.Location = new System.Drawing.Point(337, 11);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(39, 33);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.UseCompatibleTextRendering = true;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBoxBoy
            // 
            this.pictureBoxBoy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxBoy.BackColor = System.Drawing.Color.LightPink;
            this.pictureBoxBoy.Image = global::BeenTogether.Properties.Resources.user;
            this.pictureBoxBoy.Location = new System.Drawing.Point(21, 53);
            this.pictureBoxBoy.Name = "pictureBoxBoy";
            this.pictureBoxBoy.Size = new System.Drawing.Size(125, 123);
            this.pictureBoxBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBoy.TabIndex = 9;
            this.pictureBoxBoy.TabStop = false;
            this.pictureBoxBoy.Click += new System.EventHandler(this.pictureBoxBoy_Click);
            // 
            // pictureBoxBK
            // 
            this.pictureBoxBK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxBK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBK.Location = new System.Drawing.Point(12, 247);
            this.pictureBoxBK.Name = "pictureBoxBK";
            this.pictureBoxBK.Size = new System.Drawing.Size(409, 313);
            this.pictureBoxBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBK.TabIndex = 8;
            this.pictureBoxBK.TabStop = false;
            // 
            // lblP1
            // 
            this.lblP1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(64, 181);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(47, 18);
            this.lblP1.TabIndex = 18;
            this.lblP1.Text = "Person1";
            this.lblP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblP2
            // 
            this.lblP2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(336, 181);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(47, 18);
            this.lblP2.TabIndex = 19;
            this.lblP2.Text = "Person2";
            this.lblP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT
            // 
            this.lblCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCT.AutoSize = true;
            this.lblCT.Location = new System.Drawing.Point(18, 9);
            this.lblCT.Name = "lblCT";
            this.lblCT.Size = new System.Drawing.Size(51, 18);
            this.lblCT.TabIndex = 20;
            this.lblCT.Text = "Title text";
            this.lblCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(115, 217);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(14, 18);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "0";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBt
            // 
            this.lblBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBt.AutoSize = true;
            this.lblBt.Location = new System.Drawing.Point(161, 26);
            this.lblBt.Name = "lblBt";
            this.lblBt.Size = new System.Drawing.Size(0, 18);
            this.lblBt.TabIndex = 22;
            this.lblBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(135, 217);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(30, 18);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "Year";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Month";
            // 
            // Days
            // 
            this.Days.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Days.AutoSize = true;
            this.Days.Location = new System.Drawing.Point(278, 217);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(32, 18);
            this.Days.TabIndex = 25;
            this.Days.Text = "Days";
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(171, 217);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(14, 18);
            this.lblMonth.TabIndex = 26;
            this.lblMonth.Text = "0";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(252, 217);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(14, 18);
            this.lblDay.TabIndex = 27;
            this.lblDay.Text = "0";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "and";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeenTogether.Properties.Resources.like;
            this.pictureBox1.Location = new System.Drawing.Point(166, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(433, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblBt);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCT);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.pictureBoxGirl);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.pictureBoxBoy);
            this.Controls.Add(this.pictureBoxBK);
            this.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeenTogether";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGirl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.PictureBox pictureBoxGirl;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pictureBoxBoy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxBK;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblCT;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblBt;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

