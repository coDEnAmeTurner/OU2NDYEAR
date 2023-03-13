using System.Reflection.Emit;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxTen = new System.Windows.Forms.RichTextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDanhSach = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTmPckrNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxTen
            // 
            this.richTextBoxTen.Location = new System.Drawing.Point(89, 106);
            this.richTextBoxTen.Name = "richTextBoxTen";
            this.richTextBoxTen.Size = new System.Drawing.Size(193, 20);
            this.richTextBoxTen.TabIndex = 1;
            this.richTextBoxTen.Text = "";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(89, 224);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(80, 20);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.Location = new System.Drawing.Point(26, 3);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 4;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNu);
            this.panel1.Controls.Add(this.radioButtonNam);
            this.panel1.Location = new System.Drawing.Point(89, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 30);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(101, 3);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 5;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(676, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewDanhSach
            // 
            this.listViewDanhSach.Location = new System.Drawing.Point(303, 106);
            this.listViewDanhSach.Name = "listViewDanhSach";
            this.listViewDanhSach.Size = new System.Drawing.Size(363, 192);
            this.listViewDanhSach.SmallImageList = this.imageList1;
            this.listViewDanhSach.TabIndex = 7;
            this.listViewDanhSach.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTmPckrNgaySinh
            // 
            this.dateTmPckrNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTmPckrNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTmPckrNgaySinh.Location = new System.Drawing.Point(89, 138);
            this.dateTmPckrNgaySinh.Name = "dateTmPckrNgaySinh";
            this.dateTmPckrNgaySinh.Size = new System.Drawing.Size(193, 20);
            this.dateTmPckrNgaySinh.TabIndex = 9;
            this.dateTmPckrNgaySinh.Value = new System.DateTime(2023, 3, 11, 20, 32, 6, 0);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(190, 224);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(80, 20);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTenDangNhap.Location = new System.Drawing.Point(10, 270);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(272, 28);
            this.labelTenDangNhap.TabIndex = 11;
            this.labelTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerFade
            // 
            this.timerFade.Interval = 40;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "male.png");
            this.imageList1.Images.SetKeyName(1, "female.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 328);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RichTextBox richTextBoxTen;
        private Button buttonThem;
        private RadioButton radioButtonNam;
        private Panel panel1;
        private RadioButton radioButtonNu;
        private System.Windows.Forms.Label label2;
        private ListView listViewDanhSach;
        private System.Windows.Forms.Label label3;
        private DateTimePicker dateTmPckrNgaySinh;
        private Button buttonXoa;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.Timer timerFade;
        private ImageList imageList1;
    }
}