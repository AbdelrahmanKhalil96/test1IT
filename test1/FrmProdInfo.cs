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
    public partial class FrmProdInfo : Form
    {
        public FrmProdInfo(int ProdID, String CategoryName,String ProductName)
        {
            InitializeComponent();
            this.ProdID = ProdID;
            this.CategoryName = CategoryName;
            this.ProductName = ProductName;
        }

        int ProdID = 0;
        String CategoryName = "";
        String ProductName = "";
        private void FrmProdInfo_Load(object sender, EventArgs e)
        {
            //**** Select Where ProdID ******* 
            txtProdID.Text = ProdID.ToString();
            txtProdName.Text = ProductName;
            txtCategoryName.Text = CategoryName;

        }

        private void txtProdID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
