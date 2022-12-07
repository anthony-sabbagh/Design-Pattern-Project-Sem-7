using Project.Memento_Pattern.Caretaker;
using Project.Memento_Pattern.Originator;
using Project.Memento_Pattern.Memento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ChangeUsername : Form
    {
        public ChangeUsername()
        {
            InitializeComponent();
        }

        string OldUser;
        string OldPass;
        Person person = new Person();
        PersonCaretaker caretaker = new PersonCaretaker();
        string OldUser1;




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangeUsername_Load(object sender, EventArgs e)
        {


            Stream s = new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Open);
            StreamReader sr = new StreamReader(s);
            OldUser = sr.ReadLine();
            OldPass = sr.ReadLine();
            OldUser1 = OldUser;
            s.Close();
            sr.Close();


            person.Username = OldUser;
            person.Password = OldPass;
           



        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            caretaker.Add(person.CreateUnDo());


            List<string> Loginid = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").ToList();
            if (txtUsername.Text != null)
            {
                if (Loginid.Contains(txtUsername.Text) == false)

                {
                    if(txtPassword.Text== OldPass)
                    {
                        person.Username = txtUsername.Text;
                        

                        using (TextWriter Hr = new StreamWriter(new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Create, FileAccess.Write), new UTF8Encoding()))
                        {
                            Hr.WriteLine(person.Username);
                            Hr.WriteLine(OldPass);
                        }


                        MessageBox.Show("Username changed");
                    }
                    else
                        MessageBox.Show("Wrong Password", "Error!");
                }
                else
                    MessageBox.Show("Username not available", "Error!");
            }
            else
                MessageBox.Show("Please fill Username", "Error!");

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            person.UnDo(caretaker.GetMemento());
            using (TextWriter Hr = new StreamWriter(new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Create, FileAccess.Write), new UTF8Encoding()))
            {
                Hr.WriteLine(person.Username);
                Hr.WriteLine(OldPass);
            }
            
            MessageBox.Show("Old Username");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            string username, password;
            
                Stream s = new FileStream(@"C:\Users\Sabbagh\Desktop\Project\current.txt", FileMode.Open);
                StreamReader sr = new StreamReader(s);
                username = sr.ReadLine();
                password = sr.ReadLine();
                s.Close();


                
                        
                            
                            int lines = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").Length;

                            List<string> Info = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt").ToList();

                            for (int i = 0; i < lines; i++)
                            {
                                if ((Info.Contains(OldUser1) == true) && (Info.Contains(OldPass) == true))
                                {
                                    int j;
                                    j = Info.IndexOf(OldUser1);

                                    if (Info[j+1] == OldPass)
                                    {
                                        Info[j] = username;
                                        File.WriteAllLines(@"C:\Users\Sabbagh\Desktop\Project\Info.txt", Info);
                                        this.Close();

                                        System.Windows.Forms.MessageBox.Show("Password changed successfully in database!");
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

                        
                   




           this.Close();
            ClientForm CF = new ClientForm();
            CF.Show();    
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
