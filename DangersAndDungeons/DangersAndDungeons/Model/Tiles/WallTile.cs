using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class WallTile : Tile
    {
        private char DEFAULT = '#';

        public char toChar()
        {
            return DEFAULT;
        }

        public string toString()
        {
            return DEFAULT + "";
        }
    }
}
