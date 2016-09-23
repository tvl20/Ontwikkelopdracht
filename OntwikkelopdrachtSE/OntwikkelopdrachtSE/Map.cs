using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class Map
    {
        public List<Tile> Tiles { get; }
        public List<Enemy> EnemyDefault { get; }
        public Point PlayerSpawnlocation { get; }

        public Map(string path)
        {
            //TODO vanuit txt file map laden, lists vullen en player position opzoeken
        }
    }
}
