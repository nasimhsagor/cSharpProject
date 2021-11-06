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
                MessageBox.Show("Login Valid");
                var t = this.Ds.Tables[0].Rows[0][6].ToString();
                //MessageBox.Show(t);
               if (t.Equals("owner"))
                {
                   
                    OwnerDashboard fa = new OwnerDashboard();
                    fa.Visible = true;
                    this.Visible = true;
                   
                }
               else if (t.Equals("manager"))
               {
                   ManagerDashboard fm = new ManagerDashboard();
                   fm.Visible = true;
                   this.Visible = true;


               }
               else
               {
                   SalesmanDashboard fs = new SalesmanDashboard();
                   fs.Visible = true;

               }

            }
            else
            {
                MessageBox.Show("Login Invalid");
            }


        }



    }
}
   

