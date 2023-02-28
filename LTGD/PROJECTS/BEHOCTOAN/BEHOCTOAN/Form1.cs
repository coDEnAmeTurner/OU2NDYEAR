namespace BEHOCTOAN
{
    enum IdxPhepToan
    {
        cong = 0,
        tru = 1,
        nhan = 2,
        chia = 3
    }

    public partial class Form1 : Form
    {
        String[] phepToan = new String[] { "+", "-", "x", ":" };
        int max = 9;
        int min = 0;
        int a = 0, b = 0;
        IdxPhepToan op;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSee_Click(object sender, EventArgs e)
        {
            int answer = 0;
            try
            {
                answer = int.Parse(labelAnswer.Text);
                switch (op)
                {
                    case IdxPhepToan.cong:
                        if (answer == a + b)
                        {
                            labelResult.Text = "Đúng!";
                        }
                        else
                        {
                            labelResult.Text = "Sai, kết quả là: " + answer.ToString();
                        }
                        break;
                    case IdxPhepToan.tru:
                        if (answer == a - b)
                        {
                            labelResult.Text = "Đúng!";
                        }
                        else
                        {
                            labelResult.Text = "Sai, kết quả là: " + answer.ToString();
                        }
                        break;
                    case IdxPhepToan.nhan:
                        if (answer == a * b)
                        {
                            labelResult.Text = "Đúng!";
                        }
                        else
                        {
                            labelResult.Text = "Sai, kết quả là: " + answer.ToString();
                        }
                        break;
                    case IdxPhepToan.chia:
                        if (answer == a / b)
                        {
                            labelResult.Text = "Đúng!";
                        }
                        else
                        {
                            labelResult.Text = "Sai, kết quả là: " + answer.ToString();
                        }
                        break;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Chưa nhập đủ số hoặc trả lời không hợp lệ");
            }
            
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            Button realSender = (Button)sender;
            labelAnswer.Text += realSender.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelAnswer.Text = labelAnswer.Text.Substring(0, labelAnswer.Text.Length - 1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Random randGenerator = new Random();
            do
            {
                a = randGenerator.Next(min, max + 1);
                b = randGenerator.Next(min, max + 1);
                op = (IdxPhepToan)randGenerator.Next(0, phepToan.Length);
                if (op != IdxPhepToan.chia || (b != 0 && a % b == 0))
                    break;
            } while (true);

            labelA.Text = a.ToString();
            labelB.Text = b.ToString();
            labelOperator.Text = phepToan[(int)op];
            labelAnswer.Text = "";
            labelResult.Text = "";
        }
    }
}