using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class ArmorItem : AllItem
    {
        public ArmorItem(string newName, int _weaponDefense, int price, string description)
        {
            _name = newName;                         // Name of the Armor
            _defense = _weaponDefense;               // Armor value it yields
            _cost = price;                           // The Price of the Armor
            _description = description;              // The Description of said defense itme.
             
        }
        public string GetName()
        {
            return _name;
        }
        public override string Name
        {
            set
            {
                _name = value;
            }
        }

        public override int GetItemArmor()
        {
            return _defense;
        }
        public override int Armor
        {
            set
            {
                _defense = value;
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
            Console.WriteLine("\n  Name: " + GetName() + "\n  Defense: " + GetItemArmor() + "\n  Description: " + GetDescription() + "\n  Cost: " + GetCost());
        }




    }
}
