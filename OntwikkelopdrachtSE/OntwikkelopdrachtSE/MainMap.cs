using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OntwikkelopdrachtSE
{
    public partial class MainMap : Form
    {
        /*
         * Font Ariel, 12.0f
         * one tile is 13x13
         */

        public World Level;

        public MainMap()
        {
            InitializeComponent();
            CharacterCreationDetails frm2 = new CharacterCreationDetails();
            frm2.ShowDialog();
            timer1.Enabled = true;
            Level = new World(@"C:\Users\Teun\Source\Repos\Ontwikkelopdracht2\OntwikkelopdrachtSE\OntwikkelopdrachtSE\Level0-1.txt", frm2._class, pn_main);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Level.UpdateMap(pn_main);
        }
    }
}
