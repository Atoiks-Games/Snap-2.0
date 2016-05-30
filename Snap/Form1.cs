using System;
using System.Windows.Forms;

using CardsLib;
using System.Drawing;

namespace Snap
{
    public partial class Form1 : Form
    {
        private int player1Score;
        private int player2Score;
        private bool cardEql;

        private int card1Num = -1;
        private int card2Num = -2;

        private bool kdown;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Player 1: Button A\nPlayer 2: Button P\n\nPress OK to start");

            card2Num = Dealer.Deal(1)[0].intCardNumber;
            pcCardTwo.Image = cardImgs.Images[card2Num];
            dealTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var kc = e.KeyCode;
            if (kc == Keys.A)
            {
                player1Score += cardEql ? 10 : -20;
            }
            if (kc == Keys.P)
            {
                player2Score += cardEql ? 10 : -20;
            }
            if (cardEql)
            {
                dealTimer.Start();
            }
        }

        private void dealTimer_Tick(object sender, EventArgs e)
        {
            lbPlayer1Score.Text = "Player 1: " + player1Score.ToString();
            lbPlayer2Score.Text = "Player 2: " + player2Score.ToString();

            card1Num = card2Num;
            card2Num = Dealer.Deal(1)[0].intCardNumber;

            pcCardOne.Image = cardImgs.Images[card1Num];
            pcCardTwo.Image = cardImgs.Images[card2Num];

            cardEql = card1Num == card2Num;
            if (cardEql)
                dealTimer.Stop();
        }
    }
}
