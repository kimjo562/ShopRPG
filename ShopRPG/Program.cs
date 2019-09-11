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
            string playerSave = "playerSave.txt";
            string shopSave = "shopSave.txt";

            int playerFunds = 0;
            int storeFunds = 0;

            AllItem[] playerInventory;
            AllItem[] storeInventory;

            string choice = "";
            while (choice != "Q")
            {
                Console.WriteLine("Hello there.\n1.) Inventory \n2.) Shop \nQ.) Quit");
                choice = Console.ReadLine();

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
