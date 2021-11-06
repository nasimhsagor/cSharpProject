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
    public partial class TotalStudentForm : Form
    {
        List<UserData> _userDataList = new List<UserData>();
        public TotalStudentForm()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "SELECT * FROM UserDatas WHERE UserRole = " + 2;

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            SqlDataReader reader = sc.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    _userDataList.Add(new UserData { Name = reader["Name"].ToString(), Email = reader["Email"].ToString(), Password = reader["Password"].ToString(), Gender = (int)reader["Gender"], UserID = (int)reader["UserID"], UserRole = (int)reader["UserRole"] });
                }

                AllStudentGrid.DataSource = _userDataList;
            }
            else
            {
                MessageBox.Show("You Currently have no student data in the library.\n\nPlease Add Some Student First.","Empty-Info");
            }

            s.Close();
            return;
        }
    }
}
