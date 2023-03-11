namespace QUAYXUCXAC
{
    public partial class Form1 : Form
    {
        private int dice1;
        private int dice2;
        private int dice3;
        private static int min = 1;
        private static int max = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void timerCuonChu_Tick(object sender, EventArgs e)
        {
            labelTieuDe.Text = labelTieuDe.Text.Substring(1) + labelTieuDe.Text.Substring(0, 1);
        }

        private void buttonQuay_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();
            String debugPath = Application.StartupPath;
            dice1 = randGen.Next(min, max + 1);
            dice2 = randGen.Next(min, max + 1);
            dice3 = randGen.Next(min, max + 1);
            labelDiem.Text = (dice1 + dice2 + dice3).ToString();
            picBoxDice1.Image = Image.FromFile(debugPath + "/dice" + dice1 + ".png");
            picBoxDice2.Image = Image.FromFile(debugPath + "/dice" + dice2 + ".png");
            picBoxDice3.Image = Image.FromFile(debugPath + "/dice" + dice3 + ".png");
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}