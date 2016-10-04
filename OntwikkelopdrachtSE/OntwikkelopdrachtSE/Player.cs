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
        public CharacterCreationDetails.Class Class;
        public int AttackLvl { get; set; }
        public int DefenceLvl { get; set; }
        public int MaxHP { get; }
        public int MaxActionpoints { get; }
        public int MaxMovepoints { get; }
        public int XP { get; set; }

        public Player(Point location, CharacterCreationDetails.Class _class) :base(location)
        {
            Level = 0;
            Class = _class;
            if(Class == CharacterCreationDetails.Class.Knight)
            {
                AttackLvl = 3;
                DefenceLvl = 3;
                MaxHP = 12;
                MaxActionpoints = 10;
                ActionPointsRegen = 2;
                ActionpointsPerAttack = 2;
                MaxMovepoints = 12;
                MovePointsRegen = 2;
                MovePointsPerMove = 3;
            }
            else if(Class == CharacterCreationDetails.Class.Slugger)
            {
                AttackLvl = 5;
                DefenceLvl = 3;
                MaxHP = 12;
                MaxActionpoints = 7;
                ActionPointsRegen = 2;
                ActionpointsPerAttack = 3;
                MaxMovepoints = 9;
                MovePointsRegen = 2;
                MovePointsPerMove = 3;
            }
            else if (Class == CharacterCreationDetails.Class.Crusader)
            {
                AttackLvl = 2;
                DefenceLvl = 5;
                MaxHP = 20;
                MaxActionpoints = 16;
                ActionPointsRegen = 1;
                ActionpointsPerAttack = 2;
                MaxMovepoints = 10;
                MovePointsRegen = 2;
                MovePointsPerMove = 5;
            }
            else if (Class == CharacterCreationDetails.Class.Paladin)
            {
                AttackLvl = 3;
                DefenceLvl = 2;
                MaxHP = 12;
                MaxActionpoints = 16;
                ActionPointsRegen = 3;
                ActionpointsPerAttack = 1;
                MaxMovepoints = 16;
                MovePointsRegen = 2;
                MovePointsPerMove = 2;
            }
        }
    }
}
