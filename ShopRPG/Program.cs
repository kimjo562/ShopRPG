using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Program
    {                                                                                                                                               // class Program Bracket
        static void Main(string[] args)
        {                                                                                                                                           //static void Main Bracket
            Player player = new Player();
            Shopkeeper shopkeeper = new Shopkeeper();

            string choice = "";
            while (choice != "Q")
            {
                Console.WriteLine("Hello there.\n1.) Inventory \n2.) Shop \n3.) Save \n4.) Load \nQ.) Quit");
                choice = Console.ReadLine();
                Console.WriteLine("");
                // Check input
                if (choice == "1")
                {
                    InventoryMenu();
                    choice = " ";
                }
                else if (choice == "2")
                {
                    ShopMenu();
                    choice = " ";
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Shop file saved.");
                    shopkeeper.Save("shopSave.txt");
                    Console.WriteLine("Player file saved.");
                    player.Save("playerSave.txt");
                    choice = " ";
                }
                else if (choice == "4")
                {
                    shopkeeper.Load("shopSave.txt");
                    player.Load("playerSave.txt");
                    choice = " ";
                }
                else if (choice == "error404stillalive")
                {
                    shopkeeper.SuperAdmin(player);
                }

            }


            void InventoryMenu()
            {
                while (choice != "Q")
                {
                    // Display Menu
                    Console.WriteLine("Player Inventory Menu");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Player Funds: " + player.getDatMoney + "               Potions Held: " + player._potionHeld);
                    Console.WriteLine("1.) See Item Gear \nQ.) Quit");

                    //Get input
                    choice = Console.ReadLine();
                    Console.WriteLine("");

                    //Check Input
                    if (choice == "1")
                    {
                        // Print the Player's items being stored.
                        player.PrintList();
                    }


                }

            }


            void ShopMenu()
            {
                while (choice != "Q")
                {
                    // Display Menu
                    Console.WriteLine("Shop Menu");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Store Funds: " + shopkeeper.getShopMoney + "                Player Funds: " + player.getDatMoney);
                    Console.WriteLine("1.) Buy Items \n2.) Sell Items \n3.) Inspect Items \nQ.) Leave");

                    //Get input
                    choice = Console.ReadLine();
                    Console.WriteLine("");

                    //Check Input
                    if (choice == "1")
                    {
                        int subChoice;
                        Console.WriteLine("What would you like to buy?");
                        Console.WriteLine("1.) Weapon / Armor    2.) Potions    0.)Back");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            if (shopkeeper.GetLength() > 0)
                            {
                                // Add Array of Shop Weapons here.
                                shopkeeper.PrintList();
                                Console.WriteLine("Here are your weapon choices.");
                                subChoice = Convert.ToInt32(Console.ReadLine());

                                // When player buys item from List  (Number: Dictates the Index Array Number)
                                if (shopkeeper.SellingItem(subChoice - 1, player))
                                {
                                    Console.WriteLine("");

                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough money to buy this");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("But the shopkeeper has nothing left.");
                            }
                        }
                        else if (choice == "2")
                        {
                            Console.WriteLine("How many potions would you like to buy?");
                            int potionAmount = Convert.ToInt32(Console.ReadLine());

                            if (player.getDatMoney > 250 * potionAmount)
                            {
                                // How many you want to buy = respective price.
                                player.getDatMoney -= 250 * potionAmount;
                                shopkeeper.getShopMoney += 250 * potionAmount;
                                Console.WriteLine("You have bought " + potionAmount + " and it costed you " + potionAmount * 250 + " gold.\n");

                                // Add Potions amount into Player Inventory.
                                player._potionHeld += potionAmount;
                            }
                            else if (player.getDatMoney < 250 * potionAmount)
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
                        Console.WriteLine("What would you like to sell?");
                        Console.WriteLine("1.) Weapon / Armor    0.)Back");
                        choice = Console.ReadLine();
                        if (choice == "1")
                        {
                            if (player.GetLength() > 0)
                            {
                                int subChoice;
                                player.PrintList();
                                Console.WriteLine("Here are your items you have.");
                                subChoice = Convert.ToInt32(Console.ReadLine());

                                // Get Player Inventory List
                                if (player.BuyingItem(subChoice - 1, shopkeeper))
                                {
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("The shop doesn't have enough money to buy this");
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nYou don't have anything to sell -.-\n");
                            }

                        }
                        else if (choice != "0")
                        {


                        }

                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Item Inspection");
                        shopkeeper.PrintList();
                    }
                }
            }
        }                                                                                                                                           //static void Main Bracket
    }                                                                                                                                               // class Program Bracket
}
