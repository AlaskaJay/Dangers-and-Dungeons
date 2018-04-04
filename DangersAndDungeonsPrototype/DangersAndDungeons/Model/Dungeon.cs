using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Dungeon
    {
        private List<Room> rooms;

        public Dungeon()
        {
            rooms = new List<Room>();
            rooms.Add(new Room());
        }

        public List<Room> getRooms()
        {
            return rooms;
        }

        public Room getRoom(int room)
        {
            return rooms[room];
        }
    }
}
