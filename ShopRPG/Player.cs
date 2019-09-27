using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Player 
    {
        Inventory playerInv = new Inventory();

        private string _name = " ";
        private int playerMoney = 1000;
        public int _potionHeld = 0;

        public Player(string name)
        {
            _name = name;
        }

        public void PrintWeapon()
        {
            playerInv.PrintItemPoolWeapon();

        }
        
        public void PrintArmor()
        {
            playerInv.PrintItemPoolArmor();
        }

        public int getDatMoney
        {
            get
            {
                return playerMoney;
            }
            set
            {
                playerMoney = value;
            }
        }

        public void Add(AllItem toPlayerInv)
        {
            playerInv.Add(toPlayerInv);
                
        }

    }
}
