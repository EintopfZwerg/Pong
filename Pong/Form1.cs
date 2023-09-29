using System.Windows.Forms;
using System;
namespace Pong
{
    public partial class Form1 : Form
    {

        int PongX = 150;
        int PongY = 150;
        int MovepongX = 0;
        int MovepongY = 1;
        int paddelposition = 150;
        int Maus = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Maus == 1)
            {
                MovePaddel();
            }
            MoveGegner();
            MoveGegner();
            Begrenzung();
            MovePong();
            PaddelKontaktLinks();
            PaddelKontaktRechts();
            Ende();
        }

        void Restart()
        {
            timer1.Enabled = true;
            lRestart.Visible = false;
            lGewonnen.Visible = false;
            lVerloren.Visible = false;
            PongX = 410;
            PongY = 250;
            Random r = new Random();

            MovepongX = r.Next(0, 2);
            MovepongY = r.Next(0, 2);


        }
        void MoveGegner()
        {
            if (PongY >= pbPaddelGegner.Top)
            {
                if (pbPaddelGegner.Top <= 0)
                {
                    return;
                }
                pbPaddelGegner.Top++;
                return;
            }
            if (PongY <= pbPaddelGegner.Bottom)
            {
                //if (pbPaddelGegner.Bottom >= 380)
                //{
                //    return;
                //}
                pbPaddelGegner.Top--;
                return;
            }
        }
        void Ende()
        {
            if (pbPong.Right >= 820)
            {
                timer1.Enabled = false;
                lGewonnen.Visible = true;
                lRestart.Visible = true;
            }
            if (pbPong.Left <= 0)
            {
                timer1.Enabled = false;
                lVerloren.Visible = true;
                lRestart.Visible = true;
            }


        }
        void PaddelKontaktRechts()
        {
            {

                if (pbPong.Bounds.IntersectsWith(pbPaddelGegner.Bounds))
                {
                    // Ändern Sie den Abprallrichtung des Balls
                    int paddelRand = pbPaddelGegner.Top + (pbPaddelGegner.Left / 2);
                    if (PongY <= paddelRand)
                    {
                        // Der Ball prallt nahe der linken Kante des Paddels ab
                        MovepongX = 0;
                        MovepongY = 0;
                        return;
                    }
                    else
                    {
                        // Der Ball prallt nahe der rechten Kante des Paddels ab
                        MovepongX = 0;
                        MovepongY = 1;
                        return;
                    }
                }
            }
        }
        void PaddelKontaktLinks()
        {

            if (pbPong.Bounds.IntersectsWith(pbPaddelSpieler.Bounds))
            {
                // Ändern Sie den Abprallrichtung des Balls
                int paddelRand = pbPaddelSpieler.Top + (pbPaddelSpieler.Left / 2);
                if (PongY <= paddelRand)
                {
                    // Der Ball prallt nahe der linken Kante des Paddels ab
                    MovepongX = 1;
                    MovepongY = 0;
                    return;
                }
                else
                {
                    // Der Ball prallt nahe der rechten Kante des Paddels ab
                    MovepongX = 1;
                    MovepongY = 1;
                    return;
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
                PongX++;
            }
            else
            {
                PongX--;
                PongX--;
                PongX--;
            }
            if (MovepongY == 1)
            {
                PongY++;
                PongY++;
                PongY++;
            }
            else
            {
                PongY--;
                PongY--;
                PongY--;
            }
            pbPong.Top = PongY;
            pbPong.Left = PongX;

        }
        void MovePaddel() // Bewegung des Spieler Paddels
        {

            int y = Location.Y;
            paddelposition = Cursor.Position.Y - pbPaddelSpieler.Left - y - 80;
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Restart();
                return;
            //}
            //if (e.KeyCode == Keys.Shift)
            //{
            //    pbPaddelSpieler.Top -= 10;
            //}
        }
    }
}