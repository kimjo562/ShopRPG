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
        public static Random random = new Random();
        static void Main(string[] args)
        {                                                                                                                                           //static void Main Bracket
            string playerSave = "playerSave.txt";               // Player Inventory Save File
            string shopSave = "shopSave.txt";                   // Shop Inventory Save File

            Player player = new Player("TesterBoi");
            Inventory inventory = new Inventory();
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
                    inventory.InventoryMenu();
                }
                else if(choice=="2")
                {
                    shopkeeper.ShopkeeperMenu();

                }
                else if(choice == "3")
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
                    else if(choice == "addarmor")
                    {


                    }
                    else if(choice == "back")
                    {

                    }
                }
            }

            Console.ReadKey();

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
            if(File.Exists(shopSaveLocation) && File.Exists(playerSaveLocation))
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
