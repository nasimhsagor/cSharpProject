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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrEmpty(PassBox.Text) || string.IsNullOrWhiteSpace(PassBox.Text) || string.IsNullOrEmpty(AboutBox.Text) || string.IsNullOrWhiteSpace(AboutBox.Text))
            {
                MessageBox.Show("Invalid Data. \nPlease Enter valid information and try again.");
                return;
            }

            try
            {
                using (var ldc = new Login())
                {
                    ldc.Name.( { Name = NameBox.Text});

                    ldc.SaveChanges();

                    MessageBox.Show("User-Profile Successfully Created.\nYou can now go back to login page and get into your account.\n\nThank You", "Success");

                    this.Hide();
                    loginform l = new loginform();
                    l.ShowDialog();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Something went wrong while creating profile.\nMake sure you have filled all the fields.\nOr check connection with db.");
            }
        }
    }
}
