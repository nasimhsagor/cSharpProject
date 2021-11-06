using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class SalesmanDashboard : Form
    {
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }

        internal string Sql { get; set; }

        internal double totalBill = 0;

        public SalesmanDashboard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
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
            Application.Exit();
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
            try
            {
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you. Have a nice Day.");
            this.dgvCart.Rows.Clear();
            this.txtTotalBill.Clear();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

            try
            {
                this.Sql = @"select * from Product where catagory ='" + this.cmbCategories.SelectedItem.ToString() + "' and pname like '" + this.txtSearchItem.Text + "%';";
                this.PopulateGridView(this.Sql);
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

        }

        

       
    }
}
