using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingShopManagementSystem.Entity;
using ClothingShopManagementSystem.Repository;

namespace ClothingShopManagementSystem.App
{
    public partial class Return : UserControl
    {
      private static Return rtn;
      public static Return Rtn
        {
            get
            {
                if (rtn == null)
                    rtn = new Return();
                return rtn;
            }
        }
      private ReturnRepo Rp { get; set; }
      public Return()
      {
           InitializeComponent();
            this.Rp = new ReturnRepo();
      }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            Application.Exit();
        }
        private void PopulateGrid(string text=null,string date=null)
        {
            this.dgvReturnDetails.AutoGenerateColumns = false;
            this.dgvReturnDetails.DataSource = this.Rp.GetAllData(text,date).ToList();
            this.dgvReturnDetails.ClearSelection();
            this.dgvReturnDetails.Refresh();
            this.udReceiveQuantity.Visible = false;
            this.lblQuantity.Visible = false;
        }

        private void Return_Load(object sender, EventArgs e)
        {
            this.PopulateGrid();
        }

        private void txtReceiveSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGrid(this.txtReceiveSearch.Text,null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                this.PopulateGrid(null, this.dtpSaleDate.Value.ToString("yyyy-MM-dd"));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (!this.dgvReturnDetails.CurrentRow.Selected)
                MessageBox.Show("No data Selectet for return", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
               var data= this.Converter(this.dgvReturnDetails.CurrentRow.Cells);
                bool a=this.Rp.updateInProductTable(data,Convert.ToInt32(this.udReceiveQuantity.Value));
                bool b = this.Rp.UpdateInSalesTable(data);
                if (a && b)
                {
                    MessageBox.Show("Data updated");
                }
                else
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.PopulateGrid();
        }
        private ReturnList Converter(DataGridViewCellCollection dr)
        {
            var rl = new ReturnList();
            rl.category = dr["category"].Value.ToString();
            rl.name = dr["name"].Value.ToString();
            rl.Id = Int32.Parse(dr["Id"].Value.ToString());
            rl.productCode = dr["productCode"].Value.ToString();
            rl.quantity = Int32.Parse(dr["quantity"].Value.ToString())-Convert.ToInt32(udReceiveQuantity.Value);
            rl.Product_Id = Int32.Parse(dr["Product_Id"].Value.ToString());
            rl.productName = dr["productName"].Value.ToString();
            rl.unitprice = Double.Parse(dr["unitprice"].Value.ToString());
            rl.discount = Double.Parse(dr["discount"].Value.ToString());
            rl.Total = rl.quantity*(rl.unitprice-rl.discount);
            rl.customerPhoneNumber = dr["customerPhoneNumber"].Value.ToString();
            rl.date = dr["date"].Value.ToString();
            return rl;
        }

        private void dgvReturnDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lblQuantity.Visible = true;
            this.udReceiveQuantity.Visible = true;
            this.udReceiveQuantity.Maximum = Convert.ToInt32(this.dgvReturnDetails.CurrentRow.Cells["quantity"].Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGrid();
            this.txtReceiveSearch.Clear();
        }
    }
}
