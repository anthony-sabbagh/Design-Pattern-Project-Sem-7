using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_Base;
using Decorator_Base;

namespace Concrete_Decorators
{
    public class _2:Enclosure
    {
        
        public _2(SSD Ssd) : base(Ssd)
        {
            
            Description = "2.5 inches enclosure Black / Pink /Blue / Green / White / USB3.0";
        }

        public override string GetDescription()
        {
            return  Description;
        }

        public override double GetPrice()
        {
            return SSD.GetPrice() + 10;
        }
    }
}

