using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasicCardGameWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playGamebtn_Click(object sender, EventArgs e)
        {
            Player player1 = new Player("Harry");
            Player player2 = new Player("Der Jo");

            Game game = new Game();
            game.playGame(player1, player2);

            if (game.getPlayer1CardValue() > game.getPlayer2CardValue())
            {
                label3.Text = "The winner is: \n" + player1.Name + "!";
            }
            else if (game.getPlayer2CardValue() > game.getPlayer1CardValue())
            {
                label3.Text = "The winner is: \n" + player2.Name + "!";
            }
            else
            {
                label3.Text = "No one is the winner";
            }

            label4.Text = player1.Name + ":\n" + game.getPlayer1CardName();
            label5.Text = player2.Name + ":\n" + game.getPlayer2CardName();

            string fileName1 = game.getPlayer1Card().ToString();
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\", fileName1 + ".png");
            string fileName2 = game.getPlayer2Card().ToString();
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\", fileName2 + ".png");

            pictureBox1.Image = Image.FromFile(path1);
            pictureBox2.Image = Image.FromFile(path2);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
