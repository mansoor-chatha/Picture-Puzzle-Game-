

PROJECT
<br>
Picture Puzzle_Game
<br>
Author 
<br>
            Mansoor Chatha
	    <br>
Language 
<br>
            C#




![mm](https://github.com/user-attachments/assets/d3922c6e-353c-4b1c-b87c-ec9e2760649b)


using System;
<br>
using System.Collections.Generic;
<br>
using System.ComponentModel;
<br>
using System.Data;
<br>
using System.Drawing;
<br>
using System.Linq;
<br>
using System.Text;
<br>
using System.Threading.Tasks;
<br>
using System.Timers;
<br>
using System.Windows.Forms;

namespace Puzzle_Game
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer; 
            int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void swap(PictureBox picA,PictureBox picB)
        {
            PictureBox picT = new PictureBox();
            picT.Image = picA.Image;
            picT.Tag = picA.Tag;
            picA.Image = picB.Image;
            picA.Tag = picB.Tag;
            picB.Image = picT.Image;
            picB.Tag = picT.Tag;
        }

      

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            if(pictureBox10.Tag == "0")
            {
                swap(pictureBox9, pictureBox10);
            }
            else if (pictureBox8.Tag == "0")
            {
                swap(pictureBox9, pictureBox8);
            }
            else if (pictureBox6.Tag == "0")
            {
                swap(pictureBox9, pictureBox6);
            }

            timer.Start();
            check();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Tag == "0")
            {
                swap(pictureBox6, pictureBox5);
            }
            else if (pictureBox3.Tag == "0")
            {
                swap(pictureBox6, pictureBox3);
            }
            else if (pictureBox9.Tag == "0")
            {
                swap(pictureBox6, pictureBox9);
            }
            
           check();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag == "0")
            {
                swap(pictureBox3, pictureBox2);
            }
            else if (pictureBox6.Tag == "0")
            {
                swap(pictureBox3, pictureBox6);
            }
            
            check();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == "0")
            {
                swap(pictureBox2, pictureBox1);
            }
            else if (pictureBox3.Tag == "0")
            {
                swap(pictureBox2, pictureBox3);
            }
            else if (pictureBox5.Tag == "0")
            {
                swap(pictureBox2, pictureBox5);
            }
            check();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pictureBox2.Tag == "0")
            {
                swap(pictureBox1, pictureBox2);
            }
            else if (pictureBox4.Tag == "0")
            {
                swap(pictureBox1, pictureBox4);
            }
            
           
         check();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag == "0")
            {
                swap(pictureBox4, pictureBox1);
            }
            else if (pictureBox5.Tag == "0")
            {
                swap(pictureBox4, pictureBox5);
            }
            else if (pictureBox7.Tag == "0")
            {
                swap(pictureBox4, pictureBox7);
            }
            
           check();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "0")
            {
                swap(pictureBox5, pictureBox4);
            }
            else if (pictureBox2.Tag == "0")
            {
                swap(pictureBox5, pictureBox2);
            }
            else if (pictureBox8.Tag == "0")
            {
                swap(pictureBox5, pictureBox8);
            }
            else if (pictureBox6.Tag == "0")
            {
                swap(pictureBox5, pictureBox6);
            }
            
             check();
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Tag == "0")
            {
                swap(pictureBox7, pictureBox4);
            }
            else if (pictureBox8.Tag == "0")
            {
                swap(pictureBox7, pictureBox8);
             check();
            }
            
           

        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h=0;
            m = 0;
            s = 0;
            label1.Text = "00:00:00";

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Tag == "0")
            {
                swap(pictureBox8, pictureBox7);
            }
            else if (pictureBox9.Tag == "0")
            {
                swap(pictureBox8, pictureBox9);
            }
            else if (pictureBox5.Tag == "0")
            {
                swap(pictureBox8, pictureBox5);
            }
            check();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;

        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                label1.Text = string.Format("{0},{1},{2} ", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'));

            }));
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Tag == "0")
            {
                swap(pictureBox10, pictureBox9);
            }
           
           
        }
        private void check()
        {
            if (pictureBox1.Tag == "1" && pictureBox2.Tag == "2" && pictureBox3.Tag == "3" && pictureBox4.Tag == "4" && pictureBox5.Tag == "5" && pictureBox6.Tag == "6" && pictureBox7.Tag == "7" && pictureBox8.Tag == "8" && pictureBox9.Tag == "9") ;
            {
                MessageBox.Show("Congratulation! you win");
            }
        }
       

    }

        }
                                                   









	


![nn](https://github.com/user-attachments/assets/3dd3330d-0563-4f0a-bd26-211dbe48e627)





This is easy and understandable code.




THANKS






