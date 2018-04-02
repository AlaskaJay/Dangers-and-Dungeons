using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangersAndDungeons.Model
{
    interface Actor
    {
        void move(int direction, Dungeon dungeon);

        char symbol
        {
            set;
            get;
        }

        int x
        {
            set;
            get;
        }

        int y
        {
            set;
            get;
        }

        int room
        {
            set;
            get;
        }

        List<Item> stash
        {
            set;
            get;
        }
    }
}
