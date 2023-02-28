namespace CACPHEPTOAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                var aSuccess = double.TryParse(textBox1.Text, out a);
                var bSuccess = double.TryParse(textBox2.Text, out b);
                try
                {
                    if (aSuccess == false || bSuccess== false)
                    {
                        throw new FormatException("a hoặc b là chữ");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                label5.Text = String.Format("{0}", checked(a + b));

            }
            catch (FormatException)
            {
                MessageBox.Show("Chưa nhập đủ số");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Lỗi tràn số");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                var aSuccess = double.TryParse(textBox1.Text, out a);
                var bSuccess = double.TryParse(textBox2.Text, out b);
                try
                {
                    if (aSuccess == false || bSuccess == false)
                    {
                        throw new FormatException("a hoặc b là chữ");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                label5.Text = String.Format("{0}", checked(a - b));

            }
            catch (FormatException)
            {

                MessageBox.Show("Chưa nhập đủ số");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lỗi tràn số");


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                var aSuccess = double.TryParse(textBox1.Text, out a);
                var bSuccess = double.TryParse(textBox2.Text, out b);
                try
                {
                    if (aSuccess == false || bSuccess == false)
                    {
                        throw new FormatException("a hoặc b là chữ");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                label5.Text = String.Format("{0}", checked(a * b));

            }
            catch (FormatException)
            {

                MessageBox.Show("Chưa nhập đủ số");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lỗi tràn số");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                var aSuccess = double.TryParse(textBox1.Text, out a);
                var bSuccess = double.TryParse(textBox2.Text, out b);
                try
                {
                    if (aSuccess == false || bSuccess == false)
                    {
                        throw new FormatException("a hoặc b là chữ");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (b == 0)
                    throw new DivideByZeroException("Lỗi chia cho 0");

                label5.Text = String.Format("{0:0.##}", (double)a / b);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chưa nhập đủ số");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Lỗi tràn số");
            }
            catch (DivideByZeroException ex)
            {
                label5.Text+= ex.Message;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}