namespace THONGKE
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
            this.labelMang = new System.Windows.Forms.Label();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.labelThongKe = new System.Windows.Forms.Label();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng số nguyên: ";
            // 
            // labelMang
            // 
            this.labelMang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMang.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMang.Location = new System.Drawing.Point(205, 96);
            this.labelMang.Name = "labelMang";
            this.labelMang.Size = new System.Drawing.Size(564, 47);
            this.labelMang.TabIndex = 1;
            this.labelMang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonThongKe.Location = new System.Drawing.Point(393, 12);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(207, 67);
            this.buttonThongKe.TabIndex = 2;
            this.buttonThongKe.Text = "Thống Kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // labelThongKe
            // 
            this.labelThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThongKe.Location = new System.Drawing.Point(21, 156);
            this.labelThongKe.Name = "labelThongKe";
            this.labelThongKe.Size = new System.Drawing.Size(748, 269);
            this.labelThongKe.TabIndex = 3;
            // 
            // txtBoxN
            // 
            this.txtBoxN.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxN.Location = new System.Drawing.Point(86, 20);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(195, 50);
            this.txtBoxN.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.labelThongKe);
            this.Controls.Add(this.buttonThongKe);
            this.Controls.Add(this.labelMang);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label labelMang;
        private Button buttonThongKe;
        private Label labelThongKe;
        private TextBox txtBoxN;
    }
}