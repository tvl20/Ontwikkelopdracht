using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class Enemy : Entity
    {
        public string Type;

        public Enemy(Point location, string type)
        {
            this.Location = location;
            Type = type;
        }
    }
}
