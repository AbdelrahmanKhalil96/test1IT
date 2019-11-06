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
        public FrmProdInfo(int ProdID)
        {
            InitializeComponent();
            this.ProdID = ProdID;
        }

        int ProdID = 0;
        private void FrmProdInfo_Load(object sender, EventArgs e)
        {
            //**** Select Where ProdID ******* 
            txtProdID.Text = ProdID.ToString();

        }
    }
}
