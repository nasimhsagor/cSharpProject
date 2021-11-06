using LMS_ADMIN.Models;
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
    public partial class AllBookRecForm : Form
    {
        List<BookData> _bookdataList = new List<BookData>();
        public AllBookRecForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "SELECT * FROM BookDatas";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            SqlDataReader reader = sc.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    _bookdataList.Add(new BookData { Name = reader["Name"].ToString(), Author = reader["Author"].ToString(), Category = reader["Category"].ToString(), IsAvailable = (bool)reader["IsAvailable"], Content = reader["Content"].ToString() });
                }

                AllBookDataGrrid.DataSource = _bookdataList;
            }
            else
            {
                MessageBox.Show("You Currently have no book data in the library.\n\nPlease Add Some books First.", "Empty-Info");
            }

            s.Close();
            return;
        }
    }
}
