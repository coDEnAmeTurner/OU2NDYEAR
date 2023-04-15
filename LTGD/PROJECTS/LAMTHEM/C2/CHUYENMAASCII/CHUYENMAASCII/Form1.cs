namespace CHUYENMAASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAsciiToKyTu_Click(object sender, EventArgs e)
        {
            try
            {
                uint ascii = uint.Parse(textBoxAscii.Text);
                char ketqua = (char)ascii;
                labelKetQuaKyTu.Text = ketqua.ToString();

            } catch (FormatException)
            {
                MessageBox.Show("Chua nhap hoac nhap sai gia tri");
            }
        }

        private void buttonKyTuToAscii_Click(object sender, EventArgs e)
        {
            try
            {
                char kytu = char.Parse(textBoxKyTu.Text);
                uint ketqua = kytu;
                labelKetQuaAscii.Text = ketqua.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Chua nhap hoac nhap sai gia tri");
            }
        }
    }
}