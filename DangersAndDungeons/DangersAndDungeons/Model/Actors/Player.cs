using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model.Actors
{
    class Player : Actor
    {
        public Player()
        {
            room = 0;
            x = 3;
            y = 5;
        }

        public char symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int room { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Item> stash { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void addItem(Item pickUp)
        {
            stash.Add(pickUp);
        }

        public String display(Dungeon dungeon)
        {
            String display = "";

            for(int i = 0; i < dungeon.getRoom(0).getTiles().GetLength(0); i++)
            {
                for (int j = 0; j < dungeon.getRoom(0).getTiles().GetLength(1); j++)
                {
                    if (j == x && i == y)
                        display += symbol;
                    else
                        display += dungeon.getRoom(0).getTile(j, i).toString();
                }
                display += "\n";
            }
            display += "\n";
            display += "You are currently in room " + 0 + ".";

            return display;
        }

        public void move(int direction, Dungeon dungeon)
        {
            WallTile wall = new WallTile();
            if (direction == 0)
            {
                //North
                if (dungeon.getRoom(0).getTile(x, y-1).GetType() != wall.GetType())
                    y -= 1;
            }
            else if(direction == 1)
            {
                //East
                if (dungeon.getRoom(0).getTile(x+1, y).GetType() != wall.GetType())
                    x += 1;
            }
            else if (direction == 2)
            {
                //South
                if (dungeon.getRoom(0).getTile(x, y+1).GetType() != wall.GetType())
                    y += 1;
            }
            else if (direction == 3)
            {
                //West
                if (dungeon.getRoom(0).getTile(x-1, y).GetType() != wall.GetType())
                    x -= 1;
            }
        }
    }
}
