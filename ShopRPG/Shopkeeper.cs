using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Shopkeeper
    {
        Inventory shopInv = new Inventory();
        AllItem temp = new AllItem();

        public StoreItem[] _storeItemList = new StoreItem[12];                      // [12] Inventory Limit
        int shopMoney = 3000;

        // Name, [Attack]/[Defense] Value, Price, Description
        public Shopkeeper()                                                                                                  // Will be used to call for items
        {
            // Populate the weapon list
            _storeItemList[0] = new StoreItem("Great Sword", 50, 800, "This is a Great Sword...");
            _storeItemList[1] = new StoreItem("Sword", 25, 300, "This is a Sword...");
            _storeItemList[2] = new StoreItem("Dagger", 20, 250, "This is a Dagger...");
            _storeItemList[3] = new StoreItem("Spear", 30, 350, "This is a Spear...");
            _storeItemList[4] = new StoreItem("Bow", 25, 300, "This is a Bow...");
            _storeItemList[5] = new StoreItem("Whip", 15, 200, "This is a Whip...");

            // Populate the armor list
            _storeItemList[6] = new StoreItem("Leather Armor", 15, 100, "This is a Leather Armor ...");
            _storeItemList[7] = new StoreItem("Chain Armor", 20, 300, "This is a Chain Armor ...");
            _storeItemList[8] = new StoreItem("Iron Armor", 30, 750, "This is a Iron Armor ...");
            _storeItemList[9] = new StoreItem("Cloth Armor", 5, 50, "This is a Cloth Armor ...");
            _storeItemList[10] = new StoreItem("Dragon Armor", 100, 5000, "This is a Dragon Armor ...");
            _storeItemList[11] = new StoreItem("Bronze Armor", 25, 500, "This is a Bronze Armor ...");

            foreach (AllItem i in _storeItemList)
            {
                shopInv.Add(i);
            }

        }

        public int getShopMoney
        {
            get
            {
                return shopMoney;
            }
            set
            {
                shopMoney = value;
            }
        }

        public void PrintList()
        {
            shopInv.PrintItemPool();
        }

        public void Add(AllItem toAnyInv)
        {
            shopInv.Add(toAnyInv);
        }

        public bool SellingItem(int index, Player player)
        {
            AllItem temp = shopInv[index];

            if (player.getDatMoney /* watchItBurn */ < temp.GetCost())
            {
                // If the Player doesn't have enough funds, tell player you cannot and nothing happens.
                temp.Print();
                return false;
            }
            //player buys item (create BUY function which will be your logic for buying (lose money giving item ect.  (PLAYER BUYING FROM Shopkeeper))
            Console.WriteLine("You have sucessfully bought " + temp.GetName() + " from the shop.");
            player.getDatMoney -= temp.GetCost();
            getShopMoney += temp.GetCost();
            shopInv.Remove(index);
            player.Add(temp);
            return true;
        }

      

    }
}

