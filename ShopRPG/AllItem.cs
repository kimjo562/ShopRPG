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

        public virtual string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public virtual string Description
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

        public virtual int Cost
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

        public virtual int Stats
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
    }
}
