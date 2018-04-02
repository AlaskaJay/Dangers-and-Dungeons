using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model.Actors
{
    class Player : Actor
    {
        public char symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int room { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Item> stash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void move(int direction, Dungeon dungeon)
        {
            if(direction == 0)
            {
                //North
            }
            else if(direction == 1)
            {
                //East
            }
            else if (direction == 2)
            {
                //South
            }
            else if (direction == 3)
            {
                //West
            }
        }
    }
}
