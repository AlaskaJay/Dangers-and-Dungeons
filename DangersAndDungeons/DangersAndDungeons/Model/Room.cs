using DangersAndDungeons.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Room
    {
        private Tile[,] map;

        public Room()
        {
            map = new Tile[7, 7];
            for(int i = 0; i < map.GetLength(0); i++)
            {
                map[0, i] = new Wall();
                map[map.GetLength(0)-1, i] = new Wall();
            }
            for (int i = 0; i < map.GetLength(1); i++)
            {
                map[i, 0] = new Wall();
                map[i, map.GetLength(1) - 1] = new Wall();
            }
            for (int i = 1; i < map.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < map.GetLength(1) - 1; j++)
                {
                    map[i, j] = new Floor();
                }
            }
            map[3, 0] = new Door('N');
            map[0, 3] = new Door('W');
            map[6, 3] = new Door('E');
            map[3, 6] = new Door('S');
        }

        public Room(Coord previous, char direction)
        {
            
        }

        public Tile[,] getMap()
        {
            return map;
        }

        public void getMap(Tile[,] value)
        {
            map = value;
        }
    }
}
