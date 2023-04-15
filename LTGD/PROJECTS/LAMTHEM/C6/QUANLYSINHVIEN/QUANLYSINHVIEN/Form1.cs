namespace QUANLYSINHVIEN
{
    public partial class Form1 : Form
    {
        private List<SinhVien> dsSV = new List<SinhVien>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newSV = new SinhVien();
            newSV.MSSV = txtBoxMSSV.Text;
            newSV.Ho = textBoxHo.Text;
            newSV.Ten = textBoxTen.Text;
            dsSV.Add(newSV);
            txtBoxMSSV.Text = string.Empty;
            textBoxHo.Text = string.Empty;
            textBoxTen.Text = string.Empty;
        }

        private void buttonHienThi_Click(object sender, EventArgs e)
        {
            foreach(var s in dsSV) {
                richTextBox1.Text += string.Format("MSSV: {0}\nHo: {1}\nTen: {2}\n\n", s.MSSV, s.Ho, s.Ten);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var found = dsSV.Find(sv => sv.MSSV == textBoxTimMSSV.Text);
            if (found != null)
            {
                richTextBox1.Text = null;
                richTextBox1.Text += string.Format("MSSV: {0}\nHo: {1}\nTen: {2}\n\n", found.MSSV, found.Ho, found.Ten);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var found = dsSV.FindAll(sv => sv.Ten == textBoxTimTen.Text);
            if (found != null)
            {
                richTextBox1.Text = null;
                foreach (var sv in found)
                {
                    richTextBox1.Text += string.Format("MSSV: {0}\nHo: {1}\nTen: {2}\n\n", sv.MSSV, sv.Ho, sv.Ten);
                }

            }
        }

        private void buttonSapTen_Click(object sender, EventArgs e)
        {
            dsSV.Sort((x, y) =>
            {
                return x.Ten.CompareTo(y.Ten);
            });
        }
    }
}