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

        private void cB_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _game = new Game(this.p_GameBoard, cB_Difficulty.SelectedIndex);
            _game.Tick += new EventHandler(GameTick);
            _game.DismantledMinesChanged += new EventHandler(GameDismantledMinesChanged);
            _game.Start();
            label_Bombs.Text = _game.Mines.ToString();
        }
        private void GameTick(object sender, EventArgs e)
        {
            label_Timer.Text = _game.Time.ToString();
        }

        private void GameDismantledMinesChanged(object sender, EventArgs e)
        {
            label_Bombs.Text = (_game.Mines - _game.DismantledMines).ToString();
        }

        private void label_Help_Click(object sender, EventArgs e)
        {
            Hilfe MyHilfeForm = new Hilfe();
            MyHilfeForm.Show();
        }
    }
}
