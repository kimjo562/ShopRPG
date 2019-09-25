using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopRPG
{
    class AllItem
    {
        protected string _name;
        protected string _description;
        protected int _cost;
        protected int _damage;
        protected int _defense;

        public virtual void Print()
        {

        }
        public string GetName()
        {
            return _name;
        }
        public virtual string Name
        {
            set
            {
                _name = value;
            }
        }

        public virtual string GetDescription()
        {
            return _description;
        }
        public virtual string Description
        {
            set
            {
                _description = value;
            }
        }

        public virtual int GetCost()
        {
            return _cost;
        }
        public virtual int Cost
        {
            set
            {
                _cost = value;
            }
        }
        public virtual int GetItemArmor()
        {
            return _defense;
        }
        public virtual int Armor
        {
            set
            {
                _defense = value;
            }
        }

        public virtual int GetItemWeapon()
        {
            return _damage;
        }
        public virtual int Weapon
        {
            set
            {
                _damage = value;
            }
        }

    }
}
