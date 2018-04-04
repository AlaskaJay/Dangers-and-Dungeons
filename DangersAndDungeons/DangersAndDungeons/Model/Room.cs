using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Room
    {
        private char[,] map;

        public Room()
        {
            map = new char[7, 7];
            for (int i = 0; i < map.GetLength(0) && i < map.GetLength(1); i++)
            {
                Console.WriteLine(i);
                map[0, i] = 'W';
                map[6, i] = 'W';
                map[i, 0] = 'W';
                map[i, 6] = 'W';
            }
            for (int i = 1; i < map.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < map.GetLength(1) - 1; j++)
                {
                    map[i, j] = '.';
                }
            }
        }

        public Room(int size)
        {
            map = new char[size, size];
            for (int i = 0; i < map.GetLength(0) && i < map.GetLength(1); i++)
            {
                Console.WriteLine(i);
                map[0, i] = 'W';
                map[size - 1, i] = 'W';
                map[i, 0] = 'W';
                map[i, size - 1] = 'W';
            }
            for (int i = 1; i < map.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < map.GetLength(1) - 1; j++)
                {
                    map[i, j] = '.';
                }
            }
        }

        public char[,] getMap()
        {
            return map;
        }

        public void getMap(char[,] value)
        {
            map = value;
        }
    }
}
