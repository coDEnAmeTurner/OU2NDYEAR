using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYPHOTO
{
    public partial class MyPhotos : Form
    {
        public MyPhotos()
        {
            InitializeComponent();
        }

        private void MyPhotos_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("cat.jpg");
            menuStripMyPhotos.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image |*.jpg|*.png|*.bitmap";
            if (d.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(d.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("cat.jpg");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
