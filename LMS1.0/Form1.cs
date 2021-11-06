using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS1._0
{
    public partial class loginform : Form
    {
        private LoginInfo Lip { get; set; }
        private Login Li { get; set; }
        public loginform()
        {
            InitializeComponent();
            this.Lip = new LoginInfo();
            this.Li = new Login();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!Validation.IsStringValid(this.UserNameBox.Text) || !Validation.IsStringValid(this.PassBox.Text))
            {
                MessageBox.Show("Please fill every field properly", "Empty or whitespace", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.Li.Name = this.UserNameBox.Text;
                this.Li.Password = this.PassBox.Text;
                if (this.Li == null)
                {
                    MessageBox.Show("Wrong id or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    new AdminHome().Show();
                    this.Visible = false;
                }
            }
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAcc c = new CreateAcc();
            c.ShowDialog();
            this.Close();

        }
    }
}
