
namespace CIS153_FinalProject
{
    partial class twoPlayer
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
            this.ptr_board2 = new System.Windows.Forms.PictureBox();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_board2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(30, 524);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(357, 56);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_main
            // 
            this.btn_main.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.Location = new System.Drawing.Point(30, 462);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(357, 56);
            this.btn_main.TabIndex = 6;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // ptr_board2
            // 
            this.ptr_board2.BackColor = System.Drawing.Color.White;
            this.ptr_board2.Image = global::CIS153_FinalProject.Properties.Resources._377_3777584_connectbg_size_connect_4_board_transparent;
            this.ptr_board2.Location = new System.Drawing.Point(133, 11);
            this.ptr_board2.Margin = new System.Windows.Forms.Padding(2);
            this.ptr_board2.Name = "ptr_board2";
            this.ptr_board2.Size = new System.Drawing.Size(491, 423);
            this.ptr_board2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptr_board2.TabIndex = 8;
            this.ptr_board2.TabStop = false;
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_player1.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_player1.ForeColor = System.Drawing.Color.Red;
            this.lbl_player1.Location = new System.Drawing.Point(464, 539);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(229, 27);
            this.lbl_player1.TabIndex = 9;
            this.lbl_player1.Text = "RED\'s Turn";
            this.lbl_player1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(417, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "YELLOW\'s Turn";
            this.label1.Visible = false;
            // 
            // twoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(747, 591);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.ptr_board2);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_exit);
            this.Name = "twoPlayer";
            this.Text = "twoPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.ptr_board2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.PictureBox ptr_board2;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label label1;
    }
}