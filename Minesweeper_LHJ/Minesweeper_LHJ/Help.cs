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
    public partial class Help : Form
    {
        /// <summary>
        /// constructor, just InitializeComponent
        /// </summary>
        public Help()
        {
            InitializeComponent();
        }
        /// <summary>
        /// method to close the help window
        /// </summary>
        /// <param name="sender">reference to the control that raised the event</param>
        /// <param name="e">contains event data</param>
        private void b_HelpOK_Click(object sender, EventArgs e)
        {
            this.Close(); //schließt das Fenster
        }
    }
}
