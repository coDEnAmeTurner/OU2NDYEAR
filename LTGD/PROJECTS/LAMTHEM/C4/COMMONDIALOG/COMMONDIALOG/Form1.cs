namespace COMMONDIALOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0.0;
            timerHien.Start();
        }

        private void timerHien_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
                Opacity += 0.1;
            else
                timerHien.Stop();
        }

        private void timerDong_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0.0)
                Opacity -= 0.1;
            else
            {
                timerDong.Stop();
                this.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Opacity > 0.0)
            {
                timerDong.Start();
                e.Cancel = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= string.Empty;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChon1TT_Click(object sender, EventArgs e)
        {
            chon1TT.Filter = "hpp files (*.hpp) |*.hpp| All files (*.*) |*.*";
            chon1TT.FilterIndex = 2;
            if (chon1TT.ShowDialog() == DialogResult.OK)
            {
                foreach (var name in chon1TT.FileNames)
                    richTextBox1.Text += Path.GetFileName(name) + "\n";

            }
        }

        private void buttonChonNhieuTT_Click(object sender, EventArgs e)
        {
            chonNhieuTT.Filter = "hpp files (*.hpp) |*.hpp| All files (*.*) |*.*";
            chonNhieuTT.FilterIndex = 2;
            chonNhieuTT.Multiselect = true; 

            if (chonNhieuTT.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text += "Co " + chonNhieuTT.FileNames.Length + " ten: \n";
                foreach (var name in chonNhieuTT.FileNames)
                    richTextBox1.Text += Path.GetFileName(name) + "\n";

            }
        }

        private void buttonChonThuMuc_Click(object sender, EventArgs e)
        {
            if (chonThuMuc.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text += chonThuMuc.SelectedPath + "\n";
            }
        }

        private void buttonChonMauNen_Click(object sender, EventArgs e)
        {
            if (chonMauNen.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = chonMauNen.Color;
            }

        }

        private void buttonChonMauChu_Click(object sender, EventArgs e)
        {
            if (chonMauChu.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = chonMauChu.Color;
            }
        }

        private void buttonChonFont_Click(object sender, EventArgs e)
        {
            if (chonFont.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = chonFont.Font;

            }
        }
    }
}