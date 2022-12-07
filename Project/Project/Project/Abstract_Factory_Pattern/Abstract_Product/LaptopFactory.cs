using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Abstract_Factory_Pattern.Abstract_Product
{
    public abstract class LaptopFactory
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string VGA { get; set; }
        public string Screen { get; set; }
        public string DVDRW { get; set; }
        public string LAN { get; set; }
        public string MoreSpecs { get; set; }
        public string Keyboard { get; set; }
        public string OS { get; set; }
        public string Warranty { get; set; }
        

        public abstract void ShowInfo();

        
    }
}
