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
    public partial class Employee : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { set; get; }
        private string Query { set; get; }
        internal string Sql { get; set; }
        public Employee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.IdGenerate();
        }

       
        private void IdGenerate()
        {
            this.Query = "select * from Employee order by Id desc";
            this.Ds = this.Da.ExecuteQuery(this.Query);

            string previousId = this.Ds.Tables[0].Rows[0]["Id"].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "E-" + (++serialNo).ToString("000");
            this.txtId.Text = nextId;
            
        }

        private void PopulateGridView(string sql = "select * from Employee;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvEmployee.AutoGenerateColumns = false;
                this.dgvEmployee.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtPhone.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrEmpty(this.txtAddress.Text) ||
                    String.IsNullOrEmpty(this.cmbRole.Text))
                {
                    MessageBox.Show("To add  Product please fill all the information.");
                    return;
                }

                var sql = "select * from  Employee where Id = '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update Code
                    string query = "update Employee set EmpName = '" + this.txtName.Text + "', phone = " +
                                   this.txtPhone.Text + ", Role = '" + this.cmbRole.Text + "',Address = '" + this.txtAddress.Text + "'where Id = '" +
                                   this.txtId.Text + "';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Record Updated Successfully.");
                        
                    }
                    else
                    {
                        MessageBox.Show("Record Upgradation Failed.");
                    }
                }

                else
                {

                    //Insert Code
                    string query = "insert into Employee values ('" + this.txtId.Text + "','" + this.txtName.Text + "','" +
                     this.txtPassword.Text + "','" + this.txtPhone.Text + "','" + this.txtSalary.Text + "','" + this.txtAddress.Text + "','" + this.cmbRole.Text + "');";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Record Inserted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record Insertion Failed.");
                    }
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }

        }
        private void ClearAll()
        {
            this.txtAddress.Text = "";
            this.txtId.Text = "";
            this.txtPassword.Text = "";
            this.cmbRole.SelectedIndex = -1;
            this.txtSearch.Text = "";
            this.txtName.Text = "";
            this.txtPhone.Text = "";
            this.txtSalary.Text = "";
            this.IdGenerate();
            


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var id = this.dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
                    var name = this.dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();

                    string sql = "delete from Employee where Id = '" + id + "';";
                    int count = this.Da.ExecuteDML(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Employee "+ name +" has been deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Data Deletion Failed.");
                    }

                    this.PopulateGridView();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.dgvEmployee.DataSource = "";
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OwnerDashboard fo = new OwnerDashboard();
            fo.Visible = true;
            this.Visible = false;

        }

        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = this.dgvEmployee.CurrentRow.Cells["Id"].Value.ToString();
            this.txtName.Text = this.dgvEmployee.CurrentRow.Cells["EmpName"].Value.ToString();
            this.txtPassword.Text = this.dgvEmployee.CurrentRow.Cells["Password"].Value.ToString();
            this.txtPhone.Text = this.dgvEmployee.CurrentRow.Cells["Phone"].Value.ToString();
            this.txtSalary.Text = this.dgvEmployee.CurrentRow.Cells["Salary"].Value.ToString();
            this.txtAddress.Text = this.dgvEmployee.CurrentRow.Cells["Address"].Value.ToString();
            this.cmbRole.Text = this.dgvEmployee.CurrentRow.Cells["Role"].Value.ToString();
            this.txtId.ReadOnly = true;
            
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from Employee where  EmpName like '" + this.txtSearch.Text + "%' or Id like '" + this.txtSearch.Text + "%' or Phone like '" + this.txtSearch.Text + "%' or Role like '" + this.txtSearch.Text + "%';";
            this.PopulateGridView(this.Sql);
        }



    }
}
