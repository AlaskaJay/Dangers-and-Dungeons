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
        //private bool locked;
        private int destination;

        public DoorTile()
        {
            //locked = false;
            destination = -1;
        }

        public char toChar()
        {
            return DEFAULT;
        }

        public string toString()
        {
            return DEFAULT + "";
        }

        public void setDestination()
        {
            destination = 0;
        }

        public void setDestination(int destination)
        {
            this.destination = destination;
        }

        public int getDestination()
        {
            return destination;
        }
    }
}
