using System.Configuration;

namespace BALLGAME
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
            if (picBoxBall.Top <= 0 || picBoxBall.Bottom >= ClientRectangle.Height || 
                (picBoxBall.Bottom >= thanhNgang.Top && picBoxBall.Bounds.IntersectsWith(thanhNgang.Bounds)))
            {
                incrementY *= -1;
            }

            picBoxBall.Left += incrementX;
            picBoxBall.Top += incrementY;

            if (picBoxBall.Bottom >= ClientRectangle.Height)
            {
                timer1.Stop();
                MessageBox.Show("Ban da thua!");
                picBoxBall.Location = new Point(269, 158);
                timer1.Start();
                return;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    thanhNgang.Left += 20;
                    break;
                case Keys.Left:
                    thanhNgang.Left -= 20;
                    break;
                default:
                    break;
            }


        }
    }
}