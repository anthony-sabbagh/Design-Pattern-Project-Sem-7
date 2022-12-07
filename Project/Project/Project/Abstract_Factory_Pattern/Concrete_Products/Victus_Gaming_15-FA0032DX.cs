using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class Victus_Gaming_15_FA0032DX : LaptopFactory
    {
        public Victus_Gaming_15_FA0032DX()
        {
            Name = "Victus_Gaming_15_FA0032DX";
            Price = "1350";
            Processor = "Core I7-12650H";
            RAM = "16GB DDR4";
            Storage = "NVMe 512GB ";
            VGA = "RTX 3050TI 4GB GDDR6";
            Screen = "15.6''FHD 144Hz";
            DVDRW = "NO";
            LAN = "YES";
            MoreSpecs = "";
            Keyboard = "ENG Backlit";
            OS = "WIN 11 HOME";
            Warranty = "1Yr";
        }
        public override void ShowInfo()
        {
            
            MessageBox.Show( "Price: "  + Price.ToString() + '\n' + "Processor: "+ Processor + '\n' + "RAM: "+ RAM+
                '\n' + "Storage: "+ Storage + '\n' + "VGA:  "+ VGA + '\n' + "Screen: "+ Screen + '\n' + "DVDRW: "+ DVDRW+
               '\n' + "LAN: "+ LAN + '\n' + "MoreSpecs: "+ MoreSpecs + '\n' + "Keyboard: "+ Keyboard + '\n' + "OS: "+ OS + '\n' + "Warranty: "+ Warranty,Name);

        }

        
    }
}
