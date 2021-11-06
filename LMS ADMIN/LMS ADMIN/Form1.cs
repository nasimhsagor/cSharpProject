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
using LMS_ADMIN.Models;

namespace LMS_ADMIN
{
    public partial class Form1 : Form
    {
        List<UserData> _userDataList = new List<UserData>();


        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["CONS"].ConnectionString);

            string q = "SELECT * FROM UserDatas";

            SqlCommand sc = new SqlCommand(q, s);

            s.Open();
            SqlDataReader reader = sc.ExecuteReader();

            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    UserData u = new UserData { Name = reader["Name"].ToString(), Email = reader["Email"].ToString(), Password = reader["Password"].ToString(), Gender = (int)reader["Gender"], UserID = (int)reader["UserID"], UserRole = (int)reader["UserRole"] };

                    if (u.Name == UserNameBox.Text && u.Password == PassBox.Text)
                    {
                        if (u.UserRole == 0)
                        {
                            s.Close();
                            AdminHomeForm h = new AdminHomeForm(u);
                            this.Hide();
                            h.ShowDialog();
                            this.Close();

                            return;
                        }
                        else
                        {
                            MessageBox.Show("You must be an admin to access this. \n\nThsi part of the project only contains the admin scene.", "unAuth");

                            return;
                        }
                    }
                }
            }
            else
            {

                s.Close();
                MessageBox.Show("No user Data added yet.");
                return;
            }


            s.Close();
            MessageBox.Show("Invalid User Name/Password","Error");
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
