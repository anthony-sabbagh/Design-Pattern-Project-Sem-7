using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class IdeaPad_Gaming_3_82K200URUS : LaptopFactory
    {
        public IdeaPad_Gaming_3_82K200URUS()
        {
            Name = "IdeaPad_Gaming_3_82K200URUS";
            Price = "1500";
            Processor = "AMD Ryzen 7 5800H";
            RAM = "8GB DDR4";
            Storage = "NVMe 512GB ";
            VGA = "RTX 3060 6GB GDDR6";
            Screen = "15.6''FHD 120Hz";
            DVDRW = "NO";
            LAN = "YES";
            MoreSpecs = "";
            Keyboard = "ENG Backlit";
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
