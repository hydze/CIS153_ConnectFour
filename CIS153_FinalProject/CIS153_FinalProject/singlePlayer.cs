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
    public partial class singlePlayer : Form
    {
        Form1 sForm;

        public singlePlayer()
        {
            InitializeComponent();
        }

        public singlePlayer(Form1 sF)
        {
            InitializeComponent();
            sForm = sF;

            //a new single player game was started so increment the games played counter
            sForm.updateStats('g');

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
