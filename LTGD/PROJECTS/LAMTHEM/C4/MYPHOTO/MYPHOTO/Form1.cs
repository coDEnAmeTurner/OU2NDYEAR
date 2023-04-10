namespace MYPHOTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPhotos f = new MyPhotos();
            f.MdiParent = this;
            f.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var child in MdiChildren) {
                child.Close();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}