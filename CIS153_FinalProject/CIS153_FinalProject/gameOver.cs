using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace CIS153_FinalProject
{
    public partial class gameOver : Form
    {
        Stream soundFile;
        SoundPlayer soundplayer;

        Form1 sForm;

        public gameOver()
        {
            InitializeComponent();
        }

        public gameOver(Form1 sF)
        {


            InitializeComponent();
            sForm = sF;
            string gameWin = "NaN";

            //Board lastBoard = sForm.getLastBoard();
            //var c = lastBoard.getGameBoard();
            //var res = ""; 
            //foreach (var r in c)
            //{
            //    res += string.Join(" ", r);
            //    res += "\n";
            //}
            //MessageBox.Show(res);  //making sure the board was passed correctly to game over form

            if (sForm.getGameWinner() == 1)
            {
                gameWin = "RED";

                soundFile = Properties.Resources.cheering;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
            if (sForm.getGameWinner() == 2)
            {
                //I did this not under the assumption that player 2 would
                //always be an AI, but the assumption that player 2 sucks.

                gameWin = "YELLOW";
                soundFile = Properties.Resources.boo;
                soundplayer = new SoundPlayer(soundFile);
                playSound();
            }
               
            lbl_winner.Text = gameWin; //need to add sForm.setGameWinner(1|2); to winning logic to set this

            int[] statsArray = new int[4];
            statsArray = sF.returnStats();
            txt_gamesPlayed.Text = statsArray[0].ToString();
            txt_ties.Text = statsArray[1].ToString();

            //display player stats
            txt_pWins.Text = statsArray[2].ToString();
            if (statsArray[2] != 0)
            {
                double pPer = Convert.ToDouble(statsArray[2]) / Convert.ToDouble(statsArray[0]);
                txt_pPer.Text = pPer.ToString("P");
            }
            else
            {
                txt_pPer.Text = "NaN";
            }

            //display computer stats
            txt_cWins.Text = statsArray[3].ToString();
            if (statsArray[3] != 0)
            {
                double cPer = Convert.ToDouble(statsArray[3]) / Convert.ToDouble(statsArray[0]);
                txt_cPer.Text = cPer.ToString("P");
            }
            else
            {
                txt_cPer.Text = "NaN";
            }



        }



        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            if (sForm.getGameType() == 1) //replay single player
            {
                singlePlayer formToLoad = new singlePlayer(sForm); //NEW GAME
                formToLoad.Show();
                this.Close();
            }
            if (sForm.getGameType() == 2) //replay double player
            {
                twoPlayer formToLoad = new twoPlayer(sForm); //NEW GAME
                formToLoad.Show();
                this.Close();
            }
            if (sForm.getGameType() == 0) //SOMETHINGS WRONG OR DEBUG -- goes main menu
            {
                sForm.Show();
                this.Close();
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            //was going back to main menu when test viewing this page
            //sForm.Show();
            //this.Close();

            //you can get last gameboard with sForm.getLastBoard();
            reviewBoard formToLoad = new reviewBoard(sForm); //NEW GAME
            formToLoad.Show();
            this.Close();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void playSound()
        {
            soundplayer.Play();
        }


    }
}
