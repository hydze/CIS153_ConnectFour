
namespace CIS153_FinalProject
{
    partial class gameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cPer = new System.Windows.Forms.TextBox();
            this.txt_cWins = new System.Windows.Forms.TextBox();
            this.txt_pPer = new System.Windows.Forms.TextBox();
            this.txt_pWins = new System.Windows.Forms.TextBox();
            this.txt_ties = new System.Windows.Forms.TextBox();
            this.txt_gamesPlayed = new System.Windows.Forms.TextBox();
            this.lbl_cPer = new System.Windows.Forms.Label();
            this.lbl_pPer = new System.Windows.Forms.Label();
            this.lbl_cWins = new System.Windows.Forms.Label();
            this.lbl_pWins = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.lbl_games = new System.Windows.Forms.Label();
            this.lbl_stats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_review
            // 
            this.btn_review.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.Location = new System.Drawing.Point(71, 406);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(357, 56);
            this.btn_review.TabIndex = 5;
            this.btn_review.Text = "Review Game";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(71, 490);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(357, 56);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(71, 324);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(357, 56);
            this.btn_playAgain.TabIndex = 7;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_winner.Location = new System.Drawing.Point(95, 64);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(293, 28);
            this.lbl_winner.TabIndex = 8;
            this.lbl_winner.Text = "WINNER HERE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "The Winner Is";
            // 
            // txt_cPer
            // 
            this.txt_cPer.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_cPer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_cPer.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cPer.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_cPer.Location = new System.Drawing.Point(310, 281);
            this.txt_cPer.Name = "txt_cPer";
            this.txt_cPer.ReadOnly = true;
            this.txt_cPer.Size = new System.Drawing.Size(100, 25);
            this.txt_cPer.TabIndex = 35;
            this.txt_cPer.Text = "01";
            // 
            // txt_cWins
            // 
            this.txt_cWins.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_cWins.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_cWins.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cWins.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_cWins.Location = new System.Drawing.Point(159, 281);
            this.txt_cWins.Name = "txt_cWins";
            this.txt_cWins.ReadOnly = true;
            this.txt_cWins.Size = new System.Drawing.Size(100, 25);
            this.txt_cWins.TabIndex = 34;
            this.txt_cWins.Text = "01";
            // 
            // txt_pPer
            // 
            this.txt_pPer.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_pPer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pPer.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pPer.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_pPer.Location = new System.Drawing.Point(304, 230);
            this.txt_pPer.Name = "txt_pPer";
            this.txt_pPer.ReadOnly = true;
            this.txt_pPer.Size = new System.Drawing.Size(100, 25);
            this.txt_pPer.TabIndex = 33;
            this.txt_pPer.Text = "01";
            // 
            // txt_pWins
            // 
            this.txt_pWins.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_pWins.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pWins.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pWins.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_pWins.Location = new System.Drawing.Point(159, 231);
            this.txt_pWins.Name = "txt_pWins";
            this.txt_pWins.ReadOnly = true;
            this.txt_pWins.Size = new System.Drawing.Size(100, 25);
            this.txt_pWins.TabIndex = 32;
            this.txt_pWins.Text = "01";
            // 
            // txt_ties
            // 
            this.txt_ties.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_ties.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_ties.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ties.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_ties.Location = new System.Drawing.Point(266, 175);
            this.txt_ties.Name = "txt_ties";
            this.txt_ties.ReadOnly = true;
            this.txt_ties.Size = new System.Drawing.Size(100, 25);
            this.txt_ties.TabIndex = 31;
            this.txt_ties.Text = "01";
            // 
            // txt_gamesPlayed
            // 
            this.txt_gamesPlayed.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_gamesPlayed.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_gamesPlayed.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gamesPlayed.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_gamesPlayed.Location = new System.Drawing.Point(266, 140);
            this.txt_gamesPlayed.Name = "txt_gamesPlayed";
            this.txt_gamesPlayed.ReadOnly = true;
            this.txt_gamesPlayed.Size = new System.Drawing.Size(100, 25);
            this.txt_gamesPlayed.TabIndex = 30;
            this.txt_gamesPlayed.Text = "01";
            // 
            // lbl_cPer
            // 
            this.lbl_cPer.AutoSize = true;
            this.lbl_cPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cPer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cPer.Location = new System.Drawing.Point(265, 284);
            this.lbl_cPer.Name = "lbl_cPer";
            this.lbl_cPer.Size = new System.Drawing.Size(39, 22);
            this.lbl_cPer.TabIndex = 29;
            this.lbl_cPer.Text = "% :";
            // 
            // lbl_pPer
            // 
            this.lbl_pPer.AutoSize = true;
            this.lbl_pPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pPer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_pPer.Location = new System.Drawing.Point(265, 231);
            this.lbl_pPer.Name = "lbl_pPer";
            this.lbl_pPer.Size = new System.Drawing.Size(39, 22);
            this.lbl_pPer.TabIndex = 28;
            this.lbl_pPer.Text = "% :";
            // 
            // lbl_cWins
            // 
            this.lbl_cWins.AutoSize = true;
            this.lbl_cWins.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cWins.Location = new System.Drawing.Point(62, 285);
            this.lbl_cWins.Name = "lbl_cWins";
            this.lbl_cWins.Size = new System.Drawing.Size(95, 20);
            this.lbl_cWins.TabIndex = 27;
            this.lbl_cWins.Text = "Wins :";
            // 
            // lbl_pWins
            // 
            this.lbl_pWins.AutoSize = true;
            this.lbl_pWins.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_pWins.Location = new System.Drawing.Point(67, 235);
            this.lbl_pWins.Name = "lbl_pWins";
            this.lbl_pWins.Size = new System.Drawing.Size(95, 20);
            this.lbl_pWins.TabIndex = 26;
            this.lbl_pWins.Text = "Wins :";
            // 
            // lbl_ties
            // 
            this.lbl_ties.AutoSize = true;
            this.lbl_ties.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ties.Location = new System.Drawing.Point(178, 175);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(78, 18);
            this.lbl_ties.TabIndex = 25;
            this.lbl_ties.Text = "Ties :";
            // 
            // lbl_games
            // 
            this.lbl_games.AutoSize = true;
            this.lbl_games.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_games.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_games.Location = new System.Drawing.Point(63, 146);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(196, 18);
            this.lbl_games.TabIndex = 24;
            this.lbl_games.Text = "Games Played:";
            // 
            // lbl_stats
            // 
            this.lbl_stats.AutoSize = true;
            this.lbl_stats.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_stats.Location = new System.Drawing.Point(176, 111);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(128, 26);
            this.lbl_stats.TabIndex = 23;
            this.lbl_stats.Text = "Stats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(28, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Computer Stats:";
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.Font = new System.Drawing.Font("Goudy Stout", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWins.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_playerWins.Location = new System.Drawing.Point(60, 207);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(206, 18);
            this.lbl_playerWins.TabIndex = 21;
            this.lbl_playerWins.Text = "Player Stats:";
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(499, 585);
            this.ControlBox = false;
            this.Controls.Add(this.txt_cPer);
            this.Controls.Add(this.txt_cWins);
            this.Controls.Add(this.txt_pPer);
            this.Controls.Add(this.txt_pWins);
            this.Controls.Add(this.txt_ties);
            this.Controls.Add(this.txt_gamesPlayed);
            this.Controls.Add(this.lbl_cPer);
            this.Controls.Add(this.lbl_pPer);
            this.Controls.Add(this.lbl_cWins);
            this.Controls.Add(this.lbl_pWins);
            this.Controls.Add(this.lbl_ties);
            this.Controls.Add(this.lbl_games);
            this.Controls.Add(this.lbl_stats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_playerWins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_review);
            this.Name = "gameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cPer;
        private System.Windows.Forms.TextBox txt_cWins;
        private System.Windows.Forms.TextBox txt_pPer;
        private System.Windows.Forms.TextBox txt_pWins;
        private System.Windows.Forms.TextBox txt_ties;
        private System.Windows.Forms.TextBox txt_gamesPlayed;
        private System.Windows.Forms.Label lbl_cPer;
        private System.Windows.Forms.Label lbl_pPer;
        private System.Windows.Forms.Label lbl_cWins;
        private System.Windows.Forms.Label lbl_pWins;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_playerWins;
    }
}