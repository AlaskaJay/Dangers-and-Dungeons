using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Dungeon
    {
        private List<Room> map;

        public Dungeon()
        {
            map = new List<Room>();
            map.Add(new Room());
        }

        public List<Room> getMap()
        {
            return map;
        }

        public Room getRoom(int room)
        {
            return map[room];
        }
    }
}
