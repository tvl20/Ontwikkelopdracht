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
            Tiles = new List<Tile>();
            EnemyDefault = new List<Enemy>();
            //in the file everything has to go on ONE line, otherwise you get an error!!
            string text = System.IO.File.ReadAllText(path);
            int counter = 0;
            for (int y = 1; y < 31; y++)
            {
                for (int x = 1; x < 31; x++)
                {
                    if(text.Substring(counter, 1) == "W")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Wall));
                    }
                    counter++;
                }
            }
            //TODO vanuit txt file map laden, lists vullen en player position opzoeken
        }
    }
}
