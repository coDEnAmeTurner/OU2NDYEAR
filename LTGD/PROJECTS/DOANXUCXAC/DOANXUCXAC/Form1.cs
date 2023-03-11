namespace DOANXUCXAC
{
    public partial class Form1 : Form
    {
        private string debugPath = Application.StartupPath;
        private int min = 1;
        private int max = 6;
        private int randDice;
        private int pickedDice;
        private int lanDoan;
        private int lanThang;
        private int lanThua;

        public Form1()
        {
            InitializeComponent();
            lanDoan = 0;
            lanThang = 0;
            lanThua = 0;
        }

        private void buttonChon1_Click(object sender, EventArgs e)
        {
            pickedDice = int.Parse(((Button)sender).Text);
            picBoxChon.Image = Image.FromFile(debugPath + "/Dice" + ((Button)sender).Text + ".png");
        }

        private void buttonQuay_Click(object sender, EventArgs e)
        {
            try
            {
                if (pickedDice == 0)
                {
                    throw new Exception("Chưa chọn dice");
                }

                Random randGen = new Random();
                randDice = randGen.Next(min, max + 1);
                lanDoan++;
                picBoxNgauNhien.Image = Image.FromFile(debugPath + "/Dice" + randDice + ".png");
                if (randDice == pickedDice)
                {
                    lanThang++;
                    listBoxThongKe.Items.Add(String.Format("Thắng (Đoán {0} ra {1})", pickedDice, randDice));
                }
                else
                {
                    lanThua++;
                    listBoxThongKe.Items.Add(String.Format("Thua (Đoán {0} ra {1})", pickedDice, randDice));
                }
                labelLanDoan.Text = String.Format("{0}", lanDoan);
                labelLanThang.Text = String.Format("{0} ({1:0.##}%)", lanThang, lanThang * 1.0 / lanDoan * 100);
                labelLanThua.Text = String.Format("{0} ({1:0.##}%)", lanThua, lanThua * 1.0 / lanDoan * 100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            picBoxChon.Image = null;
            picBoxNgauNhien.Image = null;
            listBoxThongKe.Items.Clear();
            labelLanDoan.Text = null;
            labelLanThua.Text = null;
            labelLanThang.Text = null;
            lanThang= 0;
            lanThua= 0;
            lanDoan = 0;
            pickedDice = 0;
            randDice = 0;

        }
    }
}