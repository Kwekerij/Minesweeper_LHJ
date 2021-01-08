
namespace Minesweeper_LHJ
{
    partial class Hilfe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hilfe));
            this.label_HelpText = new System.Windows.Forms.Label();
            this.b_HelpOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_HelpText
            // 
            this.label_HelpText.AutoSize = true;
            this.label_HelpText.BackColor = System.Drawing.Color.Transparent;
            this.label_HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HelpText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_HelpText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_HelpText.Location = new System.Drawing.Point(10, 49);
            this.label_HelpText.Name = "label_HelpText";
            this.label_HelpText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_HelpText.Size = new System.Drawing.Size(1092, 120);
            this.label_HelpText.TabIndex = 0;
            this.label_HelpText.Text = resources.GetString("label_HelpText.Text");
            this.label_HelpText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_HelpOK
            // 
            this.b_HelpOK.Location = new System.Drawing.Point(477, 200);
            this.b_HelpOK.Name = "b_HelpOK";
            this.b_HelpOK.Size = new System.Drawing.Size(100, 30);
            this.b_HelpOK.TabIndex = 1;
            this.b_HelpOK.Text = "Verstanden!";
            this.b_HelpOK.UseVisualStyleBackColor = true;
            this.b_HelpOK.Click += new System.EventHandler(this.b_HelpOK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(215)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(-37, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1600, 126);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(449, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "So wird gespielt:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hilfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1106, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_HelpOK);
            this.Controls.Add(this.label_HelpText);
            this.Controls.Add(this.label1);
            this.Name = "Hilfe";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_HelpText;
        private System.Windows.Forms.Button b_HelpOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}