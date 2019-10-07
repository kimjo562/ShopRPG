using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class AttackItem : AllItem
    {

        public AttackItem(string newName, int weaponDamage, int price, string description)
        {
            _name = newName;                        // Name of the Weapon
            _stat = weaponDamage;                   // Damage it can do
            _cost = price;                          // The Price of the Weapon
            _description = description;             // The Description of said attack itme.

        }

        public int ItemDamage
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
            Console.WriteLine("\n  Name: " + Name + "\n  Defense: " + ItemDamage + "\n  Description: " + Description + "\n  Cost: " + Cost);
        }

    }

}

