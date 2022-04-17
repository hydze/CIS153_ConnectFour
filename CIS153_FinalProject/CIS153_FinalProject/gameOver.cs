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
    public partial class gameOver : Form
    {
        Form1 sForm;

        public gameOver()
        {
            InitializeComponent();
        }

        public gameOver(Form1 sF)
        {
            InitializeComponent();
            sForm = sF;


            lbl_winner.Text = "Winner Here"; //need to do functionality to get this info


            int[] statsArray = new int[4];
            statsArray = sF.returnStats();
            txt_gamesPlayed.Text = statsArray[0].ToString();
            txt_ties.Text = statsArray[1].ToString();

            //display player stats
            txt_pWins.Text = statsArray[2].ToString();
            if (statsArray[2] != 0)
            {
                double pPer = Convert.ToDouble(statsArray[2]) / Convert.ToDouble(statsArray[0]) * 100;
                txt_pPer.Text = pPer.ToString();
            }
            else
            {
                txt_pPer.Text = "NaN";
            }

            //display computer stats
            txt_cWins.Text = statsArray[3].ToString();
            if (statsArray[3] != 0)
            {
                double cPer = Convert.ToDouble(statsArray[3]) / Convert.ToDouble(statsArray[0]) * 100;
                txt_cPer.Text = cPer.ToString();
            }
            else
            {
                txt_cPer.Text = "NaN";
            }



        }



        private void btn_playAgain_Click(object sender, EventArgs e)
        {

        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            //was going back to main menu when test viewing this page
            //sForm.Show();
            //this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
