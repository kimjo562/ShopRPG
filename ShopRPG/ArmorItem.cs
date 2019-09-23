using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class ArmorItem : AllItem
    {
        private int _defense;
        public int Defense                           // How much Defense Items Damage do
        {
            get
            {
                return _defense;
            }
        }

        public ArmorItem(string newName, int _weaponDefense, int price, string description)
        {
            _name = newName;                         // Name of the Armor
            _defense = _weaponDefense;               // Armor value it yields
            _cost = price;                           // The Price of the Armor
            _description = description;              // The Description of said defense itme.
             
        }

    }
}
