using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Abstract_Factory_Pattern.Abstract_Factory;
using Project.Abstract_Factory_Pattern.Abstract_Product;
using Project.Abstract_Factory_Pattern.Concrete_Products;
using Project.Abstract_Factory_Pattern.Concrete_Factories;
using System.Reflection;

namespace Project
{
    public partial class Laptop : Form
    {
        public Laptop()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBoxvictus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new HP_Factory();
            Factroy_1.CreateGamingLaptop().ShowInfo();

           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new Lenovo_Factory();
            Factroy_1.CreateGamingLaptop().ShowInfo();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new HP_Factory();
            Factroy_1.CreateBusinessLaptop().ShowInfo();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new Lenovo_Factory();
            Factroy_1.CreateBusinessLaptop().ShowInfo();
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new HP_Factory();
            Factroy_1.CreateEveryDayUseLaptop().ShowInfo();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ILaptopFactory Factroy_1 = new Lenovo_Factory();
            Factroy_1.CreateEveryDayUseLaptop().ShowInfo();

        }

        private void Laptop_Load(object sender, EventArgs e)
        {

        }

        private void sSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
            SSDForm1 sSDForm1 = new SSDForm1();
            sSDForm1.Show();
        }

        private void changePassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangePass E = new ChangePass();
            E.Show();
        }

        private void editInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ChangeUsername E = new ChangeUsername();
            E.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://as-shopswift.company.site/");
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/as_shop_swift?igshid=YmMyMTA2M2Y=");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Lf = new LoginForm();
            Lf.Show();
        }
    }
}
