namespace QUAYXUCXAC
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
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.picBoxDice1 = new System.Windows.Forms.PictureBox();
            this.buttonQuay = new System.Windows.Forms.Button();
            this.picBoxDice2 = new System.Windows.Forms.PictureBox();
            this.picBoxDice3 = new System.Windows.Forms.PictureBox();
            this.labelDiem = new System.Windows.Forms.Label();
            this.buttonDong = new System.Windows.Forms.Button();
            this.timerCuonChu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BackColor = System.Drawing.Color.Blue;
            this.labelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTieuDe.ForeColor = System.Drawing.Color.White;
            this.labelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(800, 73);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "   2151010419 - TRẦN LƯU QUỐC TUẤN   ";
            this.labelTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxDice1
            // 
            this.picBoxDice1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDice1.Location = new System.Drawing.Point(99, 103);
            this.picBoxDice1.Name = "picBoxDice1";
            this.picBoxDice1.Size = new System.Drawing.Size(140, 179);
            this.picBoxDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDice1.TabIndex = 1;
            this.picBoxDice1.TabStop = false;
            // 
            // buttonQuay
            // 
            this.buttonQuay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuay.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuay.Location = new System.Drawing.Point(231, 380);
            this.buttonQuay.Name = "buttonQuay";
            this.buttonQuay.Size = new System.Drawing.Size(127, 49);
            this.buttonQuay.TabIndex = 2;
            this.buttonQuay.Text = "Quay số";
            this.buttonQuay.UseVisualStyleBackColor = true;
            this.buttonQuay.Click += new System.EventHandler(this.buttonQuay_Click);
            // 
            // picBoxDice2
            // 
            this.picBoxDice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDice2.Location = new System.Drawing.Point(340, 103);
            this.picBoxDice2.Name = "picBoxDice2";
            this.picBoxDice2.Size = new System.Drawing.Size(140, 179);
            this.picBoxDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDice2.TabIndex = 3;
            this.picBoxDice2.TabStop = false;
            // 
            // picBoxDice3
            // 
            this.picBoxDice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxDice3.Location = new System.Drawing.Point(581, 103);
            this.picBoxDice3.Name = "picBoxDice3";
            this.picBoxDice3.Size = new System.Drawing.Size(140, 179);
            this.picBoxDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDice3.TabIndex = 4;
            this.picBoxDice3.TabStop = false;
            // 
            // labelDiem
            // 
            this.labelDiem.BackColor = System.Drawing.Color.Blue;
            this.labelDiem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDiem.ForeColor = System.Drawing.Color.White;
            this.labelDiem.Location = new System.Drawing.Point(340, 298);
            this.labelDiem.Name = "labelDiem";
            this.labelDiem.Size = new System.Drawing.Size(140, 56);
            this.labelDiem.TabIndex = 6;
            this.labelDiem.Text = "0";
            this.labelDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDong
            // 
            this.buttonDong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDong.ForeColor = System.Drawing.Color.Blue;
            this.buttonDong.Location = new System.Drawing.Point(463, 380);
            this.buttonDong.Name = "buttonDong";
            this.buttonDong.Size = new System.Drawing.Size(127, 49);
            this.buttonDong.TabIndex = 7;
            this.buttonDong.Text = "Đóng";
            this.buttonDong.UseVisualStyleBackColor = true;
            this.buttonDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // timerCuonChu
            // 
            this.timerCuonChu.Enabled = true;
            this.timerCuonChu.Interval = 80;
            this.timerCuonChu.Tick += new System.EventHandler(this.timerCuonChu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDong);
            this.Controls.Add(this.labelDiem);
            this.Controls.Add(this.picBoxDice3);
            this.Controls.Add(this.picBoxDice2);
            this.Controls.Add(this.buttonQuay);
            this.Controls.Add(this.picBoxDice1);
            this.Controls.Add(this.labelTieuDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDice3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTieuDe;
        private PictureBox picBoxDice1;
        private Button buttonQuay;
        private PictureBox picBoxDice2;
        private PictureBox picBoxDice3;
        private Label labelDiem;
        private Button buttonDong;
        private System.Windows.Forms.Timer timerCuonChu;
    }
}