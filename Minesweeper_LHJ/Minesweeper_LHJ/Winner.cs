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
    public partial class Winner : Form
    {
        /// <summary>
        /// constructor, just InitializeComponent
        /// </summary>
        public Winner()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method to close the winner window
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
        /// <param name="e">contains event data</param>
        private void b_WinnerClose_Click(object sender, EventArgs e)
        {
            this.Close(); //schließt das Fenster
        }
    }
}
