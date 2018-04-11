using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    class Coord : IEqualityComparer<Coord>
    {
        int x;
        int y;

        public Coord(int xVal, int yVal)
        {
            x = xVal;
            y = yVal;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int value)
        {
            x = value;
        }

        public void setY(int value)
        {
            y = value;
        }

        public void north() { y--; }
        public void south() { y++; }
        public void east() { x++; }
        public void west() { x--; }

        public bool equals(Coord other)
        {
            if (other.getX() != x || other.getY() != y)
                return false;
            return true;
        }

        public String toString()
        {
            return "" + x + ", " + y + "";
        }

        public bool Equals(Coord x, Coord y)
        {
            if (x.getX() != y.getX() || x.getY() != y.getY())
                return false;
            return true;
        }

        public int GetHashCode(Coord obj)
        {
            return obj.getX()*100 + obj.getY();
        }
    }
}
