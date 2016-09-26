using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OntwikkelopdrachtSE
{
    public class World
    {
        public List<Enemy> Enemies { get; set; }
        public Player Player { get; private set; }
        private Map Map;

        public World(string pathToMap, string _class)
        {
            Map = new Map(pathToMap);
            Player = new Player(Map.PlayerSpawnlocation, _class);
            Enemies = Map.EnemyDefault;
            UpdateEntities();
            UpdateMap();
        }

        public void UpdateMap()
        {
            //TODO Draw all the tiles on the map
        }

        public void UpdateEntities()
        {
            //TODO Draw all the Entities on the map
        }
    }
}
