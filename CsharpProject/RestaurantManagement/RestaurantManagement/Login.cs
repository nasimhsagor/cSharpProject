using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employee where Id = '" + this.txtId.Text + "' and Password = '" + this.txtPassword.Text + "';";

            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Successful");
                string t = this.Ds.Tables[0].Rows[0][6].ToString();
                /*int a = t.Length;
                string b = a.ToString();
                MessageBox.Show(b);*/

                if (this.Ds.Tables[0].Rows[0][6].ToString().Equals("owner     "))
                {
                   
                    OwnerDashboard fa = new OwnerDashboard();
                    fa.Visible = true;
                    this.Visible = false;
                   
                }
               else if (t.Equals("manager   "))
               {
                   ManagerDashboard fm = new ManagerDashboard();
                   fm.Visible = true;
                   this.Visible = false;


               }
                else if (t.Equals("salesman  "))
               {
                   SalesmanDashboard fs = new SalesmanDashboard();
                   fs.Visible = true;
                   this.Visible = false;

               }

            }
            else
            {
                MessageBox.Show("Login Failed\n Please Try Again");
            }


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtPassword.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Welcome wf = new Welcome();
            wf.Visible = true;
        }



    }
}
   

