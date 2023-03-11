namespace HINHTRON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTinh_Click(object sender, EventArgs e)
        {
            HinhTron h = new HinhTron(new Diem(double.Parse(rTxtBoxTamX.Text), double.Parse(rTxtBoxTamY.Text)), double.Parse(rTxtBoxBanKinh.Text));
            Diem p = new Diem(double.Parse(rTxtBoxDiemX.Text), double.Parse(rTxtBoxDiemY.Text));

            labelViTriDiem.Text = String.Format("{0}", h.ktViTriDiem(p));
            labelDienTich.Text = String.Format("{0:0.##}", h.tinhS());
            labelChuVi.Text = String.Format("{0:0.##}", h.tinhCV());
        }
    }
}