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
    public partial class Hilfe : Form
    {
        public Hilfe()
        {
            InitializeComponent();
        }

        private void b_HelpOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
