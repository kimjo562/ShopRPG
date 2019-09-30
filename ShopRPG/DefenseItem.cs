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

        public int GetItemDefense()
        {
            return _stat;
        }
        public int ItemDefense
        {
            set
            {
                _stat = value;
            }
        }
        public override int GetCost()
        {
            return _cost;
        }
        public override int Cost
        {
            set
            {
                _cost = value;
            }
        }
        public override string GetDescription()
        {
            return _description;
        }
        public override string Description
        {
            set
            {
                _description = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine("\n  Name: " + GetName() + "\n  Defense: " + GetItemDefense() + "\n  Description: " + GetDescription() + "\n  Cost: " + GetCost());
        }

    }
}
