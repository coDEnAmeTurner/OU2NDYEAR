namespace SLOTMACHINE
{
    public partial class Form1 : Form
    {
        private static int min = 1;
        private static int max = 10;
        private int slot1, slot2, slot3;
        private int score = 0;
        private int scoreIncrement = 100;
        private int scoreDecrement = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            slot1 = rand.Next(min, max + 1);
            slot2 = rand.Next(min, max + 1);
            slot3 = rand.Next(min, max + 1);

            labelSlot1.Text = slot1.ToString();
            labelSlot2.Text = slot2.ToString();
            labelSlot3.Text = slot3.ToString();

            if (slot1 == slot2 && slot2 == slot3)
            {
                score += scoreIncrement;
            }
            else
            {
                if (score > 0) 
                    score -= scoreDecrement;
            }

            labelScore.Text = score.ToString();

        }
    }
}