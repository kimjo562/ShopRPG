using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Shopkeeper
    {
        private ItemPool itemPool = new ItemPool();
        AllItem temp = new AllItem();

        int storeFunds = 0;
        int playerFunds = 0;

        public void ShopkeeperMenu()
        {
            string choice = "";
            while (choice != "Q")
            {
                // Display Menu
                Console.WriteLine("Shop Menu");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Store Funds: " + storeFunds);
                Console.WriteLine("1.) Buy Items \n2.) Sell Items \n3.) Inspect Items \nQ.) Leave");

                //Get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Check Input
                if (choice == "1")
                {
                    string subChoice = "";
                    Console.WriteLine("What would you like to buy?");
                    Console.WriteLine("1.) Weapon    2.) Armor    3.) Potions    0.)Back");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        // Add Array of Shop Weapons here.
                        PrintWeapon();
                        Console.WriteLine("Here are your weapon choices.");
                        subChoice = Console.ReadLine();

                        if (subChoice == "1")
                        {
                            // When player buys item from List  (Number: Dictates the ItemPool Array Number)
                            AllItem temp = itemPool.GetItem(0);
                            if (playerFunds < temp.GetCost())
                            {
                                // If the Player doesn't have enough funds, tell player you cannot and nothing happens.
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                // Add it to Player Inventory and remove it from ShopList
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();

                        }
                        else if (subChoice == "2")
                        {
                            AllItem temp = itemPool.GetItem(1);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "3")
                        {
                            AllItem temp = itemPool.GetItem(2);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "4")
                        {
                            AllItem temp = itemPool.GetItem(3);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "5")
                        {
                            AllItem temp = itemPool.GetItem(4);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "6")
                        {
                            AllItem temp = itemPool.GetItem(5);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }

                    }
                    else if (choice == "2")
                    {
                        // Add Array of Shop Armor here.
                        PrintArmor();
                        Console.WriteLine("Here are your armor choices.");
                        subChoice = Console.ReadLine();

                        if (subChoice == "1")
                        {
                            AllItem temp = itemPool.GetItem(6);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();

                        }
                        else if (subChoice == "2")
                        {
                            AllItem temp = itemPool.GetItem(7);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "3")
                        {
                            AllItem temp = itemPool.GetItem(8);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "4")
                        {
                            AllItem temp = itemPool.GetItem(9);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "5")
                        {
                            AllItem temp = itemPool.GetItem(10);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }
                        else if (subChoice == "6")
                        {
                            AllItem temp = itemPool.GetItem(11);
                            if (playerFunds < temp.GetCost())
                            {
                                temp.Print();
                                Console.WriteLine("You don't have enough money to buy " + temp.GetName() + ".");
                            }
                            else
                            {
                                Console.WriteLine("You have bought the " + temp.GetName() + ".");
                            }
                            Console.ReadKey();
                        }

                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("How many potions would you like to buy?");
                        int potionAmount = Convert.ToInt32(Console.ReadLine());

                        if (playerFunds > 250 * potionAmount)
                        {
                            playerFunds -= 250 * potionAmount;                                     // How many you want to buy = respective price.
                            Console.WriteLine("You have bought " + potionAmount + " and it costed you " + potionAmount * 250 + " gold.\n");

                            // Add Potions amount into Player Inventory.
                            //                            /*inventory._potionHeld*/ += potionAmount;


                        }
                        else if (playerFunds < 250 * potionAmount)
                        {
                            Console.WriteLine("You're short on gold you pleb.");
                            Console.WriteLine("Try again when you have more gold.\n");
                            Console.ReadKey();

                        }

                    }
                    else if (choice != "0")
                    {


                    }

                }
                else if (choice == "2")
                {
                    string subChoice = "";
                    Console.WriteLine("What would you like to sell?");
                    Console.WriteLine("1.) Weapon    2.) Armor    0.)Back");
                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Here are your weapon choices.");
                        // Get Player Inventory List
                        subChoice = Console.ReadLine();

                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Here are your armor choices.");
                        // Get Player Inventory List
                        subChoice = Console.ReadLine();

                    }
                    else if (choice != "0")
                    {


                    }

                }
                else if (choice == "3")
                {
                    Console.WriteLine("Item Inspection");
                    PrintWeapon();
                    PrintArmor();

                }

            }
        }
        public void PrintWeapon()
        {
            itemPool.PrintItemPoolWeapon();
        }

        public void PrintArmor()
        {
            itemPool.PrintItemPoolArmor();
        }

    }
}




