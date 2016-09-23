using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class Tile
    {
        public string Type { get; set; }
        Point Location { get; }

        public Tile(int x, int y, string type)
        {
            Location = new Point(x, y);
            Type = type;
        }
    }
}
