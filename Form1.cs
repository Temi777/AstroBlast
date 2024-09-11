using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Temidayo A., Selina P.
//7/6/2023
//To make sure the rocket avoids satellites, aliens, and collects gas in order to make its journey to defeat the boss alien.

namespace AstroBlast
{
    public partial class AstroBlast : Form
    {
        //Global Variables
        bool Started = false;
        bool Stop = false;
        bool ReloadBullet = false;
        bool Instructions = false;
        bool Energy1 = false;
        bool Energy2 = false;
        bool Hit = false;
        bool Reposition = false;

        int Gravity = 9;
        int Speed = 8;
        int Gas = 0;
        int Score = 0;
        Random oRandom = new Random();
        List<PictureBox> Bullets = new List<PictureBox>();

        public AstroBlast()
        {
            InitializeComponent();

            //Centre the Start label on the form
            lblStart.Left = ClientSize.Width / 2 - lblStart.Width / 2;
            lblStart.Top = ClientSize.Height / 2 - lblStart.Height / 2;
        }

        private void AstroBlast_KeyDown(object sender, KeyEventArgs e)
        {
            //Start Game
            if (Started == false)
            {
                //centre the Start label on form
                lblStart.Left = ClientSize.Width / 2 - lblStart.Width / 2;
                lblStart.Top = ClientSize.Height / 2 - lblStart.Height / 2;

                if (e.KeyCode == Keys.Return && Instructions == false)
                {
                    Started = true;
                    Stop = false;
                    InitializeGame();
                }

                if (e.KeyCode == Keys.M)
                {
                    Instructions = true;
                    Stop = false;
                    lblStart.Visible = false;

                    //Position instructions
                    lblInstructions.Left = ClientSize.Width / 2 - lblInstructions.Width / 2;
                    lblInstructions.Top = ClientSize.Height / 2 - lblInstructions.Height / 2;

                    lblInstructions.Visible = true;
                }

                if (e.KeyCode == Keys.B)
                {
                    Instructions = false;
                    lblInstructions.Visible = false;
                    lblStart.Visible = true;
                }

                if (e.KeyCode == Keys.P)
                {
                    tmrGame.Enabled = true;
                }

            }


            if (Stop == true)
            {
                //Play Again?
                if (e.KeyCode == Keys.D1)
                {
                    Started = false;
                    lblStart.Visible = true;
                    lblStart.Text = "Press ENTER to start!\nPress M for instructions";
                }

                //Quit
                if (e.KeyCode == Keys.D2)
                {
                    Application.Exit();
                }
            }

            //flying to go up
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -9;

            }
            //Shoot
            if (e.KeyCode == Keys.Up && ReloadBullet == false)
            {
                CreateBullet();
                Gas--;
                lblGas.Text = "Gas: " + Gas;
            }

        }

        private void AstroBlast_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //Stop flying so that rocket will go down
                Gravity = 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                ReloadBullet = false;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //Move Rocket
            picRocket.Top += Gravity;

            //Move the Satellites
            picTopSat.Left -= Speed;
            picOTopSat.Left -= Speed;
            picBotSat.Left -= Speed;
            picGas.Left -= Speed;
            picAlien.Left -= Speed;

            
            if (Score> 35)
            {
                picTopSat.Left -= 0;
                picOTopSat.Left -= 0;
                picBotSat.Left -= 0;
                picGas.Left -= 0;
                picAlien.Left -= 0;
            }

            ////reposition pipes when they go off screen
            int PositionBot = oRandom.Next(400, 950);
            int PositionTop = oRandom.Next(400, 950);
            int Height = oRandom.Next(260, 330);
            int GasLeft = oRandom.Next(480, 950);
            int GasTop = oRandom.Next(0, 193);
            int AlienLeft = oRandom.Next(480, 950);
            int AlienTop = oRandom.Next(0, 193);
            int AlienNum = oRandom.Next(6, 8);

            if (Reposition == false)
            {
                //if top satellite goes off screen, repososition it
                if (picTopSat.Left < -180)
                {
                    picTopSat.Left = PositionTop;
                    picOTopSat.Left = picTopSat.Left;
                    picTopSat.Height = Height;
                    picOTopSat.Height = picTopSat.Height;
                    Score++;
                    lblScore.Text = "Score: " + Score;
                    Gas--;
                    lblGas.Text = "Gas: " + Gas;
                }

                //if bottom satellite goes off screen, repososition it

                if (picBotSat.Left < -180)
                {
                    picBotSat.Left = PositionBot;
                    picBotSat.Height = Height;
                    Score++;
                    Gas--;
                    lblScore.Text = "Score: " + Score;
                    lblGas.Text = "Gas: " + Gas;
                }
            }

            //End Game when rocket hits satellites
            if (picRocket.Bounds.IntersectsWith(picTopSat.Bounds) || picRocket.Bounds.IntersectsWith(picBotSat.Bounds))
            {
                EndGame();
            }
            //End game if rocket touches aliens
            if (picRocket.Bounds.IntersectsWith(picAlien.Bounds))
            {
                EndGame();
            }
            //End game if rocket goes out of bounds
            if (picRocket.Top <= 0 || picRocket.Bottom >= ClientSize.Height)
            {
                EndGame();
            }
            if (Gas < 0)
            {
                EndGame();
            }

            //Can't shoot with no gas
            //if (Gas == 0)
            //{
            //    ReloadBullet = false;
            //}
            //else
            //{
            //    ReloadBullet = true;
            //}

            ////if gas goes off screen, repososition it
            if (picGas.Left < -180 || picGas.Bounds.IntersectsWith(picRocket.Bounds))
            {
                if (picGas.Bounds.IntersectsWith(picRocket.Bounds))
                {
                    //If Rocket touches gas, add points to gas
                    int GasNum = oRandom.Next(5, 7);
                    Gas += GasNum;
                    picGas.Left = GasLeft;
                    picGas.Top = GasTop;
                    
                    Hit = true;
                }
                //if gas goes off screen, reposition it
                if (picGas.Left < -180)
                {
                    picGas.Left = GasLeft;
                    picGas.Top = GasTop;
                }

                //Output gas points
                lblGas.Text = "Gas: " + Gas;
            }

            ////if Alien goes off screen, repososition it
            if (picAlien.Left < -180)
            {
                picAlien.Left = AlienLeft;
                picAlien.Top = AlienTop;
            }

            //Make The Bullet Function
            for (int i = Bullets.Count - 1; i > -1; i--)
            {
                //Move bullet
                Bullets[i].Left += 20;

                //bullet goes out of bounds
                if (Bullets[i].Left >= this.ClientSize.Width)
                {
                    //Remove bullet from form and list
                    this.Controls.Remove(Bullets[i]);
                    Bullets.RemoveAt(i);
                }
                else
                {
                    //if bullet hits Alien
                    if (Bullets[i].Bounds.IntersectsWith(picAlien.Bounds))
                    {
                        this.Controls.Remove(Bullets[i]);
                        Bullets.Remove(Bullets[i]);

                        //If bullet touches alien, add points to score
                        Score += AlienNum;
                        lblScore.Text = "Score: " + Score;

                        picAlien.Left = AlienLeft;
                        picAlien.Top = AlienTop;
                    }

                    //bullet hits energy sources
                    else if (Bullets[i].Bounds.IntersectsWith(picEnergy1.Bounds))
                    {
                        this.Controls.Remove(Bullets[i]);
                        Bullets.Remove(Bullets[i]);
                        this.Controls.Remove(picEnergy1);
                        Energy1 = true;
                    }
                    else if (Bullets[i].Bounds.IntersectsWith(picEnergy2.Bounds))
                    {
                        this.Controls.Remove(Bullets[i]);
                        Bullets.Remove(Bullets[i]);
                        this.Controls.Remove(picEnergy2);
                        Energy2 = true;
                    }
                    
                }
            }

            if (Energy1 == true && Energy2 == true)
            {
                WinGame();
            }

            if (Score > 35)
            {

                //if top satellite goes off screen, make it disappear
                if (picTopSat.Left < -180)
                {
                    Score++;
                    lblScore.Text = "Score: " + Score;
                    Gas--;
                    lblGas.Text = "Gas: " + Gas;

                    picTopSat.Visible = false;
                    picOTopSat.Visible = false;
                    picOTopSat.Left = -200;
                    picOTopSat.Enabled = false;
                    picTopSat.Left = -200;
                    picTopSat.Enabled = false;
                }

                //if bottom satellite goes off screen, make it disappear
                if (picBotSat.Left < -180)
                {
                    Score++;
                    Gas--;
                    lblScore.Text = "Score: " + Score;
                    lblGas.Text = "Gas: " + Gas;

                    picBotSat.Visible = false;
                    picBotSat.Left = -200;
                    picBotSat.Enabled = false;
                }
                //if gas goes off screen make it disappear
                if (picGas.Left < -180)
                {
                    picGas.Visible = false;
                    picGas.Left = -200;
                    picGas.Enabled = false;
                }
                else if (Hit == true)
                {
                    picGas.Visible = false;
                    picGas.Left = -200;
                    picGas.Enabled = false; 
                }

                //if alien goes off screen make it disappear
                if (picAlien.Left<-180)
                {
                    picAlien.Visible = false;
                    picAlien.Left = -200;
                }
                

                //make boss visible
                picEnergy1.Visible = true;
                picEnergy2.Visible = true;
                picBossAlien.Visible = true;

                picBossAlien.Left -= 1;
                picEnergy1.Left -= 1;
                picEnergy2.Left -= 1;

                if (picGas.Bounds.IntersectsWith(picBossAlien.Bounds))
                {
                    EndGame();
                }

            }

        }


        public void CreateBullet()
        {
            PictureBox Bullet = new PictureBox();
            Bullet.BackColor = Color.Gold;
            Bullet.Width = 10;
            Bullet.Height = 5;
            Bullet.Left = picRocket.Right;
            Bullet.Top = picRocket.Top + (picRocket.Height / 2 - Bullet.Height / 2);
            Bullet.Visible = true;
            this.Controls.Add(Bullet);
            Bullets.Add(Bullet);

            if (Stop == true)
            {
                Bullet.Visible = false;


            }
            if (Started == true)
            {
                Bullet.Visible = true;


            }
        }


        public void InitializeGame()
        {
            //resets all lists
            Bullets = new List<PictureBox>();
            tmrGame.Enabled = true;
            lblStart.Visible = false;
            lblGas.Visible = true;
            lblScore.Visible = true;

            picRocket.Visible = true;
            picGas.Visible = true;
            picBotSat.Visible = true;
            picTopSat.Visible = true;
            picAlien.Visible = true;
            picOTopSat.Visible = true;
            ReloadBullet = false;

            Gas = 0;
            Score = 0;



            picTopSat.Left = 650;
            picBotSat.Left = 650;
            picOTopSat.Left = 650;
            picBotSat.Top = 280;
            picAlien.Left = 900;

            picGas.Left = 450;
            picGas.Top = 173;

            picRocket.Left = 66;
            picRocket.Top = ClientSize.Height / 2 - picRocket.Height / 2;

        }

        //public void PauseGame()
        //{
        //    tmrGame.Stop();
        //}

        public void EndGame()
        {

            for (int i = Bullets.Count - 1; i > -1; i--)
            {
                this.Controls.Remove(Bullets[i]);
            }
            Bullets.Clear();


            tmrGame.Enabled = false;
            picRocket.Visible = false;
            picGas.Visible = false;
            picBotSat.Visible = false;
            picTopSat.Visible = false;
            picOTopSat.Visible = false;
            picAlien.Visible = false;
            ReloadBullet = true;

            picEnergy1.Visible = false;
            picEnergy2.Visible = false;
            picBossAlien.Visible = false;

            Gas = 0;
            Score = 0;
            lblScore.Text = "Score: " + Score;
            lblGas.Text = "Gas: " + Gas;

            lblGas.Visible = false;
            lblScore.Visible = false;

            //centre the Start label on form
            lblStart.Left = ClientSize.Width / 2 - lblStart.Width / 2;
            lblStart.Top = ClientSize.Height / 2 - lblStart.Height / 2;

            lblStart.Text = "You Lost!!\nPress 1 To Play Again\nPress 2 To Quit";
            lblStart.Visible = true;
            Stop = true;

        }
        public void WinGame()
        {

            //Bullets = new List<PictureBox>();
            for (int i = Bullets.Count - 1; i > -1; i--)
            {
                this.Controls.Remove(Bullets[i]);
            }
            Bullets.Clear();


            tmrGame.Enabled = false;
            picRocket.Visible = false;
            picGas.Visible = false;
            picBotSat.Visible = false;
            picTopSat.Visible = false;
            picOTopSat.Visible = false;
            picAlien.Visible = false;
            ReloadBullet = true;

            picEnergy1.Visible = false;
            picEnergy2.Visible = false;
            picBossAlien.Visible = false;

            Gas = 0;
            Score = 0;
            lblScore.Text = "Score: " + Score;
            lblGas.Text = "Gas: " + Gas;

            lblGas.Visible = false;
            lblScore.Visible = false;

            //centre the Start label on form
            lblStart.Left = ClientSize.Width / 2 - lblStart.Width / 2;
            lblStart.Top = ClientSize.Height / 2 - lblStart.Height / 2;

            lblStart.Text = "You WON!!!! Would You Like To Play Again?\nPress 1 To Play Again\nPress 2 To Quit";
            lblStart.Visible = true;
            Stop = true;

        }

      
    } 
    
}
