using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Player
    {
        ItemPool item = new ItemPool();

        private string _name = " ";

        public Player(string name)
        {
            _name = name;
        }

        public void Print()
        {
            item.PrintItemPoolWeapon();
            item.PrintItemPoolArmor();
        }

    }
}
