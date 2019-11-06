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
        int tries = 0;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Plz type a user name and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                cn1.Open();
                cmd1.CommandText = "SELECT [Passowrd]  FROM [Northwind].[dbo].[Employees] WHERE LastName = '" + txtLogin.Text + "' AND Passowrd = '" + txtPass.Text + "'";
                string pass = Convert.ToString(cmd1.ExecuteScalar());
                if (txtPass.Text == pass)
                {
                    frmDB mydta = new frmDB();
                    mydta.Show();
                    this.Hide();
                }
                else
                {
                    if (++tries < 3)
                        MessageBox.Show("Wrong Username or Password\n\tPlease try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        MessageBox.Show("Client is locked after Several login attempts!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                cn1.Close();
            }

        }


    }
}
