using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace LMS_ADMIN
{
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();

            UserTypeCombo.Items.Add("Admin");
            UserTypeCombo.Items.Add("Librarian");
            UserTypeCombo.Items.Add("Student");

            MaleRadio.Checked = true;

            UserTypeCombo.SelectedIndex = 0;
        }

        private void Create_Click(object sender, EventArgs e)
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
            
            string q = "INSERT INTO UserDatas(Name,Password,Email,UserRole,Gender) VALUES('" + NameBox.Text + "','" + PassBox.Text + "','" + EmailBox.Text + "'," + UserTypeCombo.SelectedIndex + "," + gender.ToString() + ")";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
           int i = sc.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("User-Profile Successfully Created.\nYou can now go back to login page and get into your account.\n\nThank You", "Success");
                

                this.Hide();
                Form1 l = new Form1();
                l.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong while creating profile.\nMake sure you have filled all the fields.\nOr check connection with db.");
            }

            s.Close();
        }
    }
}
