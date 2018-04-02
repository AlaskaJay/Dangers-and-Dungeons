using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class FloorTile : Tile
    {
        private char DEFAULT = '.';
        private List<Item> stash;

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
