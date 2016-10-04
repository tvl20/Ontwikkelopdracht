using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public abstract class Entity
    {
        public Point Location { get; set; }
        public int HP { get; set; }
        public char Direction { get; set; }
        public int Level { get; set; }
        public int MovePoints { get; set; }
        public int MovePointsPerMove { get; set; }
        public int MovePointsRegen { get; set; }
        public int Actionpoints { get; set; }
        public int ActionpointsPerAttack { get; set; }
        public int ActionPointsRegen { get; set; }

        public Entity(Point location)
        {
            Location = location;
        }

        public void UpdateLocation(Point newLocation)
        {
            Location = newLocation;
        }

        public void Move(char _direction)
        {
            if (Direction == _direction)
            {
                Point newPoint = this.Location;
                switch (Direction)
                {
                    case 'N':
                        newPoint.Y = newPoint.Y - 1;
                        break;
                    case 'E':
                        newPoint.X = newPoint.X + 1;
                        break;
                    case 'S';
                        newPoint.Y = newPoint.Y + 1;
                        break;
                    case 'W':
                        newPoint.X = newPoint.X - 1;
                        break;
                }
                MovePoints = MovePoints - MovePointsPerMove;
                this.UpdateLocation(newPoint);
            }
            else
            {
                Direction = _direction;
            }
        }

        public void Attack()
        {
            //TODO attack in the current direction
        }
    }
}
