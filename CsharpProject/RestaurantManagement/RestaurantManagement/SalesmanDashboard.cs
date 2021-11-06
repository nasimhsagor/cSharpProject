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
    public partial class SalesmanDashboard : Form
    {
        private DataAccess Da { get; set; }

        private DataSet Ds { get; set; }
        private string Query { set; get; }

        private string Sql { get; set; }

        internal double totalBill = 0;

        public SalesmanDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.OrderIdGenerate();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close Application?", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCategories.SelectedItem.ToString() == "Fast Food")
            {
                this.Sql = @"select * from Product where catagory='Fast Food';";
                this.PopulateGridView(this.Sql);
                
            }
            else if (this.cmbCategories.SelectedItem.ToString() == "Soft Drinks")
            {
                this.Sql = @"select * from Product where catagory='Soft Drinks';";
                this.PopulateGridView(this.Sql);
            }
            else if (this.cmbCategories.SelectedItem.ToString() == "Chiness")
            {
                this.Sql = @"select * from Product where catagory='Chiness';";
                this.PopulateGridView(this.Sql);
            }
            else if (this.cmbCategories.SelectedItem.ToString() == "Bangla")
            {
                this.Sql = @"select * from Product where catagory='Bangla';";
                this.PopulateGridView(this.Sql);
            }
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var name = this.dgvProduct.CurrentRow.Cells["pname"].Value.ToString();
                this.txtItemName.Text = name;
                var price = this.dgvProduct.CurrentRow.Cells["price"].Value.ToString();
                this.txtPrice.Text = price;
                this.txtDiscount.Text = "0";

            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Cart?\n You are not able to change or Delete!!", "AddCart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "insert into OrderHistory values ('" + this.txtOrderId.Text + "','" + this.txtItemName.Text + "'," +
                                   this.txtTotal.Text + ",'" + this.txtDiscount.Text + "','" + this.nudQuantity.Text + "','" + DateTime.Now.ToString() + "');";

                    int count1 = this.Da.ExecuteDML(query);

                    if (count1 == 1)
                    {
                        MessageBox.Show("Order Record Inserted Successfullyed.");
                    }
                    else
                    {
                        MessageBox.Show("Record Insertion Failed.");
                    }
                    if (this.txtTotal.Text != null && this.nudQuantity.Value != 0)
                    {
                        int count = dgvCart.Rows.Add();
                        dgvCart.Rows[count].Cells[0].Value = this.txtItemName.Text;
                        dgvCart.Rows[count].Cells[1].Value = this.txtTotal.Text;
                        totalBill = totalBill + Convert.ToDouble(this.txtTotal.Text);
                        this.txtTotalBill.Text = totalBill.ToString();
                        this.txtItemName.Clear();
                        this.txtPrice.Clear();
                        this.txtTotal.Clear();
                        this.nudQuantity.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Please select an item to order.");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Order Complete && Paid\n Thank you. Have a nice Day.");
            this.dgvCart.Rows.Clear();
            this.txtTotalBill.Clear();
            this.txtDiscount.Text = "0";
            this.OrderIdGenerate();

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (this.cmbCategories.Text =="")
                {
                    MessageBox.Show("please select the catagory first");
                    
                }
                else
                {
                    this.Sql = @"select * from Product where catagory ='" + this.cmbCategories.SelectedItem.ToString() + "' and pname like '" + this.txtSearchItem.Text + "%';";
                    this.PopulateGridView(this.Sql);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                int qnt = int.Parse(nudQuantity.Value.ToString());
                int price = int.Parse(this.txtPrice.Text);
                double total = (qnt * price);


                double discountedPrice = total - (total * (Double.Parse(this.txtDiscount.Text) / 100));
                this.txtTotal.Text = discountedPrice.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Welcome wf = new Welcome();
                wf.Visible = true;
            }
        }
        private void OrderIdGenerate()
        {
            this.Query = "select * from OrderHistory order by Id desc";
            this.Ds = this.Da.ExecuteQuery(this.Query);

            string previousId = this.Ds.Tables[0].Rows[0]["Id"].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "O-" + (++serialNo).ToString("000");
            this.txtOrderId.Text = nextId;

        }

        private void SalesmanDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Owner?", "Owner Use", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Please Log in first");
                Login fl = new Login();
                fl.Visible = true;
                this.Visible = false;
            }

        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First select the catagory\nThen click on Specifice Item\nThen click on Quantity\nAfter taking confirmation,Click on Cart\n After Taking Payment click on Order");
        }

        

       
    }
}
