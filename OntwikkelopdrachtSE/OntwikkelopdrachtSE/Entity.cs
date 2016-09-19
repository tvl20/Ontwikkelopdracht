using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    class Entity
    {
        public Point Location { get; set; }
        public int HP { get; set; }
        public char Direction { get; set; }
        public int Level { get; set; }

        public void UpdateLocation(Point newLocation)
        {
            Location = newLocation;
        }

        public void Move()
        {
            //TODO make the player move in the current direction
        }

        public void Attack()
        {
            //TODO attack in the current direction
        }
    }
}
