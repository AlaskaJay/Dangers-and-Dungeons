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
        private Coord room;
        private Coord coord;
        private String display;

        public Player()
        {
            coord = new Coord(3, 3);
            room = new Coord(0, 0);
        }

        public int getX()
        {
            return coord.getX();
        }

        public void setX(int value)
        {
            coord.setX(value);
        }

        public int getY()
        {
            return coord.getY();
        }

        public void setY(int value)
        {
            coord.setY(value);
        }

        public Coord getRoom()
        {
            return room;
        }

        public void setRoom(Coord value)
        {
            room = value;
        }

        public String getDisplay()
        {
            return display;
        }

        public void updateDisplay(Dungeon dungeon)
        {
            display = "";
            for (int i = 0; i < dungeon.getRoom(room).getMap().GetLength(0); i++)
            {
                for (int j = 0; j < dungeon.getRoom(room).getMap().GetLength(1); j++)
                {
                    if (i != coord.getY() || j != coord.getX())
                        display += dungeon.getRoom(room).getMap()[j, i].Display;
                    else
                        display += 'P';
                }
                display += "\n";
            }
            display += "You are in room: " + room.toString();
        }

        public void move(char dir, Dungeon dungeon)
        {
            Wall wall = new Wall();
            Door door = new Door();
            if (dir == 'N')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY() - 1].GetType() != wall.GetType())
                    coord.north();
                //Console.Write("N, ");
            }
            else if(dir == 'S')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY() + 1].GetType() != wall.GetType())
                    coord.south();
                //Console.Write("S, ");
            }
            else if(dir == 'W')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX() - 1, coord.getY()].GetType() != wall.GetType())
                    coord.west();
                //Console.Write("W, ");
            }
            else if(dir == 'E')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX() + 1, coord.getY()].GetType() != wall.GetType())
                    coord.east();
                //Console.Write("E, ");
            }
            //Console.WriteLine(coord.getX() + ","+ coord.getY());

            if(dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() != door.GetType())
            {

            }

            updateDisplay(dungeon);
        }
    }
}
