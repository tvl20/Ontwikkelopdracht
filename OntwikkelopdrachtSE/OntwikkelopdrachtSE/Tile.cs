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
        public enum type { Trap, Blank, Wall, Enemy, Player };

        public type Type { get; set; }
        public Point Location { get; }

        public Tile(int x, int y, type _type)
        {
            Location = new Point(x, y);
            Type = _type;
        }
    }
}
