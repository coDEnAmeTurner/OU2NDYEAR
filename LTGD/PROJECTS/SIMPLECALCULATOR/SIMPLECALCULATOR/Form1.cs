using System.Text.RegularExpressions;

namespace SIMPLECALCULATOR
{
    enum PhepToan
    {
        Cong, Tru, Nhan, Chia
    }
    public partial class Form1 : Form
    {
        private PhepToan _dau;

        private bool _isCoDau = false;

        private string[] _dauString = { "+", "-", "x", "/" };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            labelHienThi.Text = "";
            _isCoDau = false;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            labelHienThi.Text = labelHienThi.Text.Substring(0, labelHienThi.Text.Length - 1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button realSender = (Button)sender;

            if (_isCoDau)
                return;

            int parseTo;
            if (int.TryParse(realSender.Text, out parseTo) == false)
            {
                switch (realSender.Text)
                {
                    case "+":
                        _dau = PhepToan.Cong;
                        break;
                    case "-":
                        _dau = PhepToan.Tru;
                        break;
                    case "x":
                        _dau = PhepToan.Nhan;
                        break;
                    case "/":
                        _dau = PhepToan.Chia;
                        break;
                    default:
                        _isCoDau= true;
                        break;
                }

            }

            labelHienThi.Text += realSender.Text;
        }

        private void buttonBang_Click(object sender, EventArgs e)
        {
            String input = labelHienThi.Text;
            int idxDau = labelHienThi.Text.IndexOf(_dauString[(int)_dau]);
            double kq = 0;
            try
            {
                if (new Regex(@"\d+([+x/]|[-])\d+").IsMatch(input) == false) //it doesn't accept - as a char
                {
                    throw new FormatException("Sai cach ghi phep toan"); 
                }
                double a = double.Parse(labelHienThi.Text.Substring(0, idxDau));
                double b = double.Parse(labelHienThi.Text.Substring(idxDau + 1));
                switch (_dau)
                {
                    case PhepToan.Cong:
                        kq = a + b; break;
                    case PhepToan.Tru:
                        kq = a - b; break;
                    case PhepToan.Nhan:
                        kq = a * b; break;
                    case PhepToan.Chia:
                        kq = a / b; break;
                    default:
                        break;
                }
                labelHienThi.Text += "=" + kq.ToString();

            }
            catch (FormatException ex)
            {
                if (ex.Message == "")
                    MessageBox.Show("Chưa nhập dữ liệu");
                else
                    MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Chia cho 0");
            }
        }
    }
}