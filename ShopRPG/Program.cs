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
            string playerSave = "playerSave.txt";               // Player Inventory Save File
            string shopSave = "shopSave.txt";                   // Shop Inventory Save File

            int storeFunds = 0;
            int playerFunds = 50000;

            Player player = new Player("TesterBoi");
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
                }
                else if (choice == "2")
                {
                    
                }
                else if (choice == "3")
                {

                }
                else if (choice == "4")
                {

                }
                else if (choice == "iamthegoldman")
                {
                    Console.WriteLine("Debug Mode Activated");
                    choice = Console.ReadLine();
                    if (choice == "addweapon")
                    {


                    }
                    else if (choice == "addarmor")
                    {


                    }
                    else if (choice == "back")
                    {

                    }
                }
            }

            Console.ReadKey();
            void InventoryMenu()
            {
                while (choice != "Q")
                {
                    // Display Menu
                    Console.WriteLine("Player Inventory Menu");                                                                 // Get player name
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Player Funds:               Potions Held: "/* + _potionHeld*/);
                    Console.WriteLine("1.) See Weapon Gear \n2.) See Armor Gear \nQ.) Quit");

                    //Get input
                    choice = Console.ReadLine();
                    Console.WriteLine("");

                    //Check Input
                    if (choice == "1")
                    {
                        // Print the Player's Weapon being stored.
                    }
                    else if (choice == "2")
                    {
                        // Print the Player's Armor being Stored here.
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
                            shopkeeper.PrintWeapon();
                            Console.WriteLine("Here are your weapon choices.");
                            subChoice = Console.ReadLine();

                            if (subChoice == "1")
                            {
                                // When player buys item from List  (Number: Dictates the Index Array Number)
                                AllItem temp = shopkeeper.shopInv.GetItem(0);
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
                                    temp = shopInv.GetItem(0);
                                    shopInv.Remove(0);

                                }
                                Console.ReadKey();

                            }
                            else if (subChoice == "2")
                            {
                                
                            }
                            else if (subChoice == "3")
                            {
                               
                            }
                            else if (subChoice == "4")
                            {

                            }
                            else if (subChoice == "5")
                            {
                               
                            }
                            else if (subChoice == "6")
                            {
                              
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
                                AllItem temp = shopInv.GetItem(6);
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
                                
                            }
                            else if (subChoice == "3")
                            {
                                
                            }
                            else if (subChoice == "4")
                            {
                                
                            }
                            else if (subChoice == "5")
                            {
                                
                            }
                            else if (subChoice == "6")
                            {
                               
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

        }                                                                                                                                           //static void Main Bracket


        static void Save(string shopSaveLocation, string playerSaveLocation)
        {   // Creates a (shopSave & playerSave) for the file at our path
            StreamWriter shopSave = File.CreateText(shopSaveLocation);
            StreamWriter playerSave = File.CreateText(playerSaveLocation);

            // Closes it
            shopSave.Close();
            playerSave.Close();
        }

        static void Load(string shopSaveLocation, string playerSaveLocation)
        {
            if (File.Exists(shopSaveLocation) && File.Exists(playerSaveLocation))
            {   // Create a (shopSave & playerSave) object for the file at our path
                StreamReader shopSave = File.OpenText(shopSaveLocation);
                StreamReader playerSave = File.OpenText(playerSaveLocation);

                shopSave.Close();
                playerSave.Close();
            }
            else
            {
                Console.WriteLine("Save File not found.");
            }

        }

    }                                                                                                                                               // class Program Bracket

}
