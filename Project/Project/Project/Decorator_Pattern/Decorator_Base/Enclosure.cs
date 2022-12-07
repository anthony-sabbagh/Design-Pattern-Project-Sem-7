using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component_Base;

namespace Decorator_Base
{
    public class Enclosure : Component_Base.SSD
    {
        protected Component_Base.SSD SSD;

        public Enclosure(Component_Base.SSD Ssd)
        {
            SSD = Ssd;
        }

        public override string GetDescription()
        {
            return SSD.GetDescription();
        }

        public override double GetPrice()
        {
            return SSD.GetPrice();
        }
    }
}
