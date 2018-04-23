using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Dungeon
    {
        private Dictionary<Coord, Room> map;

        public Dungeon()
        {
            map = new Dictionary<Coord, Room>(new Coord(0, 0));
            map[new Coord(0, 0)] = new Room();
        }

        public Dictionary<Coord, Room> getMap()
        {
            return map;
        }

        public Room getRoom(Coord room)
        {
            if(map.ContainsKey(room))
                return map[room];
            map[room] = new Room();
            return map[room];
        }

        public Room getRoom(int x, int y)
        {
            return map[new Coord(0, 0)];
        }
    }
}
