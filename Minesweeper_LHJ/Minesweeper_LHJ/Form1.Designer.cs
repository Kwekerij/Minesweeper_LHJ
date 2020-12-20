
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
            this.b_Start = new System.Windows.Forms.Button();
            this.cB_Difficulty = new System.Windows.Forms.ComboBox();
            this.p_GameBoard = new System.Windows.Forms.Panel();
            this.label_Bombs = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_Start
            // 
            this.b_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start.Location = new System.Drawing.Point(320, 8);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(118, 40);
            this.b_Start.TabIndex = 0;
            this.b_Start.Text = "Start";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // cB_Difficulty
            // 
            this.cB_Difficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Difficulty.FormattingEnabled = true;
            this.cB_Difficulty.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cB_Difficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cB_Difficulty.Location = new System.Drawing.Point(23, 15);
            this.cB_Difficulty.Name = "cB_Difficulty";
            this.cB_Difficulty.Size = new System.Drawing.Size(113, 30);
            this.cB_Difficulty.TabIndex = 1;
            // 
            // p_GameBoard
            // 
            this.p_GameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(215)))), ((int)(((byte)(81)))));
            this.p_GameBoard.Enabled = false;
            this.p_GameBoard.Location = new System.Drawing.Point(0, 58);
            this.p_GameBoard.Name = "p_GameBoard";
            this.p_GameBoard.Size = new System.Drawing.Size(500, 441);
            this.p_GameBoard.TabIndex = 2;
            // 
            // label_Bombs
            // 
            this.label_Bombs.AutoSize = true;
            this.label_Bombs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bombs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Bombs.Location = new System.Drawing.Point(172, 16);
            this.label_Bombs.Name = "label_Bombs";
            this.label_Bombs.Size = new System.Drawing.Size(52, 29);
            this.label_Bombs.TabIndex = 3;
            this.label_Bombs.Text = "100";
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Timer.Location = new System.Drawing.Point(473, 15);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(52, 29);
            this.label_Timer.TabIndex = 4;
            this.label_Timer.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(523, 525);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.label_Bombs);
            this.Controls.Add(this.p_GameBoard);
            this.Controls.Add(this.cB_Difficulty);
            this.Controls.Add(this.b_Start);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.ComboBox cB_Difficulty;
        private System.Windows.Forms.Panel p_GameBoard;
        private System.Windows.Forms.Label label_Bombs;
        private System.Windows.Forms.Label label_Timer;
    }
}

