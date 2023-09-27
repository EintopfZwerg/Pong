using System.Drawing;

namespace Pong
{
    public partial class Form1 : Form
    {

        int PongX = 150;
        int PongY = 150;
        int MovepongX = 0;
        int MovepongY = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MovePaddel();
            Begrenzung();
            MovePong();
            PaddelKontaktLinks();
            PaddelKontaktRechts();
            Restart();
        }

        void Restart()
        {
            if (pbPong.Right >= 820)
            {
                timer1.Stop();
                lGewonnen.Visible = true;

            }
            if (pbPong.Left <= 0)
            {
                timer1.Stop();
                lVerloren.Visible = true;
            }
        }
        void PaddelKontaktRechts()
        {
            if (pbPaddelGegner.Bounds.IntersectsWith(pbPong.Bounds))
            {
                if (MovepongX == 0)
                {
                    MovepongX = 1;
                }
                else
                {
                    MovepongX = 0;
                }
            }
        }
        void PaddelKontaktLinks()
        {
            if (pbPaddelSpieler.Bounds.IntersectsWith(pbPong.Bounds))
            {
                if (MovepongX == 0)
                {
                    MovepongX = 1;
                }
                else
                {
                    MovepongX = 0;
                }

            }
        }
        void Begrenzung()
        {
            if (PongY >= 430) //Abprallen unten
            {
                MovepongY = 0;
            }
            if (PongY <= 0)  //abprallen oben
            {
                MovepongY = 1;
            }
        }
        void MovePong()
        {
            if (MovepongX == 1)
            {
                PongX++;
                PongX++;
            }
            else
            {
                PongX--;
            }
            if (MovepongY == 1)
            {
                PongY++;
            }
            else
            {
                PongY--;
            }
            pbPong.Top = PongY;
            pbPong.Left = PongX;

        }
        void MovePaddel() // Bewegung des Spieler Paddels
        {

            int y = Location.Y;
            int paddelposition = Cursor.Position.Y - 100 - y;
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