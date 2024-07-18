using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerspeed;

        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            setupGame();
        }

        private void setupGame()
        {
            score = 0;
            ballx = 5;
            bally = 5;
            playerspeed = 13;
           txtScore.Text   = "Score: " + score;

            gametimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256) ,rnd.Next(256) ,rnd.Next(256));
                }
                
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void gameOver(string message)
        {
            isGameOver = true;
            gametimer.Stop();

            txtScore.Text = "score: " +score+ " " +message;
        }




        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;


            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerspeed;
            }
            if (goRight == true && player.Left < 600)
            {
                player.Left += playerspeed;
            }

            ball.Left += ballx;
            ball.Top += bally;

            if (ball.Left < 0 || ball.Left > 700)
            {
                ballx = -ballx;
            }
            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = rnd.Next(5, 13) * -1;
            }
            if (ballx < 0)
            {
                ballx = rnd.Next(5, 13) * -1;
            }
            else
            {
                ballx = rnd.Next(5, 13);
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        bally = -bally;
                        this.Controls.Remove(x);
                    }
                }

            }

if(score==15)
{
    gameOver("You Win.....!!!!");
}
if (ball.Top > 580)
{
    gameOver("You Lose.....!!!!");
}




        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
         



        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

        }
    }
}
