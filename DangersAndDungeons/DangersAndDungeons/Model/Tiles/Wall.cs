using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model.Tiles
{
    class Wall : Tile
    {
        private char display;

        public char Display
        {
            get
            {
                return display;
            }
        }

        public Wall()
        {
            display = 'W';
        }
    }
}
