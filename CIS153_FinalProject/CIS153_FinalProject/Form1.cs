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
    public partial class Form1 : Form
    {
        //Setting up the soundplayer
        Stream soundFile;
        SoundPlayer soundplayer;

        //vars we hold in the main form to pass around
        private int[]  statsArray = new int[4];
        private Board lastGameBoard = new Board(); // for game review on game over page
        private int gameType = 0; //1 = single player - 2 = double player - for replay on game over page
        private int gameWinner = 0; //1 = red player - 2 = yellow player - for game over page

        public Form1()
        {
            InitializeComponent();

            readStats(); //read file when program starts

            soundFile = Properties.Resources.boing3;
            soundplayer = new SoundPlayer(soundFile);
            playSound();
        }



        
        

        //EXIT BUTTON - FINISHED
        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_statistics_Click(object sender, EventArgs e)
        {
            loadStatsForm();
            
            //testGOForm(); used to view game over form and test stats functionality there
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            startSinglePlayer();
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            startTwoPlayer();
        }


        public void loadStatsForm()
        {
            statsForm formToLoad = new statsForm(this);
            formToLoad.Show(); //show statsForm
            this.Hide();
        }

        public void startSinglePlayer()
        {
            singlePlayer formToLoad = new singlePlayer(this);
            formToLoad.Show();
            this.Hide();
        }

        public void startTwoPlayer()
        {
            twoPlayer formToLoad = new twoPlayer(this);
            formToLoad.Show(); //show statsForm
            this.Hide();
        }

        public void readStats()
        {
            string content = "";

            try //make sure we can open the file
            {
                content = CIS153_FinalProject.Properties.Resources.stats;
                Console.WriteLine("File Open");

            }
            catch (Exception e)
            {
                Console.WriteLine("We cannot open File: " + e.Message);
            }

            String[] fields = content.Split(',');

            int count = 0;

            //if you happen to see all 99's or 2's on the stats page, something is probably wrong
            int games = 99;
            int ties = 99;
            int pWins = 99;
            int cWins = 99;

            foreach (String field in fields)
            {
                if (count == 0)
                {
                    games = Int32.Parse(field);
                    count++;
                }
                else if (count == 1)
                {
                    ties = Int32.Parse(field);
                    count++;
                }
                else if (count == 2)
                {
                    pWins = Int32.Parse(field);
                    count++;
                }
                else if (count == 3)
                {
                    cWins = Int32.Parse(field);
                    count++;
                }
                statsArray[0] = games;
                statsArray[1] = ties;
                statsArray[2] = pWins;
                statsArray[3] = cWins;
            }
        } //read persistent stats.txt file

        public int[] returnStats() //returns stats array for use on other forms
        {
            return statsArray;
        }

        public void updateStats(char c) //updates stats and writes file
        {
            if(c == 'g') //do updateStats('g'); on new game start
            {
                statsArray[0]++;
            }
            if (c == 't') //do updateStats('t'); on tie
            {
                statsArray[1]++;
            }
            if (c == 'p') //do updateStats('p'); on player win
            {
                statsArray[2]++;
            }
            if (c == 'c') //do updateStats('c'); on computer win
            {
                statsArray[3]++;
            }


            //WRITE FILE
            StreamWriter file = new StreamWriter("../../Resources/stats.txt", false); //false here to NOT append, IE overwrite
            string statLine = statsArray[0] + "," + statsArray[1] + "," + statsArray[2] + "," + statsArray[3] + "," ;
            file.Write(statLine);
            file.Flush();
            file.Close();


        }


        public void testGOForm()
        {
            gameOver formToLoad = new gameOver(this);
            formToLoad.Show(); //show statsForm
            this.Hide();
        }


        //adding these to get/set the last game board in the Form1 we pass around so we can keep it and use it anywhere
        public void setLastBoard(Board b)
        {
            lastGameBoard = b;
        }

        public Board getLastBoard()
        {
            return lastGameBoard;
        }

        public void setGameType(int g)
        {
            gameType = g;
        }

        public int getGameType()
        {
            return gameType;
        }

        public void setGameWinner(int g)
        {
            gameWinner = g;
        }

        public int getGameWinner()
        {
            return gameWinner;
        }

        private void playSound()
        {
            soundplayer.Play();
        }
    }
}
