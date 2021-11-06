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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // validation
            if (string.IsNullOrEmpty(NameBox.Text) || string.IsNullOrEmpty(AuthorBox.Text) || string.IsNullOrEmpty(ContentBox.Text) || string.IsNullOrEmpty(CategoryBox.Text))
            {
                MessageBox.Show("Enter Valid Book-Name, category,  Content & Author-Name", "Invalid Data");
                return;
            }

            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "INSERT INTO BookDatas(Name,Author,IsAvailable,Category,Content) VALUES('" + NameBox.Text + "','" + AuthorBox.Text + "','" + true + "','" + CategoryBox.Text + "','" + ContentBox.Text + "')";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            int i = sc.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("New Book Successfully Added.\n\nThank You", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong while Adding BookData.\nMake sure you have filled all the fields.\nOr check connection with db.");
            }

            s.Close();

            return;
        }
    }
}
