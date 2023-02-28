namespace SLOTMACHINE
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
            this.labelSlot1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSlot2 = new System.Windows.Forms.Label();
            this.labelSlot3 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSlot1
            // 
            this.labelSlot1.BackColor = System.Drawing.SystemColors.Control;
            this.labelSlot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSlot1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSlot1.ForeColor = System.Drawing.Color.Blue;
            this.labelSlot1.Location = new System.Drawing.Point(12, 33);
            this.labelSlot1.Name = "labelSlot1";
            this.labelSlot1.Size = new System.Drawing.Size(212, 120);
            this.labelSlot1.TabIndex = 0;
            this.labelSlot1.Text = "0";
            this.labelSlot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(183, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSlot2
            // 
            this.labelSlot2.BackColor = System.Drawing.SystemColors.Control;
            this.labelSlot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSlot2.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSlot2.ForeColor = System.Drawing.Color.Blue;
            this.labelSlot2.Location = new System.Drawing.Point(251, 33);
            this.labelSlot2.Name = "labelSlot2";
            this.labelSlot2.Size = new System.Drawing.Size(212, 120);
            this.labelSlot2.TabIndex = 2;
            this.labelSlot2.Text = "0";
            this.labelSlot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSlot3
            // 
            this.labelSlot3.BackColor = System.Drawing.SystemColors.Control;
            this.labelSlot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSlot3.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSlot3.ForeColor = System.Drawing.Color.Blue;
            this.labelSlot3.Location = new System.Drawing.Point(490, 33);
            this.labelSlot3.Name = "labelSlot3";
            this.labelSlot3.Size = new System.Drawing.Size(212, 120);
            this.labelSlot3.TabIndex = 3;
            this.labelSlot3.Text = "0";
            this.labelSlot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScore.ForeColor = System.Drawing.Color.Red;
            this.labelScore.Location = new System.Drawing.Point(12, 174);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(685, 57);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(426, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 52);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelSlot3);
            this.Controls.Add(this.labelSlot2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSlot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Random Number";
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelSlot1;
        private Button button1;
        private Label labelSlot2;
        private Label labelSlot3;
        private Label labelScore;
        private Button button2;
    }
}