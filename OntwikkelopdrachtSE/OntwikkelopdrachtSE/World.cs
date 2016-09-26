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
            foreach(Tile t in Map.Tiles)
            {
                //TODO draw the tile, if there is a player draw the player, if there is an enemy draw the enemy
                // if there is a powerup draw that and if there is a wall draw that
            }
        }

        public void UpdateEntities()
        {
            //TODO Draw all the Entities on the map
        }
    }
}
