using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class Lenovo_V15_82KB003LIX : LaptopFactory
    {
        public Lenovo_V15_82KB003LIX()
        {
            Name = "Lenovo_V15_82KB003LIX";
            Price = "550";
            Processor = "Core i5-1135G7";
            RAM = "8GB DDR4";
            Storage = "NVMe 256GB ";
            VGA = "Intel Iris Xe";
            Screen = "15.6'' FHD ";
            DVDRW = "NO";
            LAN = "YES";
            MoreSpecs = "";
            Keyboard = "ENG";
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
