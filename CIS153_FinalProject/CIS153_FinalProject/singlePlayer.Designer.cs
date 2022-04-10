
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
            this.btn_exit.Location = new System.Drawing.Point(83, 597);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(476, 69);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_main
            // 
            this.btn_main.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main.Location = new System.Drawing.Point(83, 504);
            this.btn_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(476, 69);
            this.btn_main.TabIndex = 6;
            this.btn_main.Text = "Main Menu";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // ptr_board1
            // 
            this.ptr_board1.BackColor = System.Drawing.Color.White;
            this.ptr_board1.Image = global::CIS153_FinalProject.Properties.Resources._377_3777584_connectbg_size_connect_4_board_transparent;
            this.ptr_board1.Location = new System.Drawing.Point(75, 72);
            this.ptr_board1.Name = "ptr_board1";
            this.ptr_board1.Size = new System.Drawing.Size(491, 425);
            this.ptr_board1.TabIndex = 7;
            this.ptr_board1.TabStop = false;
            // 
            // singlePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(665, 720);
            this.ControlBox = false;
            this.Controls.Add(this.ptr_board1);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_exit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "singlePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "singlePlayer";
            ((System.ComponentModel.ISupportInitialize)(this.ptr_board1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.PictureBox ptr_board1;
    }
}