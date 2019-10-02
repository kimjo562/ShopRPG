using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Inventory
    {
        AllItem[] storage = { /* Empty Bag */ };
        private AllItem[] _item = { };
        private AttackItem[] _weapon = { };
        private DefenseItem[] _armor = { };

        public AllItem GetItem(int index)
        {
            return _item[index];
        }

        public void Add(AllItem item)
        {
            // Create a new array if Length + 1
            AllItem[] newAllItem = new AllItem[_item.Length + 1];
            // Put the values of the old array into the new one
            for (int i = 0; i < _item.Length; i++)
            {
                newAllItem[i] = _item[i];
            }
            // Put the new value at the end of the new array
            newAllItem[newAllItem.Length - 1] = item;
            // Sets the current array to the new array
            _item = newAllItem;
        }

        public virtual void Remove(int index)
        {
            // Create a new array if Length - 1
            AllItem[] newAllItem = new AllItem[_item.Length - 1];
            int newPosition = 0;                                                            // Puts it into the new position (newlist array and list array)
            // Put the values of the old array into the new array
            for (int i = 0; i < _item.Length; i++)
            {
                if (i != index)
                {
                    newAllItem[newPosition] = _item[i];
                    newPosition++;
                }
            }
            //Set the current array to the new array
            _item = newAllItem;
        }


        public void PrintItemPool()
        {
            int counter = 1;
            Console.WriteLine("List of Items:");
            foreach (AllItem i in _item)
            {
                if (i is AllItem)
                {
                    Console.Write(counter + ")");
                    counter++;
                    i.Print();
                }
            }
            Console.WriteLine();
        }

        public AllItem this[int index]              // CustomDataType (AllItem)
        {
            get                                     // Get Give the Instructions of Whatever        (Any logic can be implemented)
            {
                return _item[index];
            }
            set                                     // Set is Do whatever the (get) instuction stated.
            {
                _item[index] = value;
            }
        }

        public void ShopSave(string shopInventorySave, Inventory inventory)
        {   // Creates a (shopSave & playerSave) for the file at our path
            StreamWriter shopSave = File.CreateText(shopInventorySave);
            AllItem[] itemSave = GetItemList();

            foreach (AllItem i in itemSave)
            {
                if (i is AttackItem)
                {
                    shopSave.WriteLine("Weapon");
                }
                if (i is DefenseItem)
                {
                    shopSave.WriteLine("Armor");
                }
                shopSave.WriteLine(i.GetName());
                shopSave.WriteLine(i.GetItemStat());
                shopSave.WriteLine(i.GetCost());
                shopSave.WriteLine(i.GetDescription());
            }
            shopSave.WriteLine(" ");
            // Closes it
            shopSave.Close();
        }

        public void PlayerSave(string playerInventorySave, Inventory inventory)
        {   // Creates a (shopSave & playerSave) for the file at our path
            StreamWriter playerSave = File.CreateText(playerInventorySave);
            AllItem[] itemSave = GetItemList();

            foreach (AllItem i in itemSave)
            {
                if (i is AttackItem)
                {
                    playerSave.WriteLine("Weapon");
                }
                if (i is DefenseItem)
                {
                    playerSave.WriteLine("Armor");
                }
                playerSave.WriteLine(i.GetName());
                playerSave.WriteLine(i.GetItemStat());
                playerSave.WriteLine(i.GetCost());
                playerSave.WriteLine(i.GetDescription());
            }
            playerSave.WriteLine(" ");
            // Closes it
            playerSave.Close();
        }

        public void ShopLoad(string shopInventorySave, Inventory inventory)
        {
            if (File.Exists(shopInventorySave))
            {   // Create a (shopSave & playerSave) object for the file at our path
                AllItem newitem;
                string temp;
                string name;
                int stat;
                int cost;
                string desc;
                bool loading = true;


                Clear();
                StreamReader ShopSaveLoad = File.OpenText(shopInventorySave);
                while (loading)
                {
                    loading = false;
                    temp = ShopSaveLoad.ReadLine();
                    if (temp != " ")
                    {
                        loading = true;
                        name = (ShopSaveLoad.ReadLine());
                        stat = Convert.ToInt32(ShopSaveLoad.ReadLine());
                        cost = Convert.ToInt32(ShopSaveLoad.ReadLine());
                        desc = (ShopSaveLoad.ReadLine());
                        if (temp == "Weapon")
                        {
                            newitem = new AttackItem(name, stat, cost, desc);
                        }
                        else if (temp == "Armor")
                        {
                            newitem = new DefenseItem(name, stat, cost, desc);
                        }
                        else
                        {
                            newitem = new AllItem();
                        }
                        Add(newitem);
                    }
                }
                ShopSaveLoad.Close();
                Console.WriteLine("Shop File Loaded.");
            }
            else
            {
                Console.WriteLine("Save File not found.");
            }

        }

        public void PlayerLoad(string playerInventorySave, Inventory inventory)
        {
            if (File.Exists(playerInventorySave))
            {   // Create a (shopSave & playerSave) object for the file at our path
                AllItem newitem;
                string temp;
                string name;
                int stat;
                int cost;
                string desc;
                bool loading = true;


                Clear();
                StreamReader playerSaveLoad = File.OpenText(playerInventorySave);
                while (loading)
                {
                    loading = false;
                    temp = playerSaveLoad.ReadLine();
                    if (temp != " ")
                    {
                        loading = true;
                        name = (playerSaveLoad.ReadLine());
                        stat = Convert.ToInt32(playerSaveLoad.ReadLine());
                        cost = Convert.ToInt32(playerSaveLoad.ReadLine());
                        desc = (playerSaveLoad.ReadLine());
                        if (temp == "Weapon")
                        {
                            newitem = new AttackItem(name, stat, cost, desc);
                        }
                        else if (temp == "Armor")
                        {
                            newitem = new DefenseItem(name, stat, cost, desc);
                        }
                        else
                        {
                            newitem = new AllItem();
                        }
                        Add(newitem);
                    }
                }
                playerSaveLoad.Close();
                Console.WriteLine("Player File Loaded.");
            }
            else
            {
                Console.WriteLine("Save File not found.");
            }

        }

        public AllItem[] GetItemList()
        {
            return _item;
        }


        public int GetLength()
        {
            return _item.Length;
        }


        public void Clear()
        {
            _item = new AllItem[0];
        }
    }
}
