namespace COMBOBOX
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
            this.txtBxChuoi = new System.Windows.Forms.TextBox();
            this.cmbBxChonMau = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.lstBxTrai = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBxPhai = new System.Windows.Forms.ListBox();
            this.buttonQuaPhai = new System.Windows.Forms.Button();
            this.buttonQuaTrai = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập 1 chuỗi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBxChuoi
            // 
            this.txtBxChuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBxChuoi.Location = new System.Drawing.Point(12, 51);
            this.txtBxChuoi.Name = "txtBxChuoi";
            this.txtBxChuoi.Size = new System.Drawing.Size(224, 29);
            this.txtBxChuoi.TabIndex = 1;
            // 
            // cmbBxChonMau
            // 
            this.cmbBxChonMau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBxChonMau.FormattingEnabled = true;
            this.cmbBxChonMau.Location = new System.Drawing.Point(335, 51);
            this.cmbBxChonMau.Name = "cmbBxChonMau";
            this.cmbBxChonMau.Size = new System.Drawing.Size(176, 29);
            this.cmbBxChonMau.TabIndex = 2;
            this.cmbBxChonMau.SelectedIndexChanged += new System.EventHandler(this.cmbBxChonMau_SelectedIndexChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInsert.ForeColor = System.Drawing.Color.Blue;
            this.buttonInsert.Location = new System.Drawing.Point(12, 86);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(80, 30);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // lstBxTrai
            // 
            this.lstBxTrai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxTrai.FormattingEnabled = true;
            this.lstBxTrai.ItemHeight = 21;
            this.lstBxTrai.Location = new System.Drawing.Point(12, 122);
            this.lstBxTrai.Name = "lstBxTrai";
            this.lstBxTrai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBxTrai.Size = new System.Drawing.Size(224, 319);
            this.lstBxTrai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(335, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn màu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstBxPhai
            // 
            this.lstBxPhai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBxPhai.FormattingEnabled = true;
            this.lstBxPhai.ItemHeight = 21;
            this.lstBxPhai.Location = new System.Drawing.Point(335, 122);
            this.lstBxPhai.Name = "lstBxPhai";
            this.lstBxPhai.Size = new System.Drawing.Size(224, 319);
            this.lstBxPhai.TabIndex = 6;
            // 
            // buttonQuaPhai
            // 
            this.buttonQuaPhai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuaPhai.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuaPhai.Location = new System.Drawing.Point(249, 147);
            this.buttonQuaPhai.Name = "buttonQuaPhai";
            this.buttonQuaPhai.Size = new System.Drawing.Size(80, 30);
            this.buttonQuaPhai.TabIndex = 7;
            this.buttonQuaPhai.Text = "==>";
            this.buttonQuaPhai.UseVisualStyleBackColor = true;
            this.buttonQuaPhai.Click += new System.EventHandler(this.buttonQuaPhai_Click);
            // 
            // buttonQuaTrai
            // 
            this.buttonQuaTrai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuaTrai.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuaTrai.Location = new System.Drawing.Point(249, 199);
            this.buttonQuaTrai.Name = "buttonQuaTrai";
            this.buttonQuaTrai.Size = new System.Drawing.Size(80, 30);
            this.buttonQuaTrai.TabIndex = 8;
            this.buttonQuaTrai.Text = "<==";
            this.buttonQuaTrai.UseVisualStyleBackColor = true;
            this.buttonQuaTrai.Click += new System.EventHandler(this.buttonQuaTrai_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.ForeColor = System.Drawing.Color.Blue;
            this.buttonRemove.Location = new System.Drawing.Point(249, 250);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(80, 30);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.ForeColor = System.Drawing.Color.Blue;
            this.buttonClearAll.Location = new System.Drawing.Point(249, 300);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(80, 30);
            this.buttonClearAll.TabIndex = 10;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.Blue;
            this.buttonExit.Location = new System.Drawing.Point(249, 348);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 30);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 471);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonQuaTrai);
            this.Controls.Add(this.buttonQuaPhai);
            this.Controls.Add(this.lstBxPhai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBxTrai);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.cmbBxChonMau);
            this.Controls.Add(this.txtBxChuoi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBxChuoi;
        private ComboBox cmbBxChonMau;
        private Button buttonInsert;
        private ListBox lstBxTrai;
        private Label label2;
        private ListBox lstBxPhai;
        private Button buttonQuaPhai;
        private Button buttonQuaTrai;
        private Button buttonRemove;
        private Button buttonClearAll;
        private Button buttonExit;
    }
}