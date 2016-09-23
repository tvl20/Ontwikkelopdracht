using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class Player : Entity
    {
        public string Class { get; set; }
        public int AttackLvl { get; set; }
        public int DefenceLvl { get; set; }
        public int MaxHP { get; set; }
        public int ActionpointsPerAttack { get; set; }
        public int MaxActionpoints { get; set; }
        public int Actionpoints { get; set; }
        public int XP { get; set; }

        public Player(Point location)
        {
            this.Location = location;
            this.Level = 0;
        }
    }
}
