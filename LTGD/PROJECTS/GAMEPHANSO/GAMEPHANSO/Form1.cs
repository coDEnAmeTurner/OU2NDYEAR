using GAMEPHANSO;

namespace GAMEPHANSO
{

    public partial class Form1 : Form
    {
        String[] mangDau = { "+", "-", "x", "/" };
        PhanSo kq;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            try
            {
                Random randGen = new Random();
                PhanSo phanso1 = new PhanSo(randGen.Next(10) + 1, randGen.Next(10) + 1);
                PhanSo phanso2 = new PhanSo(randGen.Next(10) + 1, randGen.Next(10) + 1);
                ePhepToan dau = (ePhepToan)randGen.Next((int)ePhepToan.cong, (int)ePhepToan.chia + 1);
                textBoxTu1.Text = phanso1.TuSo.ToString();
                textBoxMau1.Text = phanso1.MauSo.ToString();
                textBoxTu2.Text = phanso2.TuSo.ToString();
                textBoxMau2.Text = phanso2.MauSo.ToString();

                switch (dau)
                {
                    case ePhepToan.cong:
                        kq = PhanSo.cong(phanso1, phanso2);
                        labelDau.Text = mangDau[(int)dau];
                        break;
                    case ePhepToan.tru:
                        kq = PhanSo.tru(phanso1, phanso2);
                        labelDau.Text = mangDau[(int)dau];
                        break;
                    case ePhepToan.nhan:
                        kq = PhanSo.nhan(phanso1, phanso2);
                        labelDau.Text = mangDau[(int)dau];
                        break;
                    case ePhepToan.chia:
                        kq = PhanSo.chia(phanso1, phanso2);
                        labelDau.Text = mangDau[(int)dau];
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

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try {
                if (PhanSo.isBang(kq, new PhanSo(int.Parse(textBoxTu3.Text), int.Parse(textBoxMau3.Text))))
                {
                    labelKetQua.ForeColor = Color.Green;
                    labelKetQua.Text = "Correct";

                }
                else
                {
                    labelKetQua.ForeColor = Color.Green;
                    labelKetQua.Text = "Incorrect";
                }
            }
            
            catch (FormatException)
            {
                MessageBox.Show("Chua nhap ket qua hoac nhap sai data type");
            }
        }
    }
}