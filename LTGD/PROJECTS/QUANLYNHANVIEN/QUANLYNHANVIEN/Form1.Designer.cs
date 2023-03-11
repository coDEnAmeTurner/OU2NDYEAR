namespace QUANLYNHANVIEN
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
            this.richTextBoxTen = new System.Windows.Forms.RichTextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMatKhau = new System.Windows.Forms.RichTextBox();
            this.buttonDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxTen
            // 
            this.richTextBoxTen.Location = new System.Drawing.Point(187, 42);
            this.richTextBoxTen.Multiline = false;
            this.richTextBoxTen.Name = "richTextBoxTen";
            this.richTextBoxTen.Size = new System.Drawing.Size(217, 23);
            this.richTextBoxTen.TabIndex = 0;
            this.richTextBoxTen.Text = "";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(90, 138);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(112, 23);
            this.buttonDangNhap.TabIndex = 1;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxMatKhau
            // 
            this.richTextBoxMatKhau.Location = new System.Drawing.Point(187, 81);
            this.richTextBoxMatKhau.Multiline = false;
            this.richTextBoxMatKhau.Name = "richTextBoxMatKhau";
            this.richTextBoxMatKhau.Size = new System.Drawing.Size(217, 23);
            this.richTextBoxMatKhau.TabIndex = 3;
            this.richTextBoxMatKhau.Text = "";
            // 
            // buttonDong
            // 
            this.buttonDong.Location = new System.Drawing.Point(251, 138);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(112, 23);
            this.buttonDong.TabIndex = 5;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 190);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.richTextBoxTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxTen;
        private Button buttonDangNhap;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxMatKhau;
        private Button buttonDong;

        public RichTextBox RichTextBoxTen { get { return this.richTextBoxTen; } }

    }
}