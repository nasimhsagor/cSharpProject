using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingShopManagementSystem.App
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbShowPassword.Checked)
            {
                this.txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtLoginPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
