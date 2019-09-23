using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class WeaponItem : AllItem
    {
        private int _damage;
        public int Damage                           // How much Attack Items Damage do
        {
            get
            {
                return _damage;
            }
        }
        public WeaponItem(string newName, int _weaponDamage, int price, string description)
        {
            _name = newName;                        // Name of the Weapon
            _damage = _weaponDamage;                // Damage it can do
            _cost = price;                          // The Price of the Weapon
            _description = description;             // The Description of said attack itme.

        }

    }
}
