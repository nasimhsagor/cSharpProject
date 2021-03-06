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
    public partial class ManagerDashboard : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { set; get; }
        private string Query { set; get; }
        public ManagerDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.ProductIdGenerate();
        }
        private void ProductIdGenerate()
        {
            this.Query = "select * from Product order by pid desc";
            this.Ds = this.Da.ExecuteQuery(this.Query);

            string previousId = this.Ds.Tables[0].Rows[0]["pid"].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "P-" + (++serialNo).ToString("000");
            this.txtPid.Text = nextId;

        }
        private void PopulateGridView(string sql = "select * from Product;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvProduct.AutoGenerateColumns = false;
                this.dgvProduct.DataSource = ds.Tables[0];

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
                if (String.IsNullOrEmpty(this.txtPid.Text) || String.IsNullOrEmpty(this.txtPname.Text) ||
                String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.cmbCatagory.Text) 
                )
                {
                    MessageBox.Show("To add  Product please fill all the information.");
                    return;
                }

                var sql = "select * from  Product where pid = '" + this.txtPid.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update
                    string query = "update Product set pname = '" + this.txtPname.Text + "', price = " +
                                   this.txtPrice.Text + ", catagory = '" + this.cmbCatagory.Text + "' where pid = '" +
                                   this.txtPid.Text + "';";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Updated Successfully.");
                        this.txtPid.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Data Upgradation Failed.");
                    }
                }
                else
                {
                    //Insert
                    string query = "insert into Product values ('" + this.txtPid.Text + "','" + this.txtPname.Text + "'," +
                               this.txtPrice.Text + ",'" + this.cmbCatagory.Text + "');";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Data Inserted.");
                    }
                    else
                    {
                        MessageBox.Show("Data Insertion Failed.");
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
            this.txtPid.Text = "";
            this.txtPname.Text = "";
            this.txtPrice.Text = "";
            this.cmbCatagory.SelectedIndex = -1;
            this.txtSearch.Text = "";
            this.ProductIdGenerate();
           

       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            this.dgvProduct.DataSource = "";
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtPid.Text = this.dgvProduct.CurrentRow.Cells["pid"].Value.ToString();
            this.txtPname.Text = this.dgvProduct.CurrentRow.Cells["pname"].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells["price"].Value.ToString();
            this.cmbCatagory.Text = this.dgvProduct.CurrentRow.Cells["catagory"].Value.ToString();
            this.txtPid.ReadOnly = true;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvProduct.CurrentRow.Cells["pid"].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["pname"].Value.ToString();

                string sql = "delete from Product where pid = '" + id + "';";
                 int count = this.Da.ExecuteDML(sql);

                 if (count == 1)
                 {
                     MessageBox.Show("Product " + name + " has been deleted.");
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

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

       






      

    }
}
