using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtLastName.Text != "" && txtName.Text != ""  && txtUsername.Text != "" && txtPassword.Text != "" )
                {
                    List<string> Loginid = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").ToList();

                    if (Loginid.Contains(txtUsername.Text) == false)
                    {

                        
                            if (txtName.Text != txtUsername.Text)
                            {
                                if (txtLastName.Text != txtUsername.Text)
                                {
                                    
                                        
                                                string P = @"C:\Users\Sabbagh\Desktop\Project\Info.txt";
                                                List<string> Info = File.ReadAllLines(P).ToList();
                                                Info.Add(txtLastName.Text + "\n" + txtName.Text + "\n" +  txtUsername.Text + "\n" + txtPassword.Text + "\n" );
                                                File.WriteAllLines(P, Info);
                                                MessageBox.Show("Account created");
                                                this.Close();
                                                LoginForm LG = new LoginForm();
                                                LG.Show();
                                            
                                }
                                else
                                    MessageBox.Show("Username should be different form LastName");
                            }
                            else
                                MessageBox.Show("Username should be different form Name");

                    }
                    else
                        MessageBox.Show("Username not available");

                }
                else
                    MessageBox.Show("Please fill all the information");


            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (FileLoadException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
           
            txtLastName.Clear();
            txtName.Clear();          
            txtUsername.Clear();
            txtPassword.Clear();
           
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LG = new LoginForm();
            LG.Show();
        }
    }
}
