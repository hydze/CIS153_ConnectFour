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

namespace CIS153_FinalProject
{
    public partial class singlePlayer : Form
    {
        Form1 sForm;
        Board board;
        List<PictureBox> redCoins;
        List<PictureBox> yellowCoins;

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

            if (board.canPlaceCoin(col))
            {
                int row = 5 - board.insertCoin(col);
                var imgPlace = col + row * 7;

                /////Debug to see array
                //var c = board.getGameBoard();
                //var res = "";
                //foreach (var r in c)
                //{
                //    res += string.Join(" ", r);
                //    res += "\n";
                //}
                //MessageBox.Show(res); //disable or enable debug output
                /////

                Color TokenColor = board.getLastPlayer();  //last player is REALLY current player before insertCoin changes player above

                if (TokenColor == Color.RED)
                {
                    var img = redCoins[imgPlace];
                    img.Visible = true;
                    red_turn.Visible = false;
                    yellow_turn.Visible = true;
                }
                if (TokenColor == Color.YELLOW)
                {
                    var img = yellowCoins[imgPlace];
                    img.Visible = true;
                    yellow_turn.Visible = false;
                    red_turn.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
            if (board.isFinished())
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
                if (board.getMoves() == 42)
                {
                    sForm.updateStats('t'); //tie condition?
                }

                //we still need to set a winner and a game type of single/multi to pass to next form, unless we want to get it from the board info once we load the next screen somehow
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
            int row = 5 - board.insertCoinHover(col);
            var imgPlace = col + row * 7;
            var img = redCoins[imgPlace];
            img.Visible = false;
            var img2 = yellowCoins[imgPlace];
            img2.Visible = false;

        }




        private void botTurn()
        {
            //Lock player out during bot turn (kinda disables 2player)
            btn_drop1.Enabled = false;
            btn_drop2.Enabled = false;
            btn_drop3.Enabled = false;
            btn_drop4.Enabled = false;
            btn_drop5.Enabled = false;
            btn_drop6.Enabled = false;
            btn_drop7.Enabled = false;

            //FIGURE OUT WHAT MOVES TO MAKE AND WHY HERE

            ////Make move column 0-6 
            buttonClick(1);

            //Enable buttons for player turn
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
    }
}
