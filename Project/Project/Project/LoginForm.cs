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
    public partial class LoginForm : Form
    {
        public string username, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string F = @"C:\Users\Sabbagh\Desktop\Project\Info.txt";
                List<string> Loginid = File.ReadAllLines(F).ToList();

                if (txtUsername.Text != "admin" || txtPassword.Text != "admin")
                {
                    if ((Loginid.Contains(txtUsername.Text) == true) && (Loginid.Contains(txtPassword.Text) == true))
                    {
                        int i;
                        i = Loginid.IndexOf(txtUsername.Text);

                        if (Loginid[i + 1] == txtPassword.Text)
                        {
                            using (TextWriter Hr = new StreamWriter(new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Create, FileAccess.Write), new UTF8Encoding()))
                            {
                                Hr.WriteLine(txtUsername.Text);
                                Hr.WriteLine(txtPassword.Text);
                            }

                            this.Hide();

                            StatusCheck E = new StatusCheck();
                            E.LoginEV += new LoginEventHandler(LoginEV);
                            E.L(this.txtUsername.Text, this.txtPassword.Text);
                        }
                        else
                            MessageBox.Show("Username or Password is wrong!", "Error!");
                    }
                    else
                        MessageBox.Show("Username or Password is wrong!", "Error!");

                }
                else
                {

                    this.Hide();

                    StatusCheck E = new StatusCheck();
                    E.LoginEV += new LoginEventHandler(LoginEV);
                    E.L(this.txtUsername.Text, this.txtPassword.Text);
                }
            }

            catch (FileNotFoundException  ex)
            {
                MessageBox.Show("Username not created please register");
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            void LoginEV(string loginName, bool status)
            {
                if (status == true)
                {
                    MessageBox.Show("Login status : Employee", "Success!");

                }
                else
                    MessageBox.Show("Login status : Client", "Success!");

            }
        }
    }
}
