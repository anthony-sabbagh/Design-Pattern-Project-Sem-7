using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Abstract_Factory
{
    internal interface ILaptopFactory
    {
        LaptopFactory CreateGamingLaptop();
        LaptopFactory CreateBusinessLaptop();
        LaptopFactory CreateEveryDayUseLaptop();

    }
}
