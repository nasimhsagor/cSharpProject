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
    public partial class RemoveStudentForm : Form
    {
        public RemoveStudentForm()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserIDBox.Text) || string.IsNullOrWhiteSpace(UserIDBox.Text))
            {
                MessageBox.Show("Please enter a valid user ID and try again.", "Invalid Data");
                return;
            }

            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "DELETE FROM UserDatas WHERE UserID = " + UserIDBox.Text + " AND UserRole=2";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            int i = sc.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("User Data Successfully Deleted");

            }
            else
            {
                MessageBox.Show("Invalid User-ID.\n\nMake Sure the ID belongs to a student-User-Account.","Error");
            }

            s.Close();

            return;

        }
    }
}
