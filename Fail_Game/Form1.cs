using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Witch_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gameover.Visible = false;
            gameover2.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveground(playerspeed);
            ghost(2);
            over();
            reward(playerspeed);
            rewardcollection();
        }

        Random r = new Random();
        int x, y;
        void ghost(int speed)
        {
            if (ghost1.Top >= 600)
            {
             x = r.Next(450, 700);
             ghost1.Location = new Point(x, 0);
            }
                
            else
                ghost1.Top += speed;

            if (ghost2.Top >= 600)
            {
                x = r.Next(0, 200);
                ghost2.Location = new Point(x, 0);
            }

            else
                ghost2.Top += speed;

            if (ghost3.Top >= 600)
            {
                x = r.Next(0, 200);
                ghost3.Location = new Point(x, 0);
            }

            else
                ghost3.Top += speed;

            if (ghost4.Top >= 600)
            {
                x = r.Next(450, 700);
                ghost4.Location = new Point(x, 0);
            }

            else
                ghost4.Top += speed;



        }

        void reward(int speed)
        {
            if (reward1.Top >= 600)
            {
                x = r.Next(0, 200);
                reward1.Location = new Point(x, 0);
            }

            else
                reward1.Top += speed;

            if (reward2.Top >= 600)
            {
                x = r.Next(0, 200);
                reward2.Location = new Point(x, 0);
            }

            else
                reward2.Top += speed;

            if (reward3.Top >= 600)
            {
                x = r.Next(450, 750);
                reward3.Location = new Point(x, 0);
            }
            else
                reward3.Top += speed;
        }
        
           





        void over()
        {
            if(player.Bounds.IntersectsWith(ghost1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

            if (player.Bounds.IntersectsWith(ghost2.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

            if (player.Bounds.IntersectsWith(ghost3.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

            if (player.Bounds.IntersectsWith(ghost4.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                timer1.Enabled = false;
                gameover2.Visible = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                timer1.Enabled = false;
                gameover2.Visible = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                timer1.Enabled = false;
                gameover2.Visible = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }

            if (player.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }



        }
        void moveground(int speed)
        {
            if (pictureBox1.Top >= 600)
            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }

            
            if (pictureBox6.Top >= 600)
            { pictureBox1.Top = 0; }
            else
            { pictureBox6.Top += speed; }



            if (pictureBox2.Top >= 600)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 600)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 600)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }


            if (pictureBox5.Top >= 600)
             { pictureBox5.Top = 0; }
            else
            { pictureBox5.Top += speed; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        int playerspeed = 5;
        private void player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox3_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        int collectedreward = 0;

        void rewardcollection()
        {

            if (player.Bounds.IntersectsWith(reward1.Bounds))
            {
                collectedreward++;
                points.Text = "POINTS=" + collectedreward.ToString();
                x = r.Next(0, 200);
                reward1.Location = new Point(x, 0);
            }


            if (player.Bounds.IntersectsWith(reward2.Bounds))
            {
                collectedreward++;
                points.Text = "POINTS=" + collectedreward.ToString();
                x = r.Next(0, 200);
                reward2.Location = new Point(x, 0);
            }


            if (player.Bounds.IntersectsWith(reward3.Bounds))
            {
                collectedreward++;
                points.Text = "POINTS=" + collectedreward.ToString();
                x = r.Next(450, 750);
                reward3.Location = new Point(x, 0);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 0)
                    player.Left += playerspeed;
                if (player.Right == 1088)
                   player.Left = 35;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (playerspeed < 20)
                    playerspeed++;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (playerspeed > 0)
                    playerspeed--;
            }
        }
    }
    
}
 