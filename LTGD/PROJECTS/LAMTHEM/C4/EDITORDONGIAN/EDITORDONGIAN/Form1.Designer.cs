namespace EDITORDONGIAN
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
            this.lstBxFontList = new System.Windows.Forms.ListBox();
            this.rchTxtBxContent = new System.Windows.Forms.RichTextBox();
            this.cmbBxSize = new System.Windows.Forms.ComboBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.panelResultColor = new System.Windows.Forms.Panel();
            this.hScrollBarRed = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSlash = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.hScrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font List:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstBxFontList
            // 
            this.lstBxFontList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxFontList.FormattingEnabled = true;
            this.lstBxFontList.ItemHeight = 21;
            this.lstBxFontList.Location = new System.Drawing.Point(12, 36);
            this.lstBxFontList.Name = "lstBxFontList";
            this.lstBxFontList.Size = new System.Drawing.Size(206, 361);
            this.lstBxFontList.TabIndex = 1;
            this.lstBxFontList.SelectedIndexChanged += new System.EventHandler(this.lstBxFontList_SelectedIndexChanged);
            // 
            // rchTxtBxContent
            // 
            this.rchTxtBxContent.Location = new System.Drawing.Point(235, 36);
            this.rchTxtBxContent.Name = "rchTxtBxContent";
            this.rchTxtBxContent.Size = new System.Drawing.Size(319, 364);
            this.rchTxtBxContent.TabIndex = 2;
            this.rchTxtBxContent.Text = "";
            this.rchTxtBxContent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rchTxtBxContent_MouseUp);
            // 
            // cmbBxSize
            // 
            this.cmbBxSize.FormattingEnabled = true;
            this.cmbBxSize.Location = new System.Drawing.Point(59, 429);
            this.cmbBxSize.Name = "cmbBxSize";
            this.cmbBxSize.Size = new System.Drawing.Size(63, 23);
            this.cmbBxSize.TabIndex = 3;
            this.cmbBxSize.SelectedIndexChanged += new System.EventHandler(this.cmbBxSize_SelectedIndexChanged);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(128, 427);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(26, 25);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // panelResultColor
            // 
            this.panelResultColor.Location = new System.Drawing.Point(478, 412);
            this.panelResultColor.Name = "panelResultColor";
            this.panelResultColor.Size = new System.Drawing.Size(76, 60);
            this.panelResultColor.TabIndex = 5;
            // 
            // hScrollBarRed
            // 
            this.hScrollBarRed.Location = new System.Drawing.Point(272, 412);
            this.hScrollBarRed.Maximum = 255;
            this.hScrollBarRed.Name = "hScrollBarRed";
            this.hScrollBarRed.Size = new System.Drawing.Size(203, 20);
            this.hScrollBarRed.TabIndex = 0;
            this.hScrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRed_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Content:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSlash
            // 
            this.buttonSlash.Location = new System.Drawing.Point(160, 427);
            this.buttonSlash.Name = "buttonSlash";
            this.buttonSlash.Size = new System.Drawing.Size(26, 25);
            this.buttonSlash.TabIndex = 8;
            this.buttonSlash.Text = "/";
            this.buttonSlash.UseVisualStyleBackColor = true;
            this.buttonSlash.Click += new System.EventHandler(this.buttonSlash_Click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(192, 427);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(26, 25);
            this.buttonU.TabIndex = 9;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonU_Click);
            // 
            // hScrollBarGreen
            // 
            this.hScrollBarGreen.Location = new System.Drawing.Point(272, 432);
            this.hScrollBarGreen.Maximum = 255;
            this.hScrollBarGreen.Name = "hScrollBarGreen";
            this.hScrollBarGreen.Size = new System.Drawing.Size(203, 20);
            this.hScrollBarGreen.TabIndex = 10;
            this.hScrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGreen_Scroll);
            // 
            // hScrollBarBlue
            // 
            this.hScrollBarBlue.Location = new System.Drawing.Point(272, 452);
            this.hScrollBarBlue.Maximum = 255;
            this.hScrollBarBlue.Name = "hScrollBarBlue";
            this.hScrollBarBlue.Size = new System.Drawing.Size(203, 20);
            this.hScrollBarBlue.TabIndex = 11;
            this.hScrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarBlue_Scroll);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(235, 412);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(34, 20);
            this.panelRed.TabIndex = 6;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(235, 432);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(34, 20);
            this.panelGreen.TabIndex = 7;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(235, 452);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(34, 20);
            this.panelBlue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 488);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.hScrollBarBlue);
            this.Controls.Add(this.hScrollBarGreen);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonSlash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hScrollBarRed);
            this.Controls.Add(this.panelResultColor);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.cmbBxSize);
            this.Controls.Add(this.rchTxtBxContent);
            this.Controls.Add(this.lstBxFontList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ListBox lstBxFontList;
        private RichTextBox rchTxtBxContent;
        private ComboBox cmbBxSize;
        private Button buttonB;
        private Panel panelResultColor;
        private HScrollBar hScrollBarRed;
        private Label label2;
        private Label label3;
        private Button buttonSlash;
        private Button buttonU;
        private HScrollBar hScrollBarGreen;
        private HScrollBar hScrollBarBlue;
        private Panel panelRed;
        private Panel panelGreen;
        private Panel panelBlue;
    }
}