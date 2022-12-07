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
    public class HP_Factory: ILaptopFactory
    {

        public LaptopFactory CreateGamingLaptop()
            {
                return new Victus_Gaming_15_FA0032DX();
            }

        public LaptopFactory CreateBusinessLaptop()
            {
                return new ProBook_450_G95Y3T4EA();
            }

        public LaptopFactory CreateEveryDayUseLaptop()
            {
                return new HP_15t_DW300_1B9N3AV_6_CHB();
            }
        
    }
}
