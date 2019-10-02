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
        protected int _stat;

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

        public virtual int GetItemStat()
        {
            return _stat;
        }
        public virtual int Stats
        {
            set
            {
                _stat = value;
            }
        }

        public void Load(string name, int stat, int cost, string desc)
        {
            _name = name;
            _stat = stat;
            _cost = cost;
            _description = desc;

        }


    }
}
