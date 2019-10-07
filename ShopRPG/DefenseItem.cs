using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class DefenseItem : AllItem
    {
        public DefenseItem(string newName, int _weaponDefense, int price, string description)
        {
            _name = newName;                         // Name of the Armor
            _stat = _weaponDefense;                  // Armor value it yields
            _cost = price;                           // The Price of the Armor
            _description = description;              // The Description of said defense itme.

        }

        public int ItemDefense
        {
            get
            {
                return _stat;
            }
            set
            {
                _stat = value;
            }
        }

        public override int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public override string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine("\n  Name: " + Name + "\n  Defense: " + ItemDefense + "\n  Description: " + Description + "\n  Cost: " + Cost);
        }

    }
}
