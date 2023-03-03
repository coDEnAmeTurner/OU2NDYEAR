namespace PHEPTOANPHANSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            Button realSender = (Button)sender;
            try
            {
                PhanSo phanso1 = new PhanSo(int.Parse(textBoxTu1.Text), int.Parse(textBoxMau1.Text));
                PhanSo phanso2 = new PhanSo(int.Parse(textBoxTu2.Text), int.Parse(textBoxMau2.Text));
                String dau = realSender.Text;
                PhanSo kq;

                switch (dau)
                {
                    case "+":
                        kq = phanso1.cong(phanso2);
                        labelDau.Text = dau;
                        textBoxTu3.Text = kq.TuSo.ToString();
                        textBoxMau3.Text = kq.MauSo.ToString();
                        break;
                    case "-":
                        kq = phanso1.tru(phanso2);
                        labelDau.Text = dau;
                        textBoxTu3.Text = kq.TuSo.ToString();
                        textBoxMau3.Text = kq.MauSo.ToString();
                        break;
                    case "x":
                        kq = phanso1.nhan(phanso2);
                        labelDau.Text = dau;
                        textBoxTu3.Text = kq.TuSo.ToString();
                        textBoxMau3.Text = kq.MauSo.ToString();
                        break;
                    case "/":
                        kq = phanso1.chia(phanso2);
                        labelDau.Text = dau;
                        textBoxTu3.Text = kq.TuSo.ToString();
                        textBoxMau3.Text = kq.MauSo.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Chua nhap du hoac nhap sai kieu du lieu");
            }

        }
    }
}