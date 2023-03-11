namespace QUANLYNHANVIEN
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxTen = new System.Windows.Forms.RichTextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDanhSach = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTmPckrNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxTen
            // 
            this.richTextBoxTen.Location = new System.Drawing.Point(104, 122);
            this.richTextBoxTen.Name = "richTextBoxTen";
            this.richTextBoxTen.Size = new System.Drawing.Size(225, 23);
            this.richTextBoxTen.TabIndex = 1;
            this.richTextBoxTen.Text = "";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(104, 259);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(93, 23);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.Location = new System.Drawing.Point(30, 3);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(51, 19);
            this.radioButtonNam.TabIndex = 4;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNu);
            this.panel1.Controls.Add(this.radioButtonNam);
            this.panel1.Location = new System.Drawing.Point(104, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 35);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 62);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewDanhSach
            // 
            this.listViewDanhSach.Location = new System.Drawing.Point(354, 122);
            this.listViewDanhSach.Name = "listViewDanhSach";
            this.listViewDanhSach.Size = new System.Drawing.Size(423, 221);
            this.listViewDanhSach.TabIndex = 7;
            this.listViewDanhSach.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTmPckrNgaySinh
            // 
            this.dateTmPckrNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTmPckrNgaySinh.Location = new System.Drawing.Point(104, 159);
            this.dateTmPckrNgaySinh.Name = "dateTmPckrNgaySinh";
            this.dateTmPckrNgaySinh.Size = new System.Drawing.Size(225, 23);
            this.dateTmPckrNgaySinh.TabIndex = 9;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(118, 3);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNu.TabIndex = 5;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(222, 259);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(93, 23);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTenDangNhap.Location = new System.Drawing.Point(12, 311);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(317, 32);
            this.labelTenDangNhap.TabIndex = 11;
            this.labelTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 379);
            this.Controls.Add(this.labelTenDangNhap);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.dateTmPckrNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.richTextBoxTen);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxTen;
        private Button buttonThem;
        private RadioButton radioButtonNam;
        private Panel panel1;
        private RadioButton radioButtonNu;
        private Label label2;
        private ListView listViewDanhSach;
        private Label label3;
        private DateTimePicker dateTmPckrNgaySinh;
        private Button buttonXoa;
        private Label labelTenDangNhap;

    }
}