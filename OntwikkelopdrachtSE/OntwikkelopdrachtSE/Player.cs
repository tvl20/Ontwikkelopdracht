﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class Player : Entity
    {
        public CharacterCreationDetails.Class Class;
        public int AttackLvl { get; set; }
        public int DefenceLvl { get; set; }
        public int MaxHP { get; set; }
        public int MaxActionpoints { get; set; }
        public int ActionPointsRegen { get; set; }
        public int MovePointsRegen { get; set; }
        public int XP { get; set; }

        public Player(Point location, CharacterCreationDetails.Class _class) :base(location)
        {
            Level = 0;
            Class = _class;
        }
    }
}
