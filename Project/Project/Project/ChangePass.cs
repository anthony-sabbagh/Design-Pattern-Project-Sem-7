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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm LG = new LoginForm();
            LG.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username, password;
            try
            {
                Stream s = new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Open);
                StreamReader sr = new StreamReader(s);
                username = sr.ReadLine();
                password = sr.ReadLine();
                s.Close();


                if (txtCurrentPassword.Text == password)
                {
                    if (txtNewPassword.Text != "")
                    {
                        if (chbNotRobot.CheckState == CheckState.Checked)
                        {
                            FileStream W = new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Create, FileAccess.Write);
                            StreamWriter sw = new StreamWriter(W);
                            sw.WriteLine(username + "\n" + txtNewPassword.Text);
                            sw.Close();

                            int lines = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").Length;

                            List<string> Info = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").ToList();

                            for (int i = 0; i < lines; i++)
                            {
                                if ((Info.Contains(username) == true) && (Info.Contains(password) == true))
                                {
                                    int j;
                                    j = Info.IndexOf(username);

                                    if (Info[j + 1] == password)
                                    {
                                        Info[j + 1] = txtNewPassword.Text;
                                        File.WriteAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt", Info);
                                        this.Close();

                                        System.Windows.Forms.MessageBox.Show("Password changed successfully!");
                                        LoginForm f1 = new LoginForm();
                                        f1.Show();
                                        break;
                                    }
                                    else
                                    {
                                        System.Windows.Forms.MessageBox.Show("You don't have an account please register");

                                    }

                                }
                                else
                                {
                                    System.Windows.Forms.MessageBox.Show("You don't have an account please register");

                                }
                            }

                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Please check checkbox!");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show("Please enter a new password!");
                }
                else
                    System.Windows.Forms.MessageBox.Show("Current password is wrong!");
            }

            catch (FileNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
