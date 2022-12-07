using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class HP_15t_DW300_1B9N3AV_6_CHB : LaptopFactory
    {
        public HP_15t_DW300_1B9N3AV_6_CHB()
        {
            Name = "HP_15t_DW300_1B9N3AV_6_CHB";
            Price = "700";
            Processor = "Core i5-1135G7";
            RAM = "8GB DDR4";
            Storage = "NVMe 256GB ";
            VGA = "Intel Iris Xe";
            Screen = "15.6'' TOUCH SCREEN";
            DVDRW = "NO";
            LAN = "YES";
            MoreSpecs = "";
            Keyboard = "ENG";
            OS = "WIN 11 HOME";
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
