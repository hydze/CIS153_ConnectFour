
namespace CIS153_FinalProject
{
    partial class singlePlayer
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
            this.ptr_board1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptr_board1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(94, 524);
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
            this.btn_main.Location = new System.Drawing.Point(94, 453);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(357, 56);
            this.btn_main.TabIndex = 6;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // ptr_board1
            // 
            this.ptr_board1.BackColor = System.Drawing.Color.White;
            this.ptr_board1.Image = global::CIS153_FinalProject.Properties.Resources._377_3777584_connectbg_size_connect_4_board_transparent;
            this.ptr_board1.Location = new System.Drawing.Point(37, 20);
            this.ptr_board1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ptr_board1.Name = "ptr_board1";
            this.ptr_board1.Size = new System.Drawing.Size(491, 423);
            this.ptr_board1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptr_board1.TabIndex = 7;
            this.ptr_board1.TabStop = false;
            // 
            // singlePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(564, 616);
            this.ControlBox = false;
            this.Controls.Add(this.ptr_board1);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_exit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "singlePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single Player";
            ((System.ComponentModel.ISupportInitialize)(this.ptr_board1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.PictureBox ptr_board1;
    }
}