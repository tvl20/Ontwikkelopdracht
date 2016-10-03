﻿using System;
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
            //in the file everything has to go on ONE line, otherwise you'll get an error!!
            string text = System.IO.File.ReadAllText(path);
            int counter = 0;
            for (int y = 1; y < 31; y++)
            {
                for (int x = 1; x < 31; x++)
                {
                    if (text.Substring(counter, 1) == "X")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Blank));
                    }
                    else if (text.Substring(counter, 1) == "E")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Enemy));
                    }
                    else if (text.Substring(counter, 1) == "P")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Player));
                    }
                    else if (text.Substring(counter, 1) == "W")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Wall));
                    }
                    else if (text.Substring(counter,1) == "T")
                    {
                        Tiles.Add(new Tile(x, y, Tile.type.Trap));
                    }
                    counter++;
                }
            }
            //TODO vanuit txt file map laden, lists vullen en player position opzoeken
        }
    }
}
