using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CACPHEPTOAN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);

                if (radioButton1.Checked)
                    label5.Text = String.Format("{0}", checked(a + b));

                if (radioButton2.Checked)
                    label5.Text = String.Format("{0}", checked(a - b));

                if (radioButton3.Checked)
                    label5.Text = String.Format("{0}", checked(a * b));

                if (radioButton4.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Loi chia cho 0");
                    label5.Text = String.Format("{0:0.##}", a / b);
                }

                if (radioButton5.Checked)
                {
                    if (b == 0)
                        throw new DivideByZeroException("Loi chia cho 0");
                    try
                    {
                        int aInt = int.Parse(textBox1.Text);
                        int bInt = int.Parse(textBox2.Text);
                        label5.Text = String.Format("{0}", a % b);

                    }
                    catch (FormatException) {
                        MessageBox.Show("Loi chia du cho so thuc");
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Nhap thieu so hoac nhap sai kieu du lieu");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Loi tran so");
            }
            catch (DivideByZeroException ex)
            {
                label5.Text = string.Format(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
