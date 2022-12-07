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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            List<string> Info = File.ReadAllLines(@"C:\Users\Sabbagh\Desktop\Project\Order.txt").ToList();

            if (txtUsername.Text != "")
            {
                if (Info.Contains(txtUsername.Text) == true)
                {


                    int a = 0;

                    for (int i = 0; i < Info.Count; i++)
                    {
                        if (Info[i] == txtUsername.Text)
                        {
                            a++;
                        }
                    }
                    int[] index = new int[a];
                    int b = 0;
                    for (int i = 0; i < Info.Count; i++)
                    {
                        if (Info[i] == txtUsername.Text)
                        {

                            index[b] = i;
                            b++;
                        }
                    }
                    for (int i = 0; i < a; i++)
                    {
                        int j;
                        j = index[i];
                        string[] row = new string[5];

                        row[0] = Info[j + 1];
                        row[1] = Info[j + 2];
                        row[2] = Info[j + 3];
                        row[3] = Info[j + 4];
                        row[4] = Info[j + 5];


                        string[] row1 = new string[] { row[0], row[1], row[2], row[3], row[4] };
                        object[] rows = new object[] { row1 };
                        foreach (string[] rowArray in rows)
                        {
                            dataGridInfo.Rows.Add(rowArray);
                        }

                    }
                }
                else
                    MessageBox.Show("This Username Doesn't have an order", "ERROR!");
                
            }
            else
                MessageBox.Show("Please enter a Username", "ERROR!");


        }





        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = dataGridInfo.ColumnHeadersDefaultCellStyle;

            dataGridInfo.ColumnCount = 5;

            dataGridInfo.Columns[0].Name = "SSD Description";
            dataGridInfo.Columns[1].Name = "SSD Price";
            dataGridInfo.Columns[2].Name = "Enclosur Descriptione";
            dataGridInfo.Columns[3].Name = "Enclosur Price";
            dataGridInfo.Columns[4].Name = "Total Price";

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lF = new LoginForm();
            lF.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dataGridInfo.Rows.Count != 0)
            {
                dataGridInfo.Rows.Clear();
            }else
                MessageBox.Show("DataGrid is already empty");

            
        }

    }
}
