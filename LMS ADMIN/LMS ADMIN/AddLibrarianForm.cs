using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_ADMIN
{
    public partial class AddLibrarianForm : Form
    {
        public AddLibrarianForm()
        {
            InitializeComponent();

            MaleRadio.Checked = true;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrWhiteSpace(NameBox.Text) || string.IsNullOrEmpty(PassBox.Text) || string.IsNullOrWhiteSpace(PassBox.Text) || string.IsNullOrEmpty(EmailBox.Text) || string.IsNullOrWhiteSpace(EmailBox.Text))
            {
                MessageBox.Show("Invalid Data. \nPlease Enter valid information and try again.");
                return;
            }

            int gender = 0;
            if (MaleRadio.Checked)
            {
                gender = 0;
            }
            else
            {
                gender = 1;
            }

            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "INSERT INTO UserDatas(Name,Password,Email,UserRole,Gender) VALUES('" + NameBox.Text + "','" + PassBox.Text + "','" + EmailBox.Text + "'," + 1 + "," + gender.ToString() + ")";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            int i = sc.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Librarian-Profile Successfully Created.\n\nThank You", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong while creating profile.\nMake sure you have filled all the fields.\nOr check connection with db.");
            }

            s.Close();

            return;
        }
    }
}
