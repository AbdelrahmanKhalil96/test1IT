namespace test1
{
    partial class Login
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cn1 = new System.Data.SqlClient.SqlConnection();
            this.cmd1 = new System.Data.SqlClient.SqlCommand();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(111, 37);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.Size = new System.Drawing.Size(85, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "M.Yahia";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(111, 86);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '#';
            this.txtPass.Size = new System.Drawing.Size(85, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "123456";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(27, 41);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(57, 13);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(27, 90);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(53, 13);
            this.PassWord.TabIndex = 3;
            this.PassWord.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(30, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cn1
            // 
            this.cn1.ConnectionString = "Data Source=10.10.30.59;Initial Catalog=Northwind;Persist Security Info=True;User" +
                " ID=sa;Password=kapsi";
            this.cn1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cmd1
            // 
            this.cmd1.CommandText = "SELECT        LastName, Passowrd\r\nFROM            Employees";
            this.cmd1.Connection = this.cn1;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(251, 144);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 190);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Button btnLogin;
        private System.Data.SqlClient.SqlConnection cn1;
        private System.Data.SqlClient.SqlCommand cmd1;
        private System.Windows.Forms.Button exitbtn;
    }
}

