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
        int shopMoney = 3000;

        // Name, [Attack]/[Defense] Value, Price, Description
        public Shopkeeper()                                                                                                  // Will be used to call for items
        {
            // Populate the weapon list and puts in a temp variable and puts it in an array
            temp = new AttackItem("Great Sword", 50, 800, "This is a Great Sword...");
            shopInv.Add(temp);
            temp = new AttackItem("Sword", 25, 300, "This is a Sword...");
            shopInv.Add(temp);
            temp = new AttackItem("Dagger", 20, 250, "This is a Dagger...");
            shopInv.Add(temp);
            temp = new AttackItem("Spear", 30, 350, "This is a Spear...");
            shopInv.Add(temp);
            temp = new AttackItem("Bow", 25, 300, "This is a Bow...");
            shopInv.Add(temp);
            temp = new AttackItem("Whip", 15, 200, "This is a Whip...");
            shopInv.Add(temp);

            // Populate the armor list and puts in a temp variable and puts it in an array
            temp = new DefenseItem("Leather Armor", 15, 100, "This is a Leather Armor ...");
            shopInv.Add(temp);
            temp = new DefenseItem("Chain Armor", 20, 300, "This is a Chain Armor ...");
            shopInv.Add(temp);
            temp = new DefenseItem("Iron Armor", 30, 750, "This is a Iron Armor ...");
            shopInv.Add(temp);
            temp = new DefenseItem("Cloth Armor", 5, 50, "This is a Cloth Armor ...");
            shopInv.Add(temp);
            temp = new DefenseItem("Dragon Armor", 100, 5000, "This is a Dragon Armor ...");
            shopInv.Add(temp);
            temp = new DefenseItem("Bronze Armor", 25, 500, "This is a Bronze Armor ...");
            shopInv.Add(temp);

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

        public int GetLength()
        {
            return shopInv.GetLength();
        }

        // The SuperUser Command Function
        public void SuperAdmin(Player player)
        {
            AllItem item = new AllItem();
            string choice = "";
            string itemname = "";
            string itemDesc = "";
            int itemstat;
            int itemcost;


            Console.WriteLine("Debug Mode Activated\n");
            while (choice != "back")
            {
                int debug = 0;
                Console.WriteLine("Debug Mode (Active)");
                Console.WriteLine("additem, addgold, back");
                choice = Console.ReadLine();
                if (choice == "additem")
                {
                    Console.WriteLine("weapon, armor");
                    choice = Console.ReadLine();
                    if (choice == "weapon")
                    {
                        Console.WriteLine("\nGive the new item a name.");
                        itemname = Console.ReadLine();
                        Console.WriteLine("\nGive the new item an Attack stat.");
                        itemstat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nGive the new item a price.");
                        itemcost = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nGive the new item a description.");
                        itemDesc = Console.ReadLine();

                        Console.WriteLine("Your new item has been added to the shop.\n");
                        Console.ReadKey();

                        item = new AttackItem(itemname, itemstat, itemcost, itemDesc);
                        shopInv.Add(item);
                    }
                    else if (choice == "armor")
                    {
                        Console.WriteLine("\nGive the new item a name.");
                        itemname = Console.ReadLine();
                        Console.WriteLine("\nGive the new item an Defense stat.");
                        itemstat = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nGive the new item a price.");
                        itemcost = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nGive the new item a description.");
                        itemDesc = Console.ReadLine();

                        Console.WriteLine("Your new item has been added to the shop.\n");
                        Console.ReadKey();

                        item = new DefenseItem(itemname, itemstat, itemcost, itemDesc);
                        shopInv.Add(item);
                    }

                }
                else if (choice == "addgold")
                {
                    Console.WriteLine("How much player gold will you give?");
                    debug = Convert.ToInt32(Console.ReadLine());
                    player.getDatMoney += debug;
                    Console.WriteLine("You have given yourself " + debug + " gold.\n");
                }
                else if (choice == "back")
                {
                    Console.WriteLine("Now returning to main menu.\n");
                }
            }
        }

        public void Save(string shopInventorySave)
        {
            shopInv.ShopSave(shopInventorySave, shopInv, this);
        }

        public void Load(string shopInventorySave)
        {
            shopInv.ShopLoad(shopInventorySave, shopInv, this);
        }

    }
}

