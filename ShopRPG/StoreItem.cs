using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class StoreItem : AllItem
    {
        public StoreItem(string newName, int stat, int price, string description)
        {
            _name = newName;                        // Name of the Weapon
            _stat = stat;                           // Stat(Dmg/Def) it can do
            _cost = price;                          // The Price of the Weapon
            _description = description;             // The Description of said attack itme.

        }

        public override int GetItemStat()
        {
            return _stat;
        }
        public override int Weapon
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
            Console.WriteLine("\n  Name: " + GetName() + "\n  Damage: " + GetItemStat() + "\n  Description: " + GetDescription() + "\n  Cost: " + GetCost());
        }


    }
}
