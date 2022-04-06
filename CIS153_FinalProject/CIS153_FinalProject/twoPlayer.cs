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
    public partial class twoPlayer : Form
    {
        Form1 sForm;

        public twoPlayer()
        {
            InitializeComponent();
        }

        public twoPlayer(Form1 sF)
        {
            InitializeComponent();

            sForm = sF;

            //game stuff goes here

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
