using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_LHJ
{
    public partial class Form1 : Form
    {
        private Game _game;
        public Form1()
        {
            InitializeComponent();
            cB_Difficulty.SelectedIndex = 1;
        }
        /// <summary>
        /// method to start the game with the selected difficulty
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
        private void cB_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cB_Difficulty.SelectedIndex) //verschiebt das Hilfe label immer an den Rand
            {
                case 0: //easy
                    label_Help.Location = new Point(405, 21);
                    break;
                case 1: //medium
                    label_Help.Location = new Point(505, 21);
                    break;
                case 2: //hard
                    label_Help.Location = new Point(555, 21);
                    break;
            }
            Cursor.Current = Cursors.WaitCursor; //da das Spiel ein wenig lädt wollte ich dem user das einfach viusalisieren mit dem warte cursor
            _game = new Game(this.p_GameBoard, cB_Difficulty.SelectedIndex); //erstellt ein neues game, das panel und die gewählte Schwierigkeit wird mitgegeben
            _game.Tick += new EventHandler(GameTick); //Game Tick method wird ausgeführt wenn das Tick event kommt
            _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged); //abonniert die method ans event
            _game.Start(); //das game wird gestartet mit der _game.Start method
            label_Bombs.Text = _game.Mines.ToString(); //Die Anzahl der Minen wird angezeigt, damit das vor dem ersten Klick auch schon ordentlich da steht

            for (int index = Application.OpenForms.Count - 1; index >= 0; index--) //geht alle aktuell geöffneten Forms durch und schließt, falls vorhanden, das WinnerForms
            {
                if (Application.OpenForms[index].Name == "Winner")
                {
                    Application.OpenForms[index].Close();
                }
            }
        }
        /// <summary>
        /// method to update the label_Timer with the current time
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
        private void GameTick(object sender, EventArgs e)
        {
            label_Timer.Text = _game.Time.ToString();
        }

        /// <summary>
        /// method to update label_Bombs with the current dismantled mines
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
        private void GameDismantledMinesChanged(object sender, EventArgs e)
        {
            label_Bombs.Text = (_game.Mines - _game.DismantledMines).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
        private void label_Help_Click(object sender, EventArgs e)
        {
            Help _help = new Help();
            _help.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
		/// <param name="e">contains event data</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Bilder\Flagge.png");
            pictureBox2.Image = Image.FromFile(System.Windows.Forms.Application.StartupPath + @"\Bilder\Uhr.png");
        }
    }
}
