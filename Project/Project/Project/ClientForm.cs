using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            SSDForm1 SD = new SSDForm1();
            SD.Show();
        }

        private void laptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laptop E = new Laptop();
            E.Show();
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
