using System.Collections;

namespace THONGKE
{
    public partial class Form1 : Form
    {
        private Random randGen = new Random();

        private int n;

        private List<int> mangInt = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            n = int.Parse(txtBoxN.Text);
            for (int i = 0; i < n; i++) mangInt.Add(randGen.Next(0, 101));
            labelMang.Text = string.Join(",", mangInt.ToArray());
            labelThongKe.Text += string.Format("Tong cac so chan: {0}\n", tinhTongChan());
            labelThongKe.Text += string.Format("Tong cac so le: {0}\n", tinhTongLe());
            labelThongKe.Text += string.Format("Trung binh cong: {0:0.##}\n", tinhAvg());
            labelThongKe.Text += string.Format("So so nguyen to: {0}\n", demSNT());
        }

        private int tinhTongChan()
        {
            int sum = 0;
            foreach (var so in mangInt)
            {
                sum += (so % 2 == 0)?so:0;
            }
            return sum;
        }

        private int tinhTongLe()
        {
            int sum = 0;
            foreach (var so in mangInt)
            {
                sum += (so % 2 != 0) ? so : 0;
            }
            return sum;
            
        }

        private double tinhAvg()
        {
            return mangInt.Average();
        }

        private int demSNT()
        {
            int count = 0;
            foreach (var so in mangInt)
            {
                count += isPrime(so) ? 1 : 0;
            }
            return count;
        }

        private Boolean isPrime(int x)
        {
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}