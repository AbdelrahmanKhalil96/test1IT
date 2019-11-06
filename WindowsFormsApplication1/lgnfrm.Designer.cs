namespace WindowsFormsApplication1
{
    partial class lgnfrm
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
            this.cnclbtn = new System.Windows.Forms.Button();
            this.lgnbtn = new System.Windows.Forms.Button();
            this.usrlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usrtxt = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // cnclbtn
            // 
            this.cnclbtn.Location = new System.Drawing.Point(148, 175);
            this.cnclbtn.Name = "cnclbtn";
            this.cnclbtn.Size = new System.Drawing.Size(75, 23);
            this.cnclbtn.TabIndex = 4;
            this.cnclbtn.Text = "Cancel";
            this.cnclbtn.UseVisualStyleBackColor = true;
            this.cnclbtn.Click += new System.EventHandler(this.cnclbtn_Click);
            // 
            // lgnbtn
            // 
            this.lgnbtn.Location = new System.Drawing.Point(27, 175);
            this.lgnbtn.Name = "lgnbtn";
            this.lgnbtn.Size = new System.Drawing.Size(75, 23);
            this.lgnbtn.TabIndex = 3;
            this.lgnbtn.Text = "Login";
            this.lgnbtn.UseVisualStyleBackColor = true;
            this.lgnbtn.Click += new System.EventHandler(this.lgnbtn_Click);
            // 
            // usrlbl
            // 
            this.usrlbl.AutoSize = true;
            this.usrlbl.Location = new System.Drawing.Point(24, 72);
            this.usrlbl.Name = "usrlbl";
            this.usrlbl.Size = new System.Drawing.Size(55, 13);
            this.usrlbl.TabIndex = 2;
            this.usrlbl.Text = "Username";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(24, 129);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(53, 13);
            this.passlbl.TabIndex = 3;
            this.passlbl.Text = "Password";
            this.passlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(106, 126);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(131, 20);
            this.passtxt.TabIndex = 2;
            // 
            // usrtxt
            // 
            this.usrtxt.Location = new System.Drawing.Point(106, 72);
            this.usrtxt.Name = "usrtxt";
            this.usrtxt.Size = new System.Drawing.Size(131, 20);
            this.usrtxt.TabIndex = 1;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=10.10.30.59;User ID=sa;Password=kapsi";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // lgnfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.usrtxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usrlbl);
            this.Controls.Add(this.lgnbtn);
            this.Controls.Add(this.cnclbtn);
            this.Name = "lgnfrm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cnclbtn;
        private System.Windows.Forms.Button lgnbtn;
        private System.Windows.Forms.Label usrlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usrtxt;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}

