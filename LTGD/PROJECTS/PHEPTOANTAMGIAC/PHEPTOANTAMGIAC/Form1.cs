namespace PHEPTOANTAMGIAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckCanh_Click(object sender, EventArgs e)
        {
            try
            {
                labelKetQua.Text = TamGiac.isTamGiac(double.Parse(txtBoxA.Text), double.Parse(txtBoxB.Text), 
                    double.Parse(txtBoxC.Text)) ? "La 3 canh cua tam giac" : "Khong la 3 canh cua tam giac";

            }
            catch (FormatException)
            {
                MessageBox.Show("Chua ghi du gia tri hay ghi sai kieu du lieu");
            }

        }

        private void buttonCheckLoai_Click(object sender, EventArgs e)
        {
            TamGiac tg = new TamGiac(double.Parse(txtBoxA.Text), double.Parse(txtBoxB.Text), double.Parse(txtBoxC.Text));
            labelKetQua.Text =  tg.checkTamGiacType().ToString();
        }

        private void buttonDTichChuVi_Click(object sender, EventArgs e)
        {
            TamGiac tg = new TamGiac(double.Parse(txtBoxA.Text), double.Parse(txtBoxB.Text), double.Parse(txtBoxC.Text));
            double S = tg.tinhDienTich();
            labelKetQua.Text = String.Format("CV = {0:0.##}, S = {1:0.##}", tg.tinhChuVi(), tg.tinhDienTich());
        }
    }
}