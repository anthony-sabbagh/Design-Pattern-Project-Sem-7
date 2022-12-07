using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_Base;
using Concrete_Component;
using Decorator_Base;

namespace Concrete_Decorators
{
    public class XPG_EX500 : Enclosure
    {
        public XPG_EX500(SSD Ssd) : base(Ssd)
        {
            Description = "2.5 inches enclosure/ Adata / Red / USB3.0";
        }

        public override string GetDescription()
        {
            return  Description;
        }

        public override double GetPrice()
        {
            return SSD.GetPrice() + 15;
        }
    }
}

