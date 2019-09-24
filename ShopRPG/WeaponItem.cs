using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class WeaponItem : AllItem
    {
        public WeaponItem(string newName, int weaponDamage, int price, string description)
        {
            _name = newName;                        // Name of the Weapon
            _damage = weaponDamage;                // Damage it can do
            _cost = price;                          // The Price of the Weapon
            _description = description;             // The Description of said attack itme.

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

        public override int GetItemWeapon()
        {
            return _damage;
        }
        public override int Weapon
        {
            set
            {
                _damage = value;
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
            Console.WriteLine("\n  Name: " + GetName() + "\n  Damage: " + GetItemWeapon() + "\n  Description: " + GetDescription() + "\n  Cost: " + GetCost());
        }


    }
}
