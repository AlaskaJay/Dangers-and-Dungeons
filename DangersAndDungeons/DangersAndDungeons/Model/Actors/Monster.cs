using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model.Actors
{
    class Monster : Actor
    {
        public char symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int room { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Item> stash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void addItem(Item pickUp)
        {
            throw new NotImplementedException();
        }

        public void move(int direction, Dungeon dungeon)
        {
            throw new NotImplementedException();
        }
    }
}
