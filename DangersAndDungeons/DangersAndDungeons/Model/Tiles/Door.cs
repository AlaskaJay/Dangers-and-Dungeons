using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model.Tiles
{
    class Door : Tile
    {
        private char direction;
        private char display;

        public char Display
        {
            get
            {
                return display;
            }
        }

        public Door()
        {
            display = 'D';
        }

        public Door(char dir)
        {
            display = 'D';
            direction = dir;
        }

        public Door(char dir, char dis)
        {
            display = dis;
            direction = dir;
        }
    }
}
