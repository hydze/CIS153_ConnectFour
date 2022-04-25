
namespace CIS153_FinalProject
{
    partial class Form1
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
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_double = new System.Windows.Forms.Button();
            this.btn_statistics = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_translate1 = new System.Windows.Forms.Label();
            this.lbl_singleInfo = new System.Windows.Forms.Label();
            this.lbl_doubleInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_single
            // 
            this.btn_single.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_single.Location = new System.Drawing.Point(62, 184);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(357, 56);
            this.btn_single.TabIndex = 0;
            this.btn_single.Text = "Single Player";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            this.btn_single.MouseLeave += new System.EventHandler(this.btn_single_mouseleave);
            this.btn_single.MouseHover += new System.EventHandler(this.btn_single_mousehover);
            // 
            // btn_double
            // 
            this.btn_double.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_double.Location = new System.Drawing.Point(62, 266);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(357, 56);
            this.btn_double.TabIndex = 1;
            this.btn_double.Text = "Two Player";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            this.btn_double.MouseLeave += new System.EventHandler(this.btn_double_mouseleave);
            this.btn_double.MouseHover += new System.EventHandler(this.btn_double_mousehover);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics.Location = new System.Drawing.Point(62, 351);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(357, 56);
            this.btn_statistics.TabIndex = 2;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(62, 436);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(357, 56);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS153_FinalProject.Properties.Resources.connect4_logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(62, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_translate1
            // 
            this.lbl_translate1.AutoSize = true;
            this.lbl_translate1.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_translate1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_translate1.Location = new System.Drawing.Point(106, 132);
            this.lbl_translate1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_translate1.Name = "lbl_translate1";
            this.lbl_translate1.Size = new System.Drawing.Size(176, 19);
            this.lbl_translate1.TabIndex = 5;
            this.lbl_translate1.Text = "Verbinden 4";
            // 
            // lbl_singleInfo
            // 
            this.lbl_singleInfo.AutoSize = true;
            this.lbl_singleInfo.Font = new System.Drawing.Font("Goudy Stout", 10.2F);
            this.lbl_singleInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_singleInfo.Location = new System.Drawing.Point(94, 243);
            this.lbl_singleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_singleInfo.Name = "lbl_singleInfo";
            this.lbl_singleInfo.Size = new System.Drawing.Size(317, 19);
            this.lbl_singleInfo.TabIndex = 6;
            this.lbl_singleInfo.Text = "A 1v1 battle vs. an AI!";
            this.lbl_singleInfo.Visible = false;
            // 
            // lbl_doubleInfo
            // 
            this.lbl_doubleInfo.AutoSize = true;
            this.lbl_doubleInfo.Font = new System.Drawing.Font("Goudy Stout", 10.2F);
            this.lbl_doubleInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_doubleInfo.Location = new System.Drawing.Point(52, 329);
            this.lbl_doubleInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_doubleInfo.Name = "lbl_doubleInfo";
            this.lbl_doubleInfo.Size = new System.Drawing.Size(389, 19);
            this.lbl_doubleInfo.TabIndex = 7;
            this.lbl_doubleInfo.Text = "A 1v1 Player Deathmatch!";
            this.lbl_doubleInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = global::CIS153_FinalProject.Properties.Resources.arcade;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(499, 585);
            this.Controls.Add(this.lbl_doubleInfo);
            this.Controls.Add(this.lbl_singleInfo);
            this.Controls.Add(this.lbl_translate1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_single);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Button btn_statistics;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_translate1;
        private System.Windows.Forms.Label lbl_singleInfo;
        private System.Windows.Forms.Label lbl_doubleInfo;
    }
}

