namespace BALLGAME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBoxBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.thanhNgang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxBall
            // 
            this.picBoxBall.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBall.Image")));
            this.picBoxBall.Location = new System.Drawing.Point(269, 158);
            this.picBoxBall.Name = "picBoxBall";
            this.picBoxBall.Size = new System.Drawing.Size(81, 79);
            this.picBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBall.TabIndex = 0;
            this.picBoxBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // thanhNgang
            // 
            this.thanhNgang.BackColor = System.Drawing.Color.Blue;
            this.thanhNgang.Location = new System.Drawing.Point(350, 383);
            this.thanhNgang.Name = "thanhNgang";
            this.thanhNgang.Size = new System.Drawing.Size(111, 32);
            this.thanhNgang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(562, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 291);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thanhNgang);
            this.Controls.Add(this.picBoxBall);
            this.Name = "Form1";
            this.Text = "Ball";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBoxBall;
        private System.Windows.Forms.Timer timer1;
        private Panel thanhNgang;
        private Label label1;
        private TextBox textBox1;
    }
}