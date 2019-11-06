using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class lgnfrm : Form
    {
        int tries = 0;
        public lgnfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lgnbtn_Click(object sender, EventArgs e)
        {
            if (usrtxt.Text == "" || passtxt.Text == "" )
            {
                MessageBox.Show("Plz type a user name and password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                sqlConnection1.Open();
                sqlCommand1.CommandText = "SELECT [Passowrd]  FROM [Northwind].[dbo].[Employees] WHERE FirstName = '" + usrtxt.Text + "' AND Passowrd = '" + passtxt.Text + "'";
                string pass = Convert.ToString(sqlCommand1.ExecuteScalar());
                if (passtxt.Text == pass)
                {
                    dtafrm mydta = new dtafrm();
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
                sqlConnection1.Close();
            }
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void cnclbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
