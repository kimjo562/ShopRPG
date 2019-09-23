using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Shopkeeper 
    {
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
                Console.WriteLine("1.) Buy Items \n2.) Sell Items \n3.) Inspect Items \nQ.) Quit");

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
                        Console.WriteLine("Here are your weapon choices.");
                        // Add Array of Shop Weapons here.
                        subChoice = Console.ReadLine();

                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Here are your armor choices.");
                        // Add Array of Shop Armor here.
                        subChoice = Console.ReadLine();

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

            }
        }
    }
}




