using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Room
    {
        private Tile[,] tiles;

        public Room()
        {
            tiles = new Tile[7, 7];
            for(int i = 0; i < 7; i++)
            {
                tiles[i, 0] = new WallTile();
                tiles[i, 6] = new WallTile();
                tiles[6, i] = new WallTile();
                tiles[0, i] = new WallTile();
            }
            tiles[0, 3] = new DoorTile();
            tiles[6, 3] = new DoorTile();
            tiles[3, 0] = new DoorTile();
            tiles[3, 6] = new DoorTile();
        }

        public Room(int size)
        {

        }

        public Room(int width, int height)
        {

        }

        public Tile[,] getTiles()
        {
            return tiles;
        }

        public Tile getTile(int x, int y)
        {
            return tiles[x, y];
        }
    }
}
