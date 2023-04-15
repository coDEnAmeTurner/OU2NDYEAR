namespace QUANLYSINHVIEN
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHo = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMSSV = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxTimMSSV = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTimTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSapTen = new System.Windows.Forms.Button();
            this.buttonHienThi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ";
            // 
            // textBoxHo
            // 
            this.textBoxHo.Location = new System.Drawing.Point(87, 62);
            this.textBoxHo.Name = "textBoxHo";
            this.textBoxHo.Size = new System.Drawing.Size(140, 23);
            this.textBoxHo.TabIndex = 2;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(87, 106);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(140, 23);
            this.textBoxTen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên";
            // 
            // txtBoxMSSV
            // 
            this.txtBoxMSSV.Location = new System.Drawing.Point(87, 22);
            this.txtBoxMSSV.Name = "txtBoxMSSV";
            this.txtBoxMSSV.Size = new System.Drawing.Size(140, 23);
            this.txtBoxMSSV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxMSSV);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxHo);
            this.groupBox1.Controls.Add(this.textBoxTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập SV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxTimMSSV);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBoxTimTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(360, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm SV";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tìm theo Tên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxTimMSSV
            // 
            this.textBoxTimMSSV.Location = new System.Drawing.Point(63, 22);
            this.textBoxTimMSSV.Name = "textBoxTimMSSV";
            this.textBoxTimMSSV.Size = new System.Drawing.Size(140, 23);
            this.textBoxTimMSSV.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tìm theo MSSV";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTimTen
            // 
            this.textBoxTimTen.Location = new System.Drawing.Point(264, 22);
            this.textBoxTimTen.Name = "textBoxTimTen";
            this.textBoxTimTen.Size = new System.Drawing.Size(140, 23);
            this.textBoxTimTen.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(226, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "MSSV";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(360, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(428, 290);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // buttonSapTen
            // 
            this.buttonSapTen.Location = new System.Drawing.Point(12, 212);
            this.buttonSapTen.Name = "buttonSapTen";
            this.buttonSapTen.Size = new System.Drawing.Size(267, 59);
            this.buttonSapTen.TabIndex = 7;
            this.buttonSapTen.Text = "Sắp theo Tên";
            this.buttonSapTen.UseVisualStyleBackColor = true;
            this.buttonSapTen.Click += new System.EventHandler(this.buttonSapTen_Click);
            // 
            // buttonHienThi
            // 
            this.buttonHienThi.Location = new System.Drawing.Point(12, 311);
            this.buttonHienThi.Name = "buttonHienThi";
            this.buttonHienThi.Size = new System.Drawing.Size(267, 59);
            this.buttonHienThi.TabIndex = 11;
            this.buttonHienThi.Text = "Hiển thị";
            this.buttonHienThi.UseVisualStyleBackColor = true;
            this.buttonHienThi.Click += new System.EventHandler(this.buttonHienThi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHienThi);
            this.Controls.Add(this.buttonSapTen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label2;
        private TextBox textBoxHo;
        private TextBox textBoxTen;
        private Label label1;
        private Label label3;
        private TextBox txtBoxMSSV;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxTimMSSV;
        private Button button3;
        private TextBox textBoxTimTen;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox1;
        private Button buttonSapTen;
        private Button buttonHienThi;
        private Button button2;
    }
}