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
        private String commandReply;
        private String map;
        private List<String> commandHistory;

        public Player()
        {
            coord = new Coord(3, 3);
            room = new Coord(0, 0);
            commandReply = "No Commands Entered Yet.";
            commandHistory = new List<String>();
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

        public String getMap()
        {
            return map;
        }

        public void updateDisplay(Dungeon dungeon)
        {
            display = commandReply + "\n";
            display += "You are in room: " + room.toString();// + " (" + room.GetHashCode() + ")";

            updateMap(dungeon);
        }

        public void updateMap(Dungeon dungeon)
        {
            map = "";
            for (int i = 0; i < dungeon.getRoom(room).getMap().GetLength(0); i++)
            {
                for (int j = 0; j < dungeon.getRoom(room).getMap().GetLength(1); j++)
                {
                    if (i != coord.getY() || j != coord.getX())
                        map += dungeon.getRoom(room).getMap()[j, i].Display;
                    else
                        map += 'P';
                }
                map += "\n";
            }
        }

        public void move(char dir, Dungeon dungeon)
        {
            Wall wall = new Wall();
            Door door = new Door();
            if (dir == 'N')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY() - 1].GetType() != wall.GetType())
                {
                    coord.north();
                    commandReply = "You move north.";
                    commandHistory.Add("Moved south via button");
                }
                else
                {
                    commandReply = "You cannot move north.";
                }
            }
            else if (dir == 'S')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY() + 1].GetType() != wall.GetType())
                {
                    coord.south();
                    commandReply = "You move south.";
                    commandHistory.Add("Moved south via button");
                }
                else
                {
                    commandReply = "You cannot move south.";
                }
            }
            else if (dir == 'W')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX() - 1, coord.getY()].GetType() != wall.GetType())
                {
                    coord.west();
                    commandReply = "You move west.";
                    commandHistory.Add("Moved west via button");
                }
                else
                {
                    commandReply = "You cannot move west.";
                }
            }
            else if(dir == 'E')
            {
                if (dungeon.getRoom(room).getMap()[coord.getX() + 1, coord.getY()].GetType() != wall.GetType())
                {
                    coord.east();
                    commandReply = "You move east.";
                    commandHistory.Add("Moved east via button");
                }
                else
                {
                    commandReply = "You cannot move east.";
                }
            }
            //Console.WriteLine(coord.getX() + ","+ coord.getY());

            if(dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() == door.GetType())
            {
                if(dir == 'N')
                {
                    room.south();
                    coord = new Coord(3, 5);
                    if(dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() == wall.GetType())
                    {
                        room.north();
                        coord = new Coord(3, 1);
                        commandReply = "You move north towards a door, but there is a wall on the other side.";
                        commandHistory.Add("Moved north towards a door via button, but was blocked.");
                    }
                    else
                    {
                        commandReply = "You move north through the door.";
                        commandHistory.Add("Moved north through a door via button");
                    }
                }
                else if(dir == 'S')
                {
                    room.north();
                    coord = new Coord(3, 1);
                    if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() == wall.GetType())
                    {
                        room.south();
                        coord = new Coord(3, 5);
                        commandReply = "You move south towards a door, but there is a wall on the other side.";
                        commandHistory.Add("Moved south towards a door via button, but was blocked.");
                    }
                    else
                    {
                        commandReply = "You move south through the door.";
                        commandHistory.Add("Moved south through a door via button");
                    }
                }
                else if(dir == 'W')
                {
                    coord = new Coord(5, 3);
                    room.west();
                    if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() == wall.GetType())
                    {
                        room.east();
                        coord = new Coord(1, 3);
                        commandReply = "You move west towards a door, but there is a wall on the other side.";
                        commandHistory.Add("Moved west towards a door via button, but was blocked.");
                    }
                    else
                    {
                        commandReply = "You move west through the door.";
                        commandHistory.Add("Moved west through a door via button");
                    }
                }
                else if(dir == 'E')
                {
                    coord = new Coord(1, 3);
                    room.east();
                    if (dungeon.getRoom(room).getMap()[coord.getX(), coord.getY()].GetType() == wall.GetType())
                    {
                        room.west();
                        coord = new Coord(5, 3);
                        commandReply = "You move east towards a door, but there is a wall on the other side.";
                        commandHistory.Add("Moved east towards a door via button, but was blocked.");
                    }
                    else
                    {
                        commandReply = "You move east through the door.";
                        commandHistory.Add("Moved east through a door via button");
                    }
                }
            }

            updateDisplay(dungeon);
        }

        public void acceptCommand(String command, Dungeon dungeon)
        {
            if (command.ToLower().Contains("teleport"))
            {
                teleport(command.Substring(9), dungeon);
            }
            else if (command.ToLower().Contains("history"))
            {
                displayHistory();
            }
            else if (command.ToLower().Contains("commands"))
                displayCommands();
            else if (command.Length == 0)
                commandReply = "No Command";
            else
                commandReply = "Invalid Command";
            commandHistory.Add(command);
            updateDisplay(dungeon);
        }

        public void displayHistory()
        {
            commandReply = "";
            foreach(String s in commandHistory)
            {
                commandReply = s + "\n" + commandReply;
            }
            commandReply = "You have entered these commands:\n" + commandReply;
        }

        public void displayCommands()
        {
            commandReply = "";
            foreach (String s in commandHistory)
            {
                if(!s.ToLower().Contains("button"))
                    commandReply = s + "\n" + commandReply;
            }
            commandReply = "You have entered these commands:\n" + commandReply;
        }

        public void teleport(String command, Dungeon dungeon)
        {
            Char[] text = command.ToCharArray();
            int numStart = 0;
            while (numStart < text.Length && (text[numStart] < '0' || text[numStart] > '9'))
                numStart++;
            if(text[0] == 'n' && command.Substring(numStart).Length > 0)
            {
                for(int i = 0; i < Int32.Parse(command.Substring(numStart)); i++)
                {
                    room.south();
                }
                commandReply = "You have teleported " + command.Substring(numStart) + "rooms north";
            }
            else if (text[0] == 's' && command.Substring(numStart).Length > 0)
            {
                for (int i = 0; i < Int32.Parse(command.Substring(numStart)); i++)
                {
                    room.north();
                }
                commandReply = "You have teleported " + command.Substring(numStart) + "rooms south";
            }
            else if (text[0] == 'e' && command.Substring(numStart).Length > 0)
            {
                for (int i = 0; i < Int32.Parse(command.Substring(numStart)); i++)
                {
                    room.east();
                }
                commandReply = "You have teleported " + command.Substring(numStart) + "rooms east";
            }
            else if (text[0] == 'w' && command.Substring(numStart).Length > 0)
            {
                for (int i = 0; i < Int32.Parse(command.Substring(numStart)); i++)
                {
                    room.west();
                }
                commandReply = "You have teleported " + command.Substring(numStart) + "rooms west";
            }
            else
            {
                commandReply = "Unable to teleport, check spelling and spacing";
            }
        }
    }
}
