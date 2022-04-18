using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class reviewBoard : Form
    {
        Form1 sForm;
        Board board;
        List<PictureBox> redCoins;
        List<PictureBox> yellowCoins;

        public reviewBoard()
        {
            InitializeComponent();

        }

        public reviewBoard(Form1 sF)
        {
            InitializeComponent();

            sForm = sF;
            string gameWin = "NaN";

            //game stuff goes here

            board = sForm.getLastBoard();
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

            /////Debug to see array
            //var c = board.getGameBoard();
            //var res = "";
            //foreach (var r in c)
            //{
            //    res += string.Join(" ", r);
            //    res += "\n";
            //}
            //MessageBox.Show(res); //disable or enable array debug output
            /////

            placeTokens();

            if (sForm.getGameWinner() == 1)
            {
                gameWin = "RED";
                red_token.Visible = true;
            }
            if (sForm.getGameWinner() == 2)
            {
                gameWin = "YELLOW";
                yellow_token.Visible = true;
            }

            lbl_win.Text = gameWin;

        }


        private void placeTokens()
        {
            Board lastBoard = sForm.getLastBoard();
            var b = lastBoard.getGameBoard();
            int[] map = new int[] { 36, 37, 38, 39, 40, 41, 42, 29, 30, 31, 32, 33, 34, 35, 22, 23, 24, 25, 26, 27, 28, 15, 16, 17, 18, 19, 20, 21, 8, 9, 10, 11, 12, 13, 14, 1, 2, 3, 4, 5, 6, 7 }; //our button #s match up weird with the array traversed from this angle so this was just quicker to static map, array is also off by 1 from game board bcause we started at button 1 instead of 0
            int iter = 0;
            foreach (Color r in b)
            {
                if (r == Color.RED)
                {
                    int spot = map[iter] - 1;
                    var img = redCoins[spot];
                    img.Visible = true;
                }
                if (r == Color.YELLOW)
                {
                    int spot = map[iter] - 1;
                    var img = yellowCoins[spot];
                    img.Visible = true;
                }

                iter++;
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            this.Close();
            gameOver formToLoad = new gameOver(sForm); //pass it the start form since we keep info there to pass around
            formToLoad.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
