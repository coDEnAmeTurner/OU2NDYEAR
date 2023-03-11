namespace TANGBONG
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
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxBall);
            this.Name = "Form1";
            this.Text = "Ball";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBoxBall;
        private System.Windows.Forms.Timer timer1;
    }
}