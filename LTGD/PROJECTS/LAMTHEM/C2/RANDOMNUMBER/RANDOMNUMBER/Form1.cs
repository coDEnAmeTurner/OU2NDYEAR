namespace RANDOMNUMBER
{
    public partial class Form1 : Form
    {
        private int lowerBound = 1;
        private int upperBound = 6;
        private int score = 0;
        private int scoreAmount = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            label3.Text = rand.Next(lowerBound, upperBound + 1).ToString();
            label2.Text = rand.Next(lowerBound, upperBound + 1).ToString();
            label1.Text = rand.Next(lowerBound, upperBound + 1).ToString();
            int sum = int.Parse(label1.Text) + int.Parse(label2.Text) + int.Parse(label3.Text);

            if (radioButton1.Checked == true)
            {
                if (3 <= sum && sum <= 10)
                    score += scoreAmount;
                else
                    score -= scoreAmount;
            }

            if (radioButton2.Checked == true)
            {
                if (11 <= sum && sum <= 18)
                    score += scoreAmount;
                else
                    score -= scoreAmount;
            }
            
            label5.Text = score.ToString();
        }
    }
}