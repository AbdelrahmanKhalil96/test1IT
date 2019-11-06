using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int counter = 1;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (counter <= 3)
            {
                cn1.Open();
                cmd1.CommandText = "SELECT [LastName],[Passowrd] FROM [Northwind].[dbo].[Employees] where LastName = '" + txtLogin.Text + "' and Passowrd = '" + txtPass.Text + "'";
                String a = Convert.ToString(cmd1.ExecuteScalar());
                if (a != "")
                {
                    frmDB frm2 = new frmDB();
                    frm2.Show();
                }
                else
                {
                    counter++;
                }
                cn1.Close();
            }
            else
            {
                MessageBox.Show("3 Tries Exceeded, please restart the program :3)", "User Locked",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }


    }
}
