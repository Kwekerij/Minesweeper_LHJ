﻿
namespace Minesweeper_LHJ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cB_Difficulty = new System.Windows.Forms.ComboBox();
            this.p_GameBoard = new System.Windows.Forms.Panel();
            this.label_Bombs = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.label_Help = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Difficulty
            // 
            this.cB_Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Difficulty.FormattingEnabled = true;
            this.cB_Difficulty.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cB_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cB_Difficulty.Location = new System.Drawing.Point(15, 15);
            this.cB_Difficulty.Margin = new System.Windows.Forms.Padding(2);
            this.cB_Difficulty.Name = "cB_Difficulty";
            this.cB_Difficulty.Size = new System.Drawing.Size(100, 32);
            this.cB_Difficulty.TabIndex = 1;
            this.cB_Difficulty.SelectedIndexChanged += new System.EventHandler(this.cB_Difficulty_SelectedIndexChanged);
            // 
            // p_GameBoard
            // 
            this.p_GameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(215)))), ((int)(((byte)(81)))));
            this.p_GameBoard.Enabled = false;
            this.p_GameBoard.Location = new System.Drawing.Point(0, 59);
            this.p_GameBoard.Margin = new System.Windows.Forms.Padding(2);
            this.p_GameBoard.Name = "p_GameBoard";
            this.p_GameBoard.Size = new System.Drawing.Size(375, 358);
            this.p_GameBoard.TabIndex = 2;
            // 
            // label_Bombs
            // 
            this.label_Bombs.AutoSize = true;
            this.label_Bombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bombs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Bombs.Location = new System.Drawing.Point(153, 20);
            this.label_Bombs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Bombs.Name = "label_Bombs";
            this.label_Bombs.Size = new System.Drawing.Size(40, 24);
            this.label_Bombs.TabIndex = 3;
            this.label_Bombs.Text = "100";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Timer.Location = new System.Drawing.Point(224, 20);
            this.label_Timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(40, 24);
            this.label_Timer.TabIndex = 4;
            this.label_Timer.Text = "000";
            // 
            // label_Help
            // 
            this.label_Help.AutoSize = true;
            this.label_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Help.Location = new System.Drawing.Point(348, 17);
            this.label_Help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Help.Name = "label_Help";
            this.label_Help.Size = new System.Drawing.Size(20, 24);
            this.label_Help.TabIndex = 5;
            this.label_Help.Text = "?";
            this.label_Help.Click += new System.EventHandler(this.label_Help_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 42);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(189, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 42);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(376, 421);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Help);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label_Bombs);
            this.Controls.Add(this.p_GameBoard);
            this.Controls.Add(this.cB_Difficulty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cB_Difficulty;
        private System.Windows.Forms.Panel p_GameBoard;
        private System.Windows.Forms.Label label_Bombs;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Label label_Help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

