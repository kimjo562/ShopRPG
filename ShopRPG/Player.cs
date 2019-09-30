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

        public void PrintList()
        {
            playerInv.PrintItemPool();

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

        public bool BuyingItem(int index, Shopkeeper shopkeeper)
        {
            AllItem temp = playerInv[index];

            if (shopkeeper.getShopMoney /* watchItBurn */ < temp.GetCost())
            {
                // If the Player doesn't have enough funds, tell player you cannot and nothing happens.
                temp.Print();
                return false;
            }
            //player buys item (create BUY function which will be your logic for buying (lose money giving item ect.  (PLAYER BUYING FROM Shopkeeper))
            Console.WriteLine("You have sucessfully sold " + temp.GetName() + " from your bag.");
            getDatMoney += temp.GetCost();
            shopkeeper.getShopMoney -= temp.GetCost();
            playerInv.Remove(index);
            shopkeeper.Add(temp);
            return true;
        }

    }
}
