
namespace CIS153_FinalProject
{
    partial class statsForm
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stats = new System.Windows.Forms.Label();
            this.lbl_games = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.lbl_pWins = new System.Windows.Forms.Label();
            this.lbl_cWins = new System.Windows.Forms.Label();
            this.lbl_pPer = new System.Windows.Forms.Label();
            this.lbl_cPer = new System.Windows.Forms.Label();
            this.txt_gamesPlayed = new System.Windows.Forms.TextBox();
            this.txt_ties = new System.Windows.Forms.TextBox();
            this.txt_pWins = new System.Windows.Forms.TextBox();
            this.txt_pPer = new System.Windows.Forms.TextBox();
            this.txt_cWins = new System.Windows.Forms.TextBox();
            this.txt_cPer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(62, 436);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(357, 56);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_main
            // 
            this.btn_main.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.Location = new System.Drawing.Point(62, 356);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(357, 56);
            this.btn_main.TabIndex = 5;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWins.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_playerWins.Location = new System.Drawing.Point(56, 172);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(370, 32);
            this.lbl_playerWins.TabIndex = 6;
            this.lbl_playerWins.Text = "Player Stats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(26, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Computer Stats:";
            // 
            // lbl_stats
            // 
            this.lbl_stats.AutoSize = true;
            this.lbl_stats.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_stats.Location = new System.Drawing.Point(166, 30);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(161, 32);
            this.lbl_stats.TabIndex = 8;
            this.lbl_stats.Text = "Stats";
            // 
            // lbl_games
            // 
            this.lbl_games.AutoSize = true;
            this.lbl_games.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_games.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_games.Location = new System.Drawing.Point(58, 83);
            this.lbl_games.Name = "lbl_games";
            this.lbl_games.Size = new System.Drawing.Size(228, 20);
            this.lbl_games.TabIndex = 9;
            this.lbl_games.Text = "Games Played:";
            // 
            // lbl_ties
            // 
            this.lbl_ties.AutoSize = true;
            this.lbl_ties.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_ties.Location = new System.Drawing.Point(196, 122);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(90, 20);
            this.lbl_ties.TabIndex = 10;
            this.lbl_ties.Text = "Ties :";
            // 
            // lbl_pWins
            // 
            this.lbl_pWins.AutoSize = true;
            this.lbl_pWins.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_pWins.Location = new System.Drawing.Point(58, 220);
            this.lbl_pWins.Name = "lbl_pWins";
            this.lbl_pWins.Size = new System.Drawing.Size(95, 20);
            this.lbl_pWins.TabIndex = 11;
            this.lbl_pWins.Text = "Wins :";
            // 
            // lbl_cWins
            // 
            this.lbl_cWins.AutoSize = true;
            this.lbl_cWins.Font = new System.Drawing.Font("Goudy Stout", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cWins.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cWins.Location = new System.Drawing.Point(58, 302);
            this.lbl_cWins.Name = "lbl_cWins";
            this.lbl_cWins.Size = new System.Drawing.Size(95, 20);
            this.lbl_cWins.TabIndex = 12;
            this.lbl_cWins.Text = "Wins :";
            // 
            // lbl_pPer
            // 
            this.lbl_pPer.AutoSize = true;
            this.lbl_pPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pPer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_pPer.Location = new System.Drawing.Point(258, 220);
            this.lbl_pPer.Name = "lbl_pPer";
            this.lbl_pPer.Size = new System.Drawing.Size(39, 22);
            this.lbl_pPer.TabIndex = 13;
            this.lbl_pPer.Text = "% :";
            // 
            // lbl_cPer
            // 
            this.lbl_cPer.AutoSize = true;
            this.lbl_cPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cPer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_cPer.Location = new System.Drawing.Point(258, 301);
            this.lbl_cPer.Name = "lbl_cPer";
            this.lbl_cPer.Size = new System.Drawing.Size(39, 22);
            this.lbl_cPer.TabIndex = 14;
            this.lbl_cPer.Text = "% :";
            // 
            // txt_gamesPlayed
            // 
            this.txt_gamesPlayed.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_gamesPlayed.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_gamesPlayed.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gamesPlayed.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_gamesPlayed.Location = new System.Drawing.Point(293, 82);
            this.txt_gamesPlayed.Name = "txt_gamesPlayed";
            this.txt_gamesPlayed.ReadOnly = true;
            this.txt_gamesPlayed.Size = new System.Drawing.Size(100, 29);
            this.txt_gamesPlayed.TabIndex = 15;
            this.txt_gamesPlayed.Text = "01";
            // 
            // txt_ties
            // 
            this.txt_ties.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_ties.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_ties.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ties.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_ties.Location = new System.Drawing.Point(292, 122);
            this.txt_ties.Name = "txt_ties";
            this.txt_ties.ReadOnly = true;
            this.txt_ties.Size = new System.Drawing.Size(100, 29);
            this.txt_ties.TabIndex = 16;
            this.txt_ties.Text = "01";
            // 
            // txt_pWins
            // 
            this.txt_pWins.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_pWins.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pWins.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pWins.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_pWins.Location = new System.Drawing.Point(152, 216);
            this.txt_pWins.Name = "txt_pWins";
            this.txt_pWins.ReadOnly = true;
            this.txt_pWins.Size = new System.Drawing.Size(100, 29);
            this.txt_pWins.TabIndex = 17;
            this.txt_pWins.Text = "01";
            // 
            // txt_pPer
            // 
            this.txt_pPer.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_pPer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_pPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pPer.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_pPer.Location = new System.Drawing.Point(293, 216);
            this.txt_pPer.Name = "txt_pPer";
            this.txt_pPer.ReadOnly = true;
            this.txt_pPer.Size = new System.Drawing.Size(100, 29);
            this.txt_pPer.TabIndex = 18;
            this.txt_pPer.Text = "01";
            // 
            // txt_cWins
            // 
            this.txt_cWins.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_cWins.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_cWins.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cWins.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_cWins.Location = new System.Drawing.Point(152, 298);
            this.txt_cWins.Name = "txt_cWins";
            this.txt_cWins.ReadOnly = true;
            this.txt_cWins.Size = new System.Drawing.Size(100, 29);
            this.txt_cWins.TabIndex = 19;
            this.txt_cWins.Text = "01";
            // 
            // txt_cPer
            // 
            this.txt_cPer.BackColor = System.Drawing.SystemColors.WindowText;
            this.txt_cPer.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_cPer.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cPer.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_cPer.Location = new System.Drawing.Point(292, 298);
            this.txt_cPer.Name = "txt_cPer";
            this.txt_cPer.ReadOnly = true;
            this.txt_cPer.Size = new System.Drawing.Size(100, 29);
            this.txt_cPer.TabIndex = 20;
            this.txt_cPer.Text = "01";
            // 
            // statsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_playerWins);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_exit);
            this.Name = "statsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connnect 4 Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Label lbl_playerWins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label lbl_games;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label lbl_pWins;
        private System.Windows.Forms.Label lbl_cWins;
        private System.Windows.Forms.Label lbl_pPer;
        private System.Windows.Forms.Label lbl_cPer;
        private System.Windows.Forms.TextBox txt_gamesPlayed;
        private System.Windows.Forms.TextBox txt_ties;
        private System.Windows.Forms.TextBox txt_pWins;
        private System.Windows.Forms.TextBox txt_pPer;
        private System.Windows.Forms.TextBox txt_cWins;
        private System.Windows.Forms.TextBox txt_cPer;
    }
}