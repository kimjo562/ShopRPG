﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class ItemPool
    {
        public WeaponItem[] _weaponList = new WeaponItem[10];                      // [10] Inventory Limit
        public ArmorItem[] _armorList = new ArmorItem[10];                         // [10] Inventory Limit

        // Name, [Attack]/[Defense] Value, Price, Description

        public void WeaponPool()
        {
            _weaponList[0] = new WeaponItem("Great Sword",  50, 800, "This is a Great Sword...");
            _weaponList[1] = new WeaponItem("Sword",        25, 300, "This is a Sword...");
            _weaponList[2] = new WeaponItem("Dagger",       20, 250, "This is a Dagger...");
            _weaponList[3] = new WeaponItem("Spear",        30, 350, "This is a Spear");
            _weaponList[4] = new WeaponItem("Bow",          25, 300, "This is a Bow...");
            _weaponList[5] = new WeaponItem("Whip",         15, 200, "This is a Bow...");
        }

        public void ArmorPool()
        {
            _armorList[0] = new ArmorItem("Leather Armor",  15, 100,  "This is a Leather Armor ...");
            _armorList[1] = new ArmorItem("Chain Armor",    20, 300,  "This is a Chain Armor ...");
            _armorList[2] = new ArmorItem("Iron Armor",     30, 750,  "This is a Iron Armor ...");
            _armorList[3] = new ArmorItem("Cloth Armor",     5, 50,   "This is a Cloth Armor ...");
            _armorList[4] = new ArmorItem("Dragon Armor",  100, 5000, "This is a Dragon Armor ...");
            _armorList[5] = new ArmorItem("Bronze Armor",   25, 500,  "This is a Bronze Armor ...");
        }

    }
}
