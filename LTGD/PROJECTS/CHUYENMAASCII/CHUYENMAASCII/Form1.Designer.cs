namespace CHUYENMAASCII
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKetQuaKyTu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAsciiToKyTu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAscii = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKetQuaAscii = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKyTuToAscii = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKyTu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(781, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN MÃ ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKetQuaKyTu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonAsciiToKyTu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAscii);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyễn mã ASCII sang ký tự";
            // 
            // labelKetQuaKyTu
            // 
            this.labelKetQuaKyTu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKetQuaKyTu.Location = new System.Drawing.Point(186, 130);
            this.labelKetQuaKyTu.Name = "labelKetQuaKyTu";
            this.labelKetQuaKyTu.Size = new System.Drawing.Size(100, 35);
            this.labelKetQuaKyTu.TabIndex = 7;
            this.labelKetQuaKyTu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(56, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // buttonAsciiToKyTu
            // 
            this.buttonAsciiToKyTu.Location = new System.Drawing.Point(186, 80);
            this.buttonAsciiToKyTu.Name = "buttonAsciiToKyTu";
            this.buttonAsciiToKyTu.Size = new System.Drawing.Size(100, 36);
            this.buttonAsciiToKyTu.TabIndex = 3;
            this.buttonAsciiToKyTu.Text = "Chuyển";
            this.buttonAsciiToKyTu.UseVisualStyleBackColor = true;
            this.buttonAsciiToKyTu.Click += new System.EventHandler(this.buttonAsciiToKyTu_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã ASCII";
            // 
            // textBoxAscii
            // 
            this.textBoxAscii.Location = new System.Drawing.Point(186, 37);
            this.textBoxAscii.Name = "textBoxAscii";
            this.textBoxAscii.Size = new System.Drawing.Size(100, 29);
            this.textBoxAscii.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelKetQuaAscii);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonKyTuToAscii);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxKyTu);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(408, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chuyễn ký tự sang mã ASCII";
            // 
            // labelKetQuaAscii
            // 
            this.labelKetQuaAscii.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKetQuaAscii.Location = new System.Drawing.Point(147, 140);
            this.labelKetQuaAscii.Name = "labelKetQuaAscii";
            this.labelKetQuaAscii.Size = new System.Drawing.Size(100, 35);
            this.labelKetQuaAscii.TabIndex = 7;
            this.labelKetQuaAscii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(56, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kết quả";
            // 
            // buttonKyTuToAscii
            // 
            this.buttonKyTuToAscii.Location = new System.Drawing.Point(147, 85);
            this.buttonKyTuToAscii.Name = "buttonKyTuToAscii";
            this.buttonKyTuToAscii.Size = new System.Drawing.Size(100, 36);
            this.buttonKyTuToAscii.TabIndex = 3;
            this.buttonKyTuToAscii.Text = "Chuyển";
            this.buttonKyTuToAscii.UseVisualStyleBackColor = true;
            this.buttonKyTuToAscii.Click += new System.EventHandler(this.buttonKyTuToAscii_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(56, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ký tự";
            // 
            // textBoxKyTu
            // 
            this.textBoxKyTu.Location = new System.Drawing.Point(147, 37);
            this.textBoxKyTu.Name = "textBoxKyTu";
            this.textBoxKyTu.Size = new System.Drawing.Size(100, 29);
            this.textBoxKyTu.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(781, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển mã ASCII";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAsciiToKyTu;
        private Label label2;
        private TextBox textBoxAscii;
        private Label labelKetQuaKyTu;
        private Label label4;
        private GroupBox groupBox2;
        private Label labelKetQuaAscii;
        private Label label6;
        private Button buttonKyTuToAscii;
        private Label label7;
        private TextBox textBoxKyTu;
    }
}