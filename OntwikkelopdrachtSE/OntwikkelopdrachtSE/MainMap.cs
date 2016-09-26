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
        public World Level;

        public MainMap()
        {
            InitializeComponent();
            CharacterCreationDetails frm2 = new CharacterCreationDetails();
            frm2.ShowDialog();
            timer1.Enabled = true;
            Level = new World(@"C:\Users\Teun\Source\Repos\Ontwikkelopdracht\OntwikkelopdrachtSE\OntwikkelopdrachtSE\Level0-1.txt", frm2.Class);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = pn_main.CreateGraphics();
            for(int i = 1; i < 16; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    g.DrawString("G", new Font("Arial", 12.0f), Brushes.White, j * 13, i*13-13);
                }
                g.DrawString("Q", new Font("Arial", 12.0f), Brushes.White, 0, i * 13 - 13);
            }
        }
    }
}
