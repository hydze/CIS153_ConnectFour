using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace CIS153_FinalProject
{
    public partial class statsForm : Form
    {
        Form1 sForm;

        public statsForm()
        {
            InitializeComponent();
        }

        public statsForm(Form1 sF)
        {
            InitializeComponent();

            sForm = sF;

            int[] statsArray = new int[4];          
            statsArray = sF.returnStats();

            txt_gamesPlayed.Text = statsArray[0].ToString();
            txt_ties.Text = statsArray[1].ToString();

            //set player stats
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

            //set computer stats
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            sForm.Show();
            this.Close();
        }
    }
}
