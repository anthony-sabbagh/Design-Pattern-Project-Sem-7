using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_Base
{
    public  abstract class SSD
    {
        public abstract string GetDescription();

        public abstract double GetPrice();

        public string Description { get; set; }
    }
}
