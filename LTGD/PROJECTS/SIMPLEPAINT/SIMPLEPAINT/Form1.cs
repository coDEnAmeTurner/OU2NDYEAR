namespace SIMPLEPAINT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawByMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawByMouse form = new DrawByMouse();
            form.MdiParent = this;
            form.Show();
        }
    }
}