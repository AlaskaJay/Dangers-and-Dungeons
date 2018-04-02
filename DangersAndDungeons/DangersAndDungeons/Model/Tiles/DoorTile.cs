using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class DoorTile : Tile 
    {
        private char DEFAULT = 'D';
        private bool locked;

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
