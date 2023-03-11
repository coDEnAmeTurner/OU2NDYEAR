namespace TANGBONG
{
    public partial class Form1 : Form
    {
        private int incrementX = 7;
        private int incrementY = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picBoxBall.Left <= 0 || picBoxBall.Right >= ClientRectangle.Width)
            {
                incrementX *= -1;
            }
            if (picBoxBall.Top <= 0 || picBoxBall.Bottom >= ClientRectangle.Height)
            {
                incrementY *= -1;
            }

            picBoxBall.Left += incrementX;
            picBoxBall.Top += incrementY;
        }
    }
}