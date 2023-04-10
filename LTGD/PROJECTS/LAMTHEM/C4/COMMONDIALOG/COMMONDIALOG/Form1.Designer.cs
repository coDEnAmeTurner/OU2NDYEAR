namespace COMMONDIALOG
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
            this.buttonChon1TT = new System.Windows.Forms.Button();
            this.buttonChonNhieuTT = new System.Windows.Forms.Button();
            this.buttonChonThuMuc = new System.Windows.Forms.Button();
            this.buttonChonMauNen = new System.Windows.Forms.Button();
            this.buttonChonMauChu = new System.Windows.Forms.Button();
            this.buttonChonFont = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timerHien = new System.Windows.Forms.Timer(this.components);
            this.timerDong = new System.Windows.Forms.Timer(this.components);
            this.chon1TT = new System.Windows.Forms.OpenFileDialog();
            this.chonNhieuTT = new System.Windows.Forms.OpenFileDialog();
            this.chonThuMuc = new System.Windows.Forms.FolderBrowserDialog();
            this.chonMauNen = new System.Windows.Forms.ColorDialog();
            this.chonMauChu = new System.Windows.Forms.ColorDialog();
            this.chonFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // buttonChon1TT
            // 
            this.buttonChon1TT.Location = new System.Drawing.Point(26, 23);
            this.buttonChon1TT.Name = "buttonChon1TT";
            this.buttonChon1TT.Size = new System.Drawing.Size(200, 39);
            this.buttonChon1TT.TabIndex = 0;
            this.buttonChon1TT.Text = "Chọn một tập tin";
            this.buttonChon1TT.UseVisualStyleBackColor = true;
            this.buttonChon1TT.Click += new System.EventHandler(this.buttonChon1TT_Click);
            // 
            // buttonChonNhieuTT
            // 
            this.buttonChonNhieuTT.Location = new System.Drawing.Point(26, 83);
            this.buttonChonNhieuTT.Name = "buttonChonNhieuTT";
            this.buttonChonNhieuTT.Size = new System.Drawing.Size(200, 39);
            this.buttonChonNhieuTT.TabIndex = 1;
            this.buttonChonNhieuTT.Text = "Chọn nhiều tập tin";
            this.buttonChonNhieuTT.UseVisualStyleBackColor = true;
            this.buttonChonNhieuTT.Click += new System.EventHandler(this.buttonChonNhieuTT_Click);
            // 
            // buttonChonThuMuc
            // 
            this.buttonChonThuMuc.Location = new System.Drawing.Point(26, 143);
            this.buttonChonThuMuc.Name = "buttonChonThuMuc";
            this.buttonChonThuMuc.Size = new System.Drawing.Size(200, 39);
            this.buttonChonThuMuc.TabIndex = 2;
            this.buttonChonThuMuc.Text = "Chọn thư mục";
            this.buttonChonThuMuc.UseVisualStyleBackColor = true;
            this.buttonChonThuMuc.Click += new System.EventHandler(this.buttonChonThuMuc_Click);
            // 
            // buttonChonMauNen
            // 
            this.buttonChonMauNen.Location = new System.Drawing.Point(26, 202);
            this.buttonChonMauNen.Name = "buttonChonMauNen";
            this.buttonChonMauNen.Size = new System.Drawing.Size(200, 39);
            this.buttonChonMauNen.TabIndex = 3;
            this.buttonChonMauNen.Text = "Chọn màu nền";
            this.buttonChonMauNen.UseVisualStyleBackColor = true;
            this.buttonChonMauNen.Click += new System.EventHandler(this.buttonChonMauNen_Click);
            // 
            // buttonChonMauChu
            // 
            this.buttonChonMauChu.Location = new System.Drawing.Point(26, 263);
            this.buttonChonMauChu.Name = "buttonChonMauChu";
            this.buttonChonMauChu.Size = new System.Drawing.Size(200, 39);
            this.buttonChonMauChu.TabIndex = 4;
            this.buttonChonMauChu.Text = "Chọn màu chữ";
            this.buttonChonMauChu.UseVisualStyleBackColor = true;
            this.buttonChonMauChu.Click += new System.EventHandler(this.buttonChonMauChu_Click);
            // 
            // buttonChonFont
            // 
            this.buttonChonFont.Location = new System.Drawing.Point(26, 324);
            this.buttonChonFont.Name = "buttonChonFont";
            this.buttonChonFont.Size = new System.Drawing.Size(200, 39);
            this.buttonChonFont.TabIndex = 5;
            this.buttonChonFont.Text = "Chọn font";
            this.buttonChonFont.UseVisualStyleBackColor = true;
            this.buttonChonFont.Click += new System.EventHandler(this.buttonChonFont_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(288, 324);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(249, 39);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(543, 324);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(232, 39);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(288, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(487, 295);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // timerHien
            // 
            this.timerHien.Interval = 80;
            this.timerHien.Tick += new System.EventHandler(this.timerHien_Tick);
            // 
            // timerDong
            // 
            this.timerDong.Interval = 80;
            this.timerDong.Tick += new System.EventHandler(this.timerDong_Tick);
            // 
            // chon1TT
            // 
            this.chon1TT.FileName = "openFileDialog1";
            // 
            // chonNhieuTT
            // 
            this.chonNhieuTT.FileName = "openFileDialog1";
            // 
            // chonMauChu
            // 
            this.chonMauChu.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 380);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonChonFont);
            this.Controls.Add(this.buttonChonMauChu);
            this.Controls.Add(this.buttonChonMauNen);
            this.Controls.Add(this.buttonChonThuMuc);
            this.Controls.Add(this.buttonChonNhieuTT);
            this.Controls.Add(this.buttonChon1TT);
            this.Name = "Form1";
            this.Text = "CommonDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonChon1TT;
        private Button buttonChonNhieuTT;
        private Button buttonChonThuMuc;
        private Button buttonChonMauNen;
        private Button buttonChonMauChu;
        private Button buttonChonFont;
        private Button buttonReset;
        private Button buttonThoat;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timerHien;
        private System.Windows.Forms.Timer timerDong;
        private OpenFileDialog chon1TT;
        private OpenFileDialog chonNhieuTT;
        private FolderBrowserDialog chonThuMuc;
        private ColorDialog chonMauNen;
        private ColorDialog chonMauChu;
        private FontDialog chonFont;
    }
}