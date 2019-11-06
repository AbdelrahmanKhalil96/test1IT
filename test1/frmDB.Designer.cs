namespace test1
{
    partial class frmDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.conn1 = new System.Data.SqlClient.SqlConnection();
            this.cmd1 = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdNameSearch = new System.Windows.Forms.TextBox();
            this.txtCategoryNameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(12, 45);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProd.Size = new System.Drawing.Size(420, 254);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellDoubleClick);
            this.dgvProd.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_RowEnter);
            // 
            // conn1
            // 
            this.conn1.ConnectionString = "Data Source=10.10.30.59;Initial Catalog=Northwind;Persist Security Info=True;User" +
                " ID=sa;Password=kapsi";
            this.conn1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmd1
            // 
            this.cmd1.Connection = this.conn1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prod Name:";
            // 
            // txtProdNameSearch
            // 
            this.txtProdNameSearch.Location = new System.Drawing.Point(81, 13);
            this.txtProdNameSearch.Name = "txtProdNameSearch";
            this.txtProdNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtProdNameSearch.TabIndex = 2;
            this.txtProdNameSearch.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // txtCategoryNameSearch
            // 
            this.txtCategoryNameSearch.Location = new System.Drawing.Point(268, 13);
            this.txtCategoryNameSearch.Name = "txtCategoryNameSearch";
            this.txtCategoryNameSearch.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryNameSearch.TabIndex = 4;
            this.txtCategoryNameSearch.TextChanged += new System.EventHandler(this.txtCategoryName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cat Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(279, 318);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txtCategoryName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cat Name:";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(92, 318);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prod Name:";
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 366);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategoryNameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdNameSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProd);
            this.Name = "frmDB";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Data.SqlClient.SqlConnection conn1;
        private System.Data.SqlClient.SqlCommand cmd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdNameSearch;
        private System.Windows.Forms.TextBox txtCategoryNameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label4;
    }
}