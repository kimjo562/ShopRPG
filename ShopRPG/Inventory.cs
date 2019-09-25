using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class Inventory 
    {
        AllItem[] storage = { /* Empty Bag */ };
        private AllItem[] _item = { };
        int storeFunds = 0;
        int playerFunds = 0;



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

        public void PrintItemPoolWeapon()
        {
            int counter = 1;
            Console.WriteLine("List of Weapons:");
            foreach (AllItem i in _item)
            {
                if (i is WeaponItem)
                {
                    Console.Write(counter + ")");
                    counter++;
                    i.Print();
                }
            }
            Console.WriteLine();
        }

        public void PrintItemPoolArmor()
        {
            int counter = 1;
            Console.WriteLine("List of Armors:");
            foreach (AllItem i in _item)
            {
                if (i is ArmorItem)
                {
                    Console.Write(counter + ")");
                    counter++;
                    i.Print();
                }
            }
            Console.WriteLine();

        }
        /// <summary>
        /// int[] someArray ={1,2,3}
        /// somaeArray[0]
        /// AllItem itemlist;
        /// itemlist[0]
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AllItem this[int index]              // CustomDataType (AllItem)
        {
            get                                     // Get Give the Instructions of Whatever        (Any logic can be implemented)
            {
                return storage[index];              
            }
            set                                     // Set is Do whatever the (get) instuction stated.
            {
                storage[index] = value;
            }
        }

    }
}
