using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CIS153_FinalProject
{
    public partial class singlePlayer : Form
    {
        Form1 sForm;
        Board board;
        List<PictureBox> redCoins;
        List<PictureBox> yellowCoins;

        Stream soundFile;
        SoundPlayer soundplayer;

        //due to nature of board size, should only ever need to block vertical win once per game
        private bool colBlock0 = false;
        private bool colBlock1 = false;
        private bool colBlock2 = false;
        private bool colBlock3 = false;
        private bool colBlock4 = false;
        private bool colBlock5 = false;
        private bool colBlock6 = false;


        //Lock player out of base row
        private bool rowBlock1 = false;
        private bool rowBlock2 = false;
        private bool rowBlock4 = false;


        private bool hotMove = false;

        public singlePlayer()
        {
            InitializeComponent();

        }

        public singlePlayer(Form1 sF)
        {
            InitializeComponent();

            sForm = sF;

            //game stuff goes here

            sForm.setGameType(1); //set single player game type for replay
            sForm.updateStats('g'); // a new game was started



            board = new Board();
            redCoins = new List<PictureBox>();
            yellowCoins = new List<PictureBox>();

            redCoins.AddRange(new [] {red_1, red_2, red_3, red_4, red_5, red_6, red_7,
            red_8, red_9, red_10, red_11, red_12, red_13, red_14,
            red_15, red_16, red_17, red_18, red_19, red_20, red_21,
            red_22, red_23, red_24, red_25, red_26, red_27, red_28,
            red_29, red_30, red_31, red_32, red_33, red_34, red_35,
            red_36, red_37, red_38, red_39, red_40, red_41, red_42});

            yellowCoins.AddRange(new[] {yellow_1, yellow_2, yellow_3, yellow_4, yellow_5, yellow_6, yellow_7,
            yellow_8, yellow_9, yellow_10, yellow_11, yellow_12, yellow_13, yellow_14,
            yellow_15, yellow_16, yellow_17, yellow_18, yellow_19, yellow_20, yellow_21,
            yellow_22, yellow_23, yellow_24, yellow_25, yellow_26, yellow_27, yellow_28,
            yellow_29, yellow_30, yellow_31, yellow_32, yellow_33, yellow_34, yellow_35,
            yellow_36, yellow_37, yellow_38, yellow_39, yellow_40, yellow_41, yellow_42});


        }



 

        private void buttonClick(int col)
        {
            SoundPicker();

            if (board.canPlaceCoin(col))
            {
                int row = 5 - board.insertCoin(col);
                var imgPlace = col + row * 7;

                Color TokenColor = board.getLastPlayer();  //last player is REALLY current player before insertCoin changes player above

                if (TokenColor == Color.RED)
                {
                    var img = redCoins[imgPlace];
                    img.Visible = true;
                    red_turn.Visible = false;
                    lbl_red_turn.Visible = false;
                    yellow_turn.Visible = true;
                    lbl_yellow_turn.Visible = true;
                }
                if (TokenColor == Color.YELLOW)
                {
                    var img = yellowCoins[imgPlace];
                    img.Visible = true;
                    yellow_turn.Visible = false;
                    lbl_yellow_turn.Visible = false;
                    red_turn.Visible = true;
                    lbl_red_turn.Visible = true;

                }

            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
            if (board.isFinished())
            {
                if (board.getMoves() == 42) //tie
                {
                    sForm.updateStats('t'); 
                }
                else //someone won
                {
                    if (board.getLastPlayer() == Color.RED)
                    {
                        sForm.updateStats('p'); //player win
                        sForm.setGameWinner(1);
                    }
                    if (board.getLastPlayer() == Color.YELLOW)
                    {
                        sForm.updateStats('c'); //computer win
                        sForm.setGameWinner(2);
                    }
                }


                sForm.setLastBoard(board); //save board state
                this.Close();
                gameOver formToLoad = new gameOver(sForm); //pass it the start form since we keep info there to pass around
                formToLoad.Show(); //show statsForm

            }
            else //bot was taking another turn after player win, didnt stop win, but showed up on review form
            {

                if (board.getLastPlayer() == Color.RED)
                {
                    botTurn();
                }

            }
        }




        private void buttonHover(int col)
        {
            if (board.canPlaceCoin(col))
            {
                int row = 5 - board.insertCoinHover(col);
                var imgPlace = col + row * 7;

                if (red_turn.Visible == true)
                {
                    var img = redCoins[imgPlace];
                    img.Visible = true;

                }
                if (yellow_turn.Visible == true)
                {
                    var img = yellowCoins[imgPlace];
                    img.Visible = true;

                }
            }
        }

        private void buttonLeave(int col)
        {
            if (board.canPlaceCoin(col) == true)
            {
                int row = 5 - board.insertCoinHover(col);
                var imgPlace = col + row * 7;
                var img = redCoins[imgPlace];
                img.Visible = false;
                var img2 = yellowCoins[imgPlace];
                img2.Visible = false;
            }
        }




        private void botTurn()
        {
            hotMove = false;

            //Lock player out during bot turn (kinda disables 2player)
            btn_drop1.Enabled = false;
            btn_drop2.Enabled = false;
            btn_drop3.Enabled = false;
            btn_drop4.Enabled = false;
            btn_drop5.Enabled = false;
            btn_drop6.Enabled = false;
            btn_drop7.Enabled = false;

            //Thread.Sleep(5000);
            int column = 3; //Column 3 is the default hotness since it mostly locks the board out

            if (board.blockVertical() != 99 && hotMove == false) //block opponents vertical wins once each column a game if needed
            {
                if (board.blockVertical() == 0)
                {
                    if (colBlock0 == false)
                    {
                        colBlock0 = true;
                        hotMove = true;
                        column = 0;
                    }
                }

                if (board.blockVertical() == 1)
                {
                    if (colBlock1 == false)
                    {
                        colBlock1 = true;
                        hotMove = true;
                        column = 1;
                    }
                }

                if (board.blockVertical() == 2)
                {
                    if (colBlock2 == false)
                    {
                        colBlock2 = true;
                        hotMove = true;
                        column = 2;
                    }
                }

                if (board.blockVertical() == 3)
                {
                    if (colBlock3 == false)
                    {
                        colBlock3 = true;
                        hotMove = true;
                        column = 3;
                    }
                }

                if (board.blockVertical() == 4)
                {
                    if (colBlock4 == false)
                    {
                        colBlock4 = true;
                        hotMove = true;
                        column = 4;
                    }
                }

                if (board.blockVertical() == 5)
                {
                    if (colBlock5 == false)
                    {
                        colBlock5 = true;
                        hotMove = true;
                        column = 5;
                    }
                }

                if (board.blockVertical() == 6)
                {
                    if (colBlock6 == false)
                    {
                        colBlock6 = true;
                        hotMove = true;
                        column = 6;
                    }
                }
            }

            if (board.takeHorizontalWin() != 99 && hotMove == false)
            {
                column = board.takeHorizontalWin();
            }
            if (board.takeVerticalWin() != 99 && hotMove == false)
            {
                column = board.takeVerticalWin();
                hotMove = true;
            }



            if (board.blockHorizontalBase() != 99 && hotMove == false) // attempt to lock opponent out of base row
            {
                if (board.blockHorizontalBase() == 4)
                {
                    if (rowBlock4 == false)
                    {
                        rowBlock4 = true;
                        hotMove = true;
                        column = board.blockHorizontalBase();
                    }
                }

                if (board.blockHorizontalBase() == 2)
                {
                    if (rowBlock2 == false)
                    {
                        rowBlock2 = true;
                        hotMove = true;
                        column = board.blockHorizontalBase();
                    }
                }

                if (board.blockHorizontalBase() == 1)
                {
                    if (rowBlock1 == false)
                    {
                        rowBlock1 = true;
                        hotMove = true;
                        column = board.blockHorizontalBase();
                    }
                }
            }
            else
            {
                //Middle collumn is KING, and essential to most wins, its block non vertical wins, we want to hold this by default
                if (board.canPlaceCoin(3) && hotMove == false) //take and hold middle row 
                {
                    column = 3;
                }
                else
                {
                    if (hotMove == false)
                    {
                        //Pick a column and if we have a run keep pushing if possible and we dont need to block
                        if (board.pushVertical2() != 99)
                        {
                            if (board.canPlaceCoin(board.pushVertical2()))
                            {
                                column = board.pushVertical2();
                            }
                        }
                        if (board.pushVertical3() != 99)
                        {
                            if (board.canPlaceCoin(board.pushVertical3()))
                            {
                                column = board.pushVertical3();
                            }
                        }
                    }
                }

            }

            if (column == 8 && hotMove == false) //if nothing else makes sense, pick a random column thats open
            {
                Random diceRoll = new Random();
                int tryColumn = diceRoll.Next(0, 6);
                while (board.canPlaceCoin(tryColumn) == false)
                {
                    tryColumn = diceRoll.Next(0, 6);
                }
                column = tryColumn;
            }
            if (board.canPlaceCoin(column) == false) //while it shouldnt never happen after other changes made, if we cannot make the move we selected for some reason, pick one
            {
                Random diceRoll = new Random();
                int tryColumn = diceRoll.Next(0, 6);
                while (board.canPlaceCoin(tryColumn) == false)
                {
                    tryColumn = diceRoll.Next(0, 6);
                }
                column = tryColumn;
            }


            ////Make move we choose from column 0-6 
            buttonClick(column);


            //Enable buttons again for player turn
            btn_drop1.Enabled = true;
            btn_drop2.Enabled = true;
            btn_drop3.Enabled = true;
            btn_drop4.Enabled = true;
            btn_drop5.Enabled = true;
            btn_drop6.Enabled = true;
            btn_drop7.Enabled = true;


        }




        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            sForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_drop1_Click(object sender, EventArgs e)
        {
            buttonClick(0);    
        }

        private void btn_drop2_Click(object sender, EventArgs e)
        {
            buttonClick(1);
        }

        private void btn_drop3_Click(object sender, EventArgs e)
        {
            buttonClick(2);
        }

        private void btn_drop4_Click(object sender, EventArgs e)
        {
            buttonClick(3);
        }

        private void btn_drop5_Click(object sender, EventArgs e)
        {
            buttonClick(4);
        }

        private void btn_drop6_Click(object sender, EventArgs e)
        {
            buttonClick(5);
        }

        private void btn_drop7_Click(object sender, EventArgs e)
        {
            buttonClick(6);
        }

        private void btn_drop1_MouseHover(object sender, EventArgs e)
        {
            buttonHover(0);
        }
      
        private void btn_drop1_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(0);
        }

        private void btn_drop2_MouseHover(object sender, EventArgs e)
        {
            buttonHover(1);
        }

        private void btn_drop2_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(1);
        }

        private void btn_drop3_MouseHover(object sender, EventArgs e)
        {
            buttonHover(2);
        }

        private void btn_drop3_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(2);
        }

        private void btn_drop4_MouseHover(object sender, EventArgs e)
        {
            buttonHover(3);
        }

        private void btn_drop4_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(3);
        }

        private void btn_drop5_MouseHover(object sender, EventArgs e)
        {
            buttonHover(4);
        }

        private void btn_drop5_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(4);
        }

        private void btn_drop6_MouseHover(object sender, EventArgs e)
        {
            buttonHover(5);
        }

        private void btn_drop6_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(5);
        }

        private void btn_drop7_MouseHover(object sender, EventArgs e)
        {
            buttonHover(6);
        }

        private void btn_drop7_MouseLeave(object sender, EventArgs e)
        {
            buttonLeave(6);
        }

        private void playSound()
        {
            soundplayer.Play();
        }

        private void SoundPicker()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 6);

            if (num == 1)
            {
                soundFile = Properties.Resources.boing_x;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
            else if (num == 2)
            {
                soundFile = Properties.Resources.boing_poing;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
            else if (num == 3)
            {
                soundFile = Properties.Resources.boing_spring;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
            else if (num == 4)
            {
                soundFile = Properties.Resources.can_pop;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
            else if (num == 5)
            {
                soundFile = Properties.Resources.car_crash;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
        }
    }
}
