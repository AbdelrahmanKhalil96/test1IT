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
    public partial class frmDB : Form
    {
        public frmDB()
        {
            InitializeComponent();
        }


        DataView dv = new DataView();
        private void frmDB_Load(object sender, EventArgs e)
        {
            conn1.Open();
            cmd1.CommandText = "SELECT ProductID, Categories.CategoryName, Suppliers.CompanyName, Products.ProductName " +
                               " FROM Categories INNER JOIN " +
                               " Products ON Categories.CategoryID = Products.CategoryID INNER JOIN " +
                                " Suppliers ON Products.SupplierID = Suppliers.SupplierID";
            DataTable dt_Products = new DataTable("dt_Prod");

            dt_Products.Load(cmd1.ExecuteReader());
            dv.Table = dt_Products;
            dgvProd.DataSource = dv;
            dgvProd.Columns["ProductID"].Visible = false;
        }


        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = "ProductName like '" + txtProdNameSearch.Text + "%' AND CategoryName like '" + txtCategoryNameSearch.Text + "%'";
            
        }

        private void dgvProd_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd["ProductName", e.RowIndex].Value != null)
            {
                txtProdName.Text = dgvProd["ProductName", e.RowIndex].Value.ToString();
                txtCategoryName.Text = dgvProd["CategoryName", e.RowIndex].Value.ToString();
            }
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProd["ProductName", e.RowIndex].Value != null)
            {
                int ProdID = int.Parse(dgvProd["ProductID", e.RowIndex].Value.ToString());
                String CategoryName = dgvProd["CategoryName", e.RowIndex].Value.ToString();
                String ProductName = dgvProd["ProductName", e.RowIndex].Value.ToString();
                FrmProdInfo f = new FrmProdInfo(ProdID, CategoryName, ProductName);
                f.Show();
                
            }

        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
