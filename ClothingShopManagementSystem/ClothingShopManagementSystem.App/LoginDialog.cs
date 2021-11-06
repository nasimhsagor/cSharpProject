using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingShopManagementSystem.Entity;
using ClothingShopManagementSystem.Repository;
using ClothingShopManagementSystem.Framework;

namespace ClothingShopManagementSystem.App
{
    
    public partial class LoginDialog : Form
    {
        private LoginInfoRepo Lip { get; set; }
        private Login Li { get; set; }
        public LoginDialog()
        {
            InitializeComponent();
            this.Lip = new LoginInfoRepo();
            this.Li = new Login();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chbShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void icnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.txtId.Clear();
            this.txtPassword.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!Validation.IsStringValid(this.txtId.Text)||!Validation.IsStringValid(this.txtPassword.Text))
            {
                MessageBox.Show("Please fill every field properly", "Empty or whitespace", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Li.id = this.txtId.Text;
                this.Li.password = this.txtPassword.Text;
                this.Li = this.Lip.Search(Li);
                if (this.Li==null)
                {
                    MessageBox.Show("Wrong id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Adjustment.Role = this.Li.role;
                    this.Lip.InseartIntoLoginHistory(this.Li);
                    new DashBord().Show();
                    this.Visible = false;
                }
            }
        }
    }
}
