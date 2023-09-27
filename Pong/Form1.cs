namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePaddel();
            MovePong();
        }
        void MovePong()
        {

        }
        void MovePaddel() // Bewegung des Spieler Paddels
        {

            int i = Location.Y;
            int paddelposition = Cursor.Position.Y - 100 - i;
            if (paddelposition <= 0)
            {
                pbPaddelSpieler.Top = 0;
            }
            else if (paddelposition >= 320)
            {
                pbPaddelSpieler.Top = 320;
            }
            else
            {
                pbPaddelSpieler.Top = paddelposition;
            }
        }
    }
}