using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Concrete_Component;
using Concrete_Decorators;
using Component_Base;
using System.IO;

namespace Project
{
    public partial class SSDForm1 : Form
    {
        string PriceSSD;
        string User;
        string PriceEnclosure;
        string PriceT;
        String DescriptionSSD;
        String DescriptionEnclosure;
        public SSDForm1()
        {
            InitializeComponent();
        }

        private void laptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laptop E = new Laptop();
            E.Show();
        }

        private void SSDForm1_Load(object sender, EventArgs e)
        {
            SSD k240Gb = new Kingston_240Gb();
            txtSsd240Des.Text = k240Gb.GetDescription();
            txtSsd240Pr.Text = k240Gb.GetPrice().ToString();

            SSD k480Gb = new Kingston_480Gb();
            txtSsd480Des.Text = k480Gb.GetDescription();
            txtSsd480Pr.Text = k480Gb.GetPrice().ToString();

            SSD k960Gb = new Kingston_960Gb();
            txtSsd960Des.Text = k960Gb.GetDescription();
            txtSsd960Pr.Text = k960Gb.GetPrice().ToString();


            Stream s = new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Open);
            StreamReader sr = new StreamReader(s);
            User = sr.ReadLine();            
            s.Close();
            sr.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

           
            if (rdbtn240.Checked == true)
            {

                if (rdbtn2_5.Checked == true)
                {
                    SSD k240Gb = new Kingston_240Gb();
                    PriceSSD = k240Gb.GetPrice().ToString();
                    DescriptionSSD = k240Gb.GetDescription();
                    k240Gb = new _2(k240Gb);
                    PriceEnclosure = "10";
                    PriceT= k240Gb.GetPrice().ToString();                  
                    DescriptionEnclosure = k240Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n'+ "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                    

                }
                else if (rdbtnAdata.Checked == true)
                {
                    SSD k240Gb = new Kingston_240Gb();
                    PriceSSD = k240Gb.GetPrice().ToString();
                    DescriptionSSD = k240Gb.GetDescription();
                    k240Gb = new XPG_EX500(k240Gb);
                    PriceEnclosure = "15";
                    PriceT = k240Gb.GetPrice().ToString();
                    DescriptionEnclosure = k240Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else if (rdbtnAnti.Checked == true)
                {
                    SSD k240Gb = new Kingston_240Gb();
                    PriceSSD = k240Gb.GetPrice().ToString();
                    DescriptionSSD = k240Gb.GetDescription();
                    k240Gb = new ED600(k240Gb);
                    PriceEnclosure = "15";
                    PriceT = k240Gb.GetPrice().ToString();
                    DescriptionEnclosure = k240Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else
                    MessageBox.Show("Please choose an ENCLOSURE", "ERROR!");

            } else if (rdbtn480.Checked == true)
            {
                if (rdbtn2_5.Checked == true)
                {
                    SSD k480Gb = new Kingston_480Gb();
                    PriceSSD = k480Gb.GetPrice().ToString();
                    DescriptionSSD = k480Gb.GetDescription();
                    k480Gb = new _2(k480Gb);
                    PriceEnclosure = "10";
                    PriceT = k480Gb.GetPrice().ToString();
                    DescriptionEnclosure = k480Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else if (rdbtnAdata.Checked == true)
                {
                    SSD k480Gb = new Kingston_480Gb();
                    PriceSSD = k480Gb.GetPrice().ToString();
                    DescriptionSSD = k480Gb.GetDescription();
                    k480Gb = new XPG_EX500(k480Gb);
                    PriceEnclosure = "15";
                    PriceT = k480Gb.GetPrice().ToString();
                    DescriptionEnclosure = k480Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");
                  
                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else if (rdbtnAnti.Checked == true)
                {
                    SSD k480Gb = new Kingston_480Gb();
                    PriceSSD = k480Gb.GetPrice().ToString();
                    DescriptionSSD = k480Gb.GetDescription();
                    k480Gb = new ED600(k480Gb);
                    PriceEnclosure = "15";
                    PriceT = k480Gb.GetPrice().ToString();
                    DescriptionEnclosure = k480Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else
                    MessageBox.Show("Please choose an ENCLOSURE", "ERROR!");

            } else if (rdbtn960.Checked == true)
            {
                if (rdbtn2_5.Checked == true)
                {
                    SSD k960Gb = new Kingston_960Gb();
                    PriceSSD = k960Gb.GetPrice().ToString();
                    DescriptionSSD = k960Gb.GetDescription();
                    k960Gb = new _2(k960Gb);
                    PriceEnclosure = "10";
                    PriceT = k960Gb.GetPrice().ToString();
                    DescriptionEnclosure = k960Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");
                    
                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else if (rdbtnAdata.Checked == true)
                {
                    SSD k960Gb = new Kingston_960Gb();
                    PriceSSD = k960Gb.GetPrice().ToString();
                    DescriptionSSD = k960Gb.GetDescription();
                    k960Gb = new XPG_EX500(k960Gb);
                    PriceEnclosure = "15";
                    PriceT = k960Gb.GetPrice().ToString();
                    DescriptionEnclosure = k960Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else if (rdbtnAnti.Checked == true)
                {
                    SSD k960Gb = new Kingston_960Gb();
                    PriceSSD = k960Gb.GetPrice().ToString();
                    DescriptionSSD = k960Gb.GetDescription();
                    k960Gb = new ED600(k960Gb);
                    PriceEnclosure = "15";
                    PriceT = k960Gb.GetPrice().ToString();
                    DescriptionEnclosure = k960Gb.GetDescription();
                    MessageBox.Show("Description: " + DescriptionSSD + '\n' + "Price: " + PriceSSD + '\n' + "Description: " + DescriptionEnclosure + '\n' + "Price: " + PriceEnclosure + '\n' + "Total Price: " + PriceT, "Receipt");

                    string P = @"C:\Users\Sabbagh\Desktop\Project\Order.txt";
                    List<string> Order = File.ReadAllLines(P).ToList();
                    Order.Add(User + "\n" + DescriptionSSD + "\n" + PriceSSD + "\n" + DescriptionEnclosure + "\n" + PriceEnclosure + "\n" + PriceT + "\n");
                    File.WriteAllLines(P, Order);
                    MessageBox.Show("Order Made");
                }
                else
                    MessageBox.Show("Please choose an ENCLOSURE", "ERROR!");

            } else
                MessageBox.Show("Please choose an SSD", "ERROR!");
        }

        private void rdbtnAnti_CheckedChanged(object sender, EventArgs e)
        {

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

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/as_shop_swift?igshid=YmMyMTA2M2Y=");
        }

        private void siteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://as-shopswift.company.site/");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm Lf = new LoginForm();
            Lf.Show();
        }
    }
}
