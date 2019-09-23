using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Inventory 
    {
        int storeFunds = 0;
        int playerFunds = 0;


        public void InventoryMenu()
        { 
            string choice = "";
            while (choice != "Q")
            {
                // Display Menu
                Console.WriteLine("Player Inventory Menu");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Player Funds: " + playerFunds + "              Potions Held: "/* + _potionHeld*/);
                Console.WriteLine("1.) See Weapon Gear \n2.) See Armor Gear \nQ.) Quit");

                //Get input
                choice = Console.ReadLine();
                Console.WriteLine("");

                //Check Input
                if (choice == "1")
                {
                    // Print the Player's Weapons being stored here.
                }
                else if (choice == "2")
                {
                    // Print the Player's Armor being Stored here.
                }

            }

        }

        public void PrintWeapons()
        {
      //      for(int i = 0; i < )


        }

        public void PrintArmor()
        {



        }

    }
}
