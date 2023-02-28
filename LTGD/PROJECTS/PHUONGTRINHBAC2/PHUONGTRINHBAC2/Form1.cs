namespace PHUONGTRINHBAC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                if (a == 0 && b == 0)
                    labelKetQua.Text = "Vo nghiem";
                else if (a == 0)
                    labelKetQua.Text = string.Format("Co 1 nghiem: {0:0.##}", c * -1 / b);
                else
                {
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0)
                    {
                        labelKetQua.Text = "Vo nghiem";
                    }
                    else if (delta > 0)
                    {
                        double x1 = (-1 * b - Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-1 * b + Math.Sqrt(delta)) / (2 * a);

                        labelKetQua.Text = string.Format("x1 = {0:0.##} \nx2 = {1:0.##}", x1, x2);
                    }
                    else
                    {
                        double x = -1 * b / (2 * a);
                        labelKetQua.Text = string.Format("1 nghiem x = {0:0.##}", x);
                    }
                }

            } catch (FormatException) {
                MessageBox.Show("Chua nhap du hoac nhap sai gia tri!");
            }
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}