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

        private void b_Start_Click(object sender, EventArgs e)
        {
            //to be deleted, when cleaning
        }

        private void cB_Difficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _game = new Game(this.p_GameBoard, cB_Difficulty.SelectedIndex);
            _game.Start();
        }
    }
}
