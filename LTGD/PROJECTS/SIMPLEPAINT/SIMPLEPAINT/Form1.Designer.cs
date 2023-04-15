namespace SIMPLEPAINT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawByMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawByMouseToolStripMenuItem,
            this.drawByToolStripMenuItem,
            this.drawImageToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // drawByMouseToolStripMenuItem
            // 
            this.drawByMouseToolStripMenuItem.Name = "drawByMouseToolStripMenuItem";
            this.drawByMouseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawByMouseToolStripMenuItem.Text = "Draw By Mouse";
            this.drawByMouseToolStripMenuItem.Click += new System.EventHandler(this.drawByMouseToolStripMenuItem_Click);
            // 
            // drawByToolStripMenuItem
            // 
            this.drawByToolStripMenuItem.Name = "drawByToolStripMenuItem";
            this.drawByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawByToolStripMenuItem.Text = "Draw Text";
            // 
            // drawImageToolStripMenuItem
            // 
            this.drawImageToolStripMenuItem.Name = "drawImageToolStripMenuItem";
            this.drawImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drawImageToolStripMenuItem.Text = "Draw Image";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem drawByMouseToolStripMenuItem;
        private ToolStripMenuItem drawByToolStripMenuItem;
        private ToolStripMenuItem drawImageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}