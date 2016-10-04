using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OntwikkelopdrachtSE
{
    public class World
    {
        public List<Enemy> Enemies { get; set; }
        public Player Player { get; private set; }
        private Map Map;

        public World(string pathToMap, CharacterCreationDetails.Class _class, Panel p)
        {
            Map = new Map(pathToMap);
            Player = new Player(Map.PlayerSpawnlocation, _class);
            Enemies = Map.EnemyDefault;
            UpdateEntities();
            UpdateMap(p);
        }

        public void UpdateMap(Panel p)
        {
            foreach(Tile t in Map.Tiles)
            {
                Graphics g = p.CreateGraphics();
                Font _font = new Font("Arial", 12.0f);
                Point _Location = new Point((t.Location.X-1) * 13+8, (t.Location.Y-1) * 13+8);
                if ((t.Type == Tile.type.Blank))
                {
                    g.DrawString("~", _font, Brushes.White, _Location);
                }
                else if(t.Type == Tile.type.Enemy)
                {
                    g.DrawString("E", _font, Brushes.White, _Location);
                }
                else if(t.Type == Tile.type.Wall)
                {
                    g.DrawString("W", _font, Brushes.White, _Location);
                }
                else if(t.Type == Tile.type.Player)
                {
                    g.DrawString("P", _font, Brushes.White, _Location);
                }
                else if(t.Type == Tile.type.Trap)
                {
                    g.DrawString("-", _font, Brushes.White, _Location);
                }
                else if(t.Type == Tile.type.Goal)
                {
                    g.DrawString("G", _font, Brushes.White, _Location);
                }
            }
        }

        public void UpdateEntities()
        {
            //TODO Update all the stats of the entities

        }
    }
}
