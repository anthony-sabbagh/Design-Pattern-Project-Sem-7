using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Abstract_Factory_Pattern.Abstract_Factory;
using Project.Abstract_Factory_Pattern.Abstract_Product;
using Project.Abstract_Factory_Pattern.Concrete_Products;


namespace Project.Abstract_Factory_Pattern.Concrete_Factories
{
    public class Lenovo_Factory : ILaptopFactory
    {

        public LaptopFactory CreateGamingLaptop()
        {
            return new IdeaPad_Gaming_3_82K200URUS();
        }

        public LaptopFactory CreateBusinessLaptop()
        {
            return new Lenovo_IP5_82FG00S9AX();
        }

        public LaptopFactory CreateEveryDayUseLaptop()
        {
            return new Lenovo_V15_82KB003LIX();
        }

    }
}
