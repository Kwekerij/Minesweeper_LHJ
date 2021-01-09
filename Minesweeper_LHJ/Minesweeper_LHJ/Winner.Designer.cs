
namespace Minesweeper_LHJ
{
    partial class Winner
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
            this.label_Winner = new System.Windows.Forms.Label();
            this.b_WinnerClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Winner
            // 
            this.label_Winner.AutoSize = true;
            this.label_Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Winner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Winner.Location = new System.Drawing.Point(25, 46);
            this.label_Winner.Name = "label_Winner";
            this.label_Winner.Size = new System.Drawing.Size(351, 42);
            this.label_Winner.TabIndex = 0;
            this.label_Winner.Text = "Du hast gewonnen!!";
            // 
            // b_WinnerClose
            // 
            this.b_WinnerClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_WinnerClose.Location = new System.Drawing.Point(152, 107);
            this.b_WinnerClose.Name = "b_WinnerClose";
            this.b_WinnerClose.Size = new System.Drawing.Size(103, 34);
            this.b_WinnerClose.TabIndex = 1;
            this.b_WinnerClose.Text = "Super!";
            this.b_WinnerClose.UseVisualStyleBackColor = true;
            this.b_WinnerClose.Click += new System.EventHandler(this.b_WinnerClose_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(405, 171);
            this.Controls.Add(this.b_WinnerClose);
            this.Controls.Add(this.label_Winner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Winner;
        private System.Windows.Forms.Button b_WinnerClose;
    }
}