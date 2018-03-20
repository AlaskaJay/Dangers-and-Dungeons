using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAnIcon
{
    class Map
    {
        private char[,] board;
        private int x;
        private int y;

        public Map()
        {
            board = new char[10, 10];
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for(int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = '#';
                }
            }
            x = 0;
            y = 0;
            board[x, y] = 'P';
        }

        public void move(int direction)
        {
            if (direction == 0)
                moveNorth();
            else if (direction == 1)
                moveEast();
            else if (direction == 2)
                moveSouth();
            else
                moveWest();
        }

        public void moveNorth()
        {

        }

        public void moveEast()
        {

        }

        public void moveSouth()
        {

        }

        public void moveWest()
        {

        }
    }
}
