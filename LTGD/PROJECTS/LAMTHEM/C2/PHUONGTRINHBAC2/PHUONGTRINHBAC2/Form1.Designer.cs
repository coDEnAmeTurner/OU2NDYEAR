namespace PHUONGTRINHBAC2
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.buttonGiai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương giải phương trình bậc 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxA.Location = new System.Drawing.Point(143, 131);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 43);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonGiai
            // 
            this.buttonGiai.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonGiai.Location = new System.Drawing.Point(222, 351);
            this.buttonGiai.Name = "buttonGiai";
            this.buttonGiai.Size = new System.Drawing.Size(116, 56);
            this.buttonGiai.TabIndex = 4;
            this.buttonGiai.Text = "Giải";
            this.buttonGiai.UseVisualStyleBackColor = true;
            this.buttonGiai.Click += new System.EventHandler(this.buttonGiai_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "a= ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(578, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "c= ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxC.Location = new System.Drawing.Point(648, 133);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 43);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(318, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "b= ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxB.Location = new System.Drawing.Point(388, 133);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 43);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(134, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelKetQua
            // 
            this.labelKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelKetQua.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKetQua.ForeColor = System.Drawing.Color.Blue;
            this.labelKetQua.Location = new System.Drawing.Point(289, 245);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(381, 76);
            this.labelKetQua.TabIndex = 3;
            this.labelKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDong
            // 
            this.buttonDong.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDong.Location = new System.Drawing.Point(454, 351);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(116, 56);
            this.buttonDong.TabIndex = 5;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGiai);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHƯƠNG TRÌNH BẬC 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxA;
        private Button buttonGiai;
        private Label label2;
        private Label label4;
        private TextBox textBoxC;
        private Label label3;
        private TextBox textBoxB;
        private Label label5;
        private Label labelKetQua;
        private Button buttonDong;
    }
}