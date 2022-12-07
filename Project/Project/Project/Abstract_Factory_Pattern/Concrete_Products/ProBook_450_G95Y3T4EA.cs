using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class ProBook_450_G95Y3T4EA : LaptopFactory
    {
        public ProBook_450_G95Y3T4EA()
        {
            Name = "ProBook_450_G95Y3T4EA";
            Price = "1200";
            Processor = "Core I7-1255U";
            RAM = "8GB DDR4";
            Storage = "NVMe 512GB ";
            VGA = "2GB DDR6 dedicated NVIDIA GeForce® MX570";
            Screen = "15.'' HD ";
            DVDRW = "NO";
            LAN = "YES";
            MoreSpecs = "";
            Keyboard = "ENG/Ar";
            OS = "DOS";
            Warranty = "1Yr";
        }
        public override void ShowInfo()
        {
            MessageBox.Show("Price: " + Price.ToString() + '\n' + "Processor: " + Processor + '\n' + "RAM: " + RAM +
                '\n' + "Storage: " + Storage + '\n' + "VGA:  " + VGA + '\n' + "Screen: " + Screen + '\n' + "DVDRW: " + DVDRW +
               '\n' + "LAN: " + LAN + '\n' + "MoreSpecs: " + MoreSpecs + '\n' + "Keyboard: " + Keyboard + '\n' + "OS: " + OS + '\n' + "Warranty: " + Warranty, Name);

        }
    }
}
