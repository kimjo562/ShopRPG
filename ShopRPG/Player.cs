using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Player                                                                                // Type 
    {
        Inventory playerInv = new Inventory();

        private string _name = " ";

        public Player(string name)
        {
            _name = name;
        }

        public void Print()
        {
            playerInv.PrintItemPoolWeapon();
            playerInv.PrintItemPoolArmor();
        }

        public AllItem GetItem(int index)
        {
         return playerInv.GetItem(index);
        }


    }
}
