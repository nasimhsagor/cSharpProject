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
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BookIDBox.Text) || string.IsNullOrWhiteSpace(BookIDBox.Text))
            {
                MessageBox.Show("Please enter a valid user ID and try again.", "Invalid Data");
                return;
            }

            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "DELETE FROM BookDatas WHERE BookID = " + BookIDBox.Text ;

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            int i = sc.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Book Data Successfully Deleted");

            }
            else
            {
                MessageBox.Show("Invalid Book-ID.\n", "Error");
            }

            s.Close();

        }
    }
}
