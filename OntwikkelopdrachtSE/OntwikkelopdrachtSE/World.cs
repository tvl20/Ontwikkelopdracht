using System;
using System.Collections.Generic;
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

        public World(string pathToMap, Player p)
        {
            Player = p;
            Map = new Map(pathToMap);
            //TODO update the location of the player with the spawnlocation
            //TODO update the list of Enemies to the Default list of enemys (in map class)
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
