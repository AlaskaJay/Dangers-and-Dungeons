using DangersAndDungeons.Model.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Player
    {
        private int x;
        private int y;
        private String display;

        public Player()
        {
            x = 3;
            y = 3;
        }

        public int getX()
        {
            return x;
        }

        public void setX(int value)
        {
            x = value;
        }

        public int getY()
        {
            return y;
        }

        public void setY(int value)
        {
            y = value;
        }

        public String getDisplay()
        {
            return display;
        }

        public void updateDisplay(Room room)
        {
            display = "";
            for (int i = 0; i < room.getMap().GetLength(0); i++)
            {
                for (int j = 0; j < room.getMap().GetLength(1); j++)
                {
                    if (i != y || j != x)
                        display += room.getMap()[i, j].Display;
                    else
                        display += 'P';
                }
                display += "\n";
            }
            display += "Hello, World!";
        }

        public void move(char dir, Room room)
        {
            Wall wall = new Wall();
            if (dir == 'N')
            {
                if (room.getMap()[x, y - 1].GetType() != wall.GetType())
                    y--;
                Console.Write("N, ");
            }
            else if(dir == 'S')
            {
                if (room.getMap()[x, y + 1].GetType() != wall.GetType())
                    y++;
                Console.Write("S, ");
            }
            else if(dir == 'W')
            {
                if (room.getMap()[x - 1, y].GetType() != wall.GetType())
                    x--;
                Console.Write("W, ");
            }
            else if(dir == 'E')
            {
                if (room.getMap()[x + 1, y].GetType() != wall.GetType())
                    x++;
                Console.Write("E, ");
            }
            Console.WriteLine(x+","+y);
            updateDisplay(room);
        }
    }
}
