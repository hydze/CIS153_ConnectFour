
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_single
            // 
            this.btn_single.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_single.Location = new System.Drawing.Point(83, 226);
            this.btn_single.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(476, 69);
            this.btn_single.TabIndex = 0;
            this.btn_single.Text = "Single Player";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_double
            // 
            this.btn_double.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_double.Location = new System.Drawing.Point(83, 327);
            this.btn_double.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(476, 69);
            this.btn_double.TabIndex = 1;
            this.btn_double.Text = "Two Player";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // btn_statistics
            // 
            this.btn_statistics.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statistics.Location = new System.Drawing.Point(83, 432);
            this.btn_statistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_statistics.Name = "btn_statistics";
            this.btn_statistics.Size = new System.Drawing.Size(476, 69);
            this.btn_statistics.TabIndex = 2;
            this.btn_statistics.Text = "Statistics";
            this.btn_statistics.UseVisualStyleBackColor = true;
            this.btn_statistics.Click += new System.EventHandler(this.btn_statistics_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(83, 537);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(476, 69);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CIS153_FinalProject.Properties.Resources.connect4_logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(83, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.lbl_translate1.Location = new System.Drawing.Point(147, 154);
            this.lbl_translate1.Name = "lbl_translate1";
            this.lbl_translate1.Size = new System.Drawing.Size(213, 23);
            this.lbl_translate1.TabIndex = 5;
            this.lbl_translate1.Text = "Verbinden 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(665, 720);
            this.Controls.Add(this.lbl_translate1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_statistics);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_single);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

