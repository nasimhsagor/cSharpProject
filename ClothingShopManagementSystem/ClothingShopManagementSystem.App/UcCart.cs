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
using ClothingShopManagementSystem.Framework;

namespace ClothingShopManagementSystem.App
{
    public partial class UcCart : UserControl
    {
        private CartRepo Shr { get; set; }
        private double BCounter = 0;
        private static UcCart cart;
        public static UcCart Cart
        {
            get
            {
                if (cart == null)
                    cart = new UcCart();
                return cart;
            }
        }
        public UcCart()
        {
            InitializeComponent();
            this.Shr = new CartRepo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(this.dgvBill.Rows.Count!=0)
            {
                Adjustment.IsProductInCart = true;
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Adjustment.IsProductInCart = false;
                Application.Exit();
            }
           
        }
        private void FillCmbCategory()
        {
            this.cmbCartCatagory.Items.Clear();
            var add = this.Shr.FillCmbCategory();
            int count = 0;
            while (count < add.Count)
            {
                this.cmbCartCatagory.Items.Add(add[count++]);
            }
        }
        private void FillCmbSize(string code)
        {
            this.cmbCartProductSize.Items.Clear();
            var add = this.Shr.FillCmbSize(code);
            int count = 0;
            while (count < add.Count)
            {
                this.cmbCartProductSize.Items.Add(add[count++]);
            }
        }
        private void FillCmbSoldby()
        {
            this.cmbCartSoldBy.Items.Clear();
            var add = this.Shr.FillCmbEmployee();
            int count = 0;
            while (count < add.Count)
            {
                this.cmbCartSoldBy.Items.Add(add[count++]);
            }
        }
        private void FillDgvProductName(string category = null, string nameOrCode = null)
        {
            this.dgvProductlist.AutoGenerateColumns = false;
            this.dgvProductlist.DataSource = this.Shr.FillProductNameList(category, nameOrCode).ToList();
            this.dgvProductlist.ClearSelection();
            this.dgvProductlist.Refresh();
        }

        private void UcCart_Load(object sender, EventArgs e)
        {
            this.FillCmbCategory();
            this.FillCmbSoldby();

        }

        private void cmbCartCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillDgvProductName(this.cmbCartCatagory.Text, null);
        }

        private void txtCartSearch_TextChanged(object sender, EventArgs e)
        {
            this.FillDgvProductName(null, this.txtCartSearch.Text);
        }

        private void dgvProductlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dt = this.dgvProductlist.CurrentRow.Cells;
            this.txtProductName.Text = dt["name"].Value.ToString();
            this.txtCartUnitPrice.Text = dt["retailUnitprice"].Value.ToString();
            this.txtCartDiscount.Text = dt["discountAmount"].Value.ToString();
            this.udCartProductQuantity.Maximum = Convert.ToInt32(dt["quantity"].Value.ToString());
            this.FillCmbSize(dt["productCode"].Value.ToString());
            this.cmbCartProductSize.SelectedIndex = 0;
            this.btnAddToCart.Visible = true;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (this.udCartProductQuantity.Value == 0)
            {
                MessageBox.Show("No products in inventory");
            }
            else
            {
                if (!Validation.IsPhoneNumberValid(this.txtCartCustomerPhoneNumber.Text) ||! Validation.IsDoubleValid(this.txtCartDiscount.Text)||
                    !Validation.IsStringValid(this.cmbCartProductSize.Text)||!Validation.IsStringValid(this.cmbCartSoldBy.Text))
                    MessageBox.Show("Fill information properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var dt = this.dgvProductlist.CurrentRow.Cells;
                    this.dgvBill.Rows.Add(
                    DateTime.Today.ToString("dd-MM-yy"),
                       this.txtCartCustomerPhoneNumber.Text,
                       dt["productCode"].Value.ToString(),
                       dt["name"].Value.ToString(),
                       dt["category"].Value.ToString(),
                       dt["companyName"].Value.ToString(),
                       this.udCartProductQuantity.Value,
                       dt["retailUnitPrice"].Value.ToString(),
                       this.txtCartDiscount.Text,
                       dt["Id"].Value.ToString(),
                       this.Shr.Id(this.cmbCartSoldBy.Text),
                       (Convert.ToDouble(this.udCartProductQuantity.Value.ToString()) * (Convert.ToDouble(dt["retailUnitPrice"].Value.ToString()) -
                       Convert.ToDouble(this.txtCartDiscount.Text))));
                    this.GenarateBill();
                    this.Shr.UpdateInProductsDB(Convert.ToInt32(dt["Id"].Value), (Int32.Parse(dt["quantity"].Value.ToString()) -
                        Int32.Parse(this.udCartProductQuantity.Value.ToString())));
                    this.btnRemove.Visible = true;
                    this.btnSell.Visible = true;
                    this.RefreshAll();
                }
                
            }
        }
       private SalesHistories ConvertData(DataGridViewCellCollection dr)
        {
            var his = new SalesHistories();
            his.date = DateTime.Today.ToString("yyyy-MM-dd");
            his.customerPhoneNumber = dr["Customernumber"].Value.ToString();
            his.productCode = dr["Code"].Value.ToString();
            his.productName = dr["Pname"].Value.ToString();
            his.category = dr["Pcategory"].Value.ToString();
            his.companyName = dr["Company"].Value.ToString();
            his.quantity = Convert.ToInt32(dr["Pquantity"].Value);
            his.unitPrice = Convert.ToDouble(dr["UnitPrice"].Value);
            his.discountAmount = Convert.ToDouble(dr["Discount"].Value);
            his.Product_Id = Convert.ToInt32(dr["productid"].Value);
            his.EmployeeDetails_Id = dr["EmployeeId"].Value.ToString();
            his.Total = Convert.ToDouble(dr["total"].Value);
            return his;
        }
        private void GenarateBill()
        {
            int count =0;
            this.BCounter = 0;
            while (count < this.dgvBill.Rows.Count)
            {
                this.BCounter += Convert.ToDouble(this.dgvBill.Rows[count++].Cells["total"].Value);
            }
            this.lblCartTotalPrice.Text = Convert.ToString(this.BCounter) + " Tk.";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!this.dgvBill.CurrentRow.Selected)
            {
                MessageBox.Show("No data selected for remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var dt = this.dgvBill.CurrentRow.Cells;
                int id = Convert.ToInt32(dt["productid"].Value);
                int quantity = this.Shr.GetCurrentProductQuantity(id) + Convert.ToInt32(dt["Pquantity"].Value.ToString());
                this.Shr.UpdateInProductsDB(id, quantity);
                this.dgvBill.Rows.Remove(this.dgvBill.CurrentRow);
                this.GenarateBill();
            }
            if (this.dgvBill.Rows.Count == 0)
            {
                this.btnRemove.Visible = false;
                this.btnSell.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshAll();
            this.txtCartCustomerPhoneNumber.Clear();
            this.cmbCartSoldBy.SelectedIndex = -1;
        }
        private void RefreshAll()
        {
            this.txtCartDiscount.Clear();
            this.txtCartSearch.Clear();
            this.txtCartUnitPrice.Clear();
            this.txtProductName.Clear();
            this.cmbCartCatagory.SelectedIndex = -1;
            this.cmbCartProductSize.Items.Clear();
            this.dgvBill.Refresh();
            this.dgvBill.ClearSelection();
            this.dgvProductlist.Refresh();
            this.dgvProductlist.ClearSelection();
            this.btnAddToCart.Visible = false;
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnRemove.Visible = true;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            var history = new List<SalesHistories>();
            int count = 0;
            while(count<this.dgvBill.Rows.Count)
            {
                var his = this.ConvertData(this.dgvBill.Rows[count++].Cells);
                history.Add(his);
            }
            bool dis = this.Shr.InsertIntoSalesHisDB(history);
            if (dis)
            {
                MessageBox.Show("Successful");
                this.dgvBill.Rows.Clear();
                this.txtCartCustomerPhoneNumber.Clear();
                this.cmbCartSoldBy.SelectedIndex = -1;
                this.Refresh();
                this.lblCartTotalPrice.Text = "0.00";
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
