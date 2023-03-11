namespace QUANLYNHANVIEN
{
    public partial class Form1 : Form
    {
        public static Form1 thisForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if(richTextBoxTen.Text == "" || richTextBoxMatKhau.Text != "admin")
                this.Close();
            else
            {
                Form2 form2 = new Form2();
                thisForm = this;
                this.Hide();
                form2.Show();
            }
        }
    }
}