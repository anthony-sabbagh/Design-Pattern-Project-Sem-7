using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_Base;

namespace Concrete_Component
{
    public class Kingston_240Gb : SSD
    {
        public Kingston_240Gb()
        {
            Description = "Kingston 240Gb";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return 55;
        }
    }
}
