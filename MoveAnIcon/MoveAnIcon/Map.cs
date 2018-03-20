using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveAnIcon
{
    class Map
    {
        private char DEFAULT = '#';
        private char PLAYER = '*';
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
                    board[i, j] = DEFAULT;
                }
            }
            x = 0;
            y = 0;
            board[x, y] = PLAYER;
        }

        public String toString()
        {
            String result = "";

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    result += board[i, j];
                }
                result += "\n";
            }

            return result;
        }

        public void move(int direction)
        {
            board[x, y] = DEFAULT;

            if (direction == 0)
                moveNorth();
            else if (direction == 1)
                moveEast();
            else if (direction == 2)
                moveSouth();
            else
                moveWest();

            board[x, y] = PLAYER;
        }

        public void moveNorth()
        {
            if (x > 0)
                x--;
        }

        public void moveEast()
        {
            if (y < board.GetLength(0) - 1)
                y++;
        }

        public void moveSouth()
        {
            if (x < board.GetLength(1) - 1)
                x++;
        }

        public void moveWest()
        {
            if (y > 0)
                y--;
        }
    }
}
