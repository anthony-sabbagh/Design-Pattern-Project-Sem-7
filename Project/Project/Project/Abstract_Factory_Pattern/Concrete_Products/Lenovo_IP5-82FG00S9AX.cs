using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Product;

namespace Project.Abstract_Factory_Pattern.Concrete_Products
{
    public class Lenovo_IP5_82FG00S9AX : LaptopFactory
    {
        public Lenovo_IP5_82FG00S9AX()
        {
            Name = "Lenovo_IP5_82FG00S9AX";
            Price = "800";
            Processor = "Core I7-1165G7";
            RAM = "8GB DDR4";
            Storage = "NVMe 512GB ";
            VGA = "2GB GDDR6 Dedicated NVIDIA® GeForce® MX450";
            Screen = "15.6'' FHD ";
            DVDRW = "NO";
            LAN = "NO";
            MoreSpecs = "";
            Keyboard = "ENG/AR";
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
