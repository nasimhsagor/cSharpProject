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
    public partial class Inventory : UserControl
    {
        private static Inventory inv;
        public static Inventory Inv
        {
            get
            {
                if (inv == null)
                    inv = new Inventory();
                return inv;
            }
        }
        private InventoryRepo Ir { get; set; }
        DelegateList.InventoryPopulateGrid Igv { get; set; }
        public Inventory()
        {
            InitializeComponent();
            if(Adjustment.Role=="salesman")
            {
                this.pnlInventoryCrud.Visible = false;
                this.dgvProductDetails.Columns.Remove(holeSaleUnitPrice);
            }
            this.Ir = new InventoryRepo();
            this.CompanyFill();
            this.CategoryFill();
        }

        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
             this. Igv = this.PopulateGridPro;
            new Crud(Igv).Show();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }
        private void PopulateGridPro (string nameOrcode=null,string category=null,string size=null,string companyName=null)
        {
            this.dgvProductDetails.AutoGenerateColumns = false;
            this.dgvProductDetails.DataSource = this.Ir.GetProduct(nameOrcode,category,size,companyName).ToList();
            this.dgvProductDetails.ClearSelection();
            this.dgvProductDetails.Refresh();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.PopulateGridPro() ;
        }

        private void btninventoryEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvProductDetails.CurrentRow.Selected)
            {
                var dt = this.dgvProductDetails.CurrentRow.Cells;
                var product = new Products();
                product.category = dt["category"].Value.ToString();
                product.Id = Convert.ToInt32(dt["Id"].Value.ToString());
                product.name = dt["name"].Value.ToString();
                product.productCode = dt["productCode"].Value.ToString();
                product.quantity = Convert.ToInt32(dt["quantity"].Value.ToString());
                product.size = dt["size"].Value.ToString();
                product.retailUnitPrice = Convert.ToDouble(dt["retailUnitPrice"].Value.ToString());
                product.holeSaleUnitPrice = Convert.ToDouble(dt["holeSaleUnitPrice"].Value.ToString());
                product.stockDate = dt["stockDate"].Value.ToString();
                product.companyName = dt["companyName"].Value.ToString();
                product.discountAmount = Convert.ToDouble(dt["discountAmount"].Value.ToString());
                this.Igv = this.PopulateGridPro;
                new Crud(product, Igv).Show();
            }
            else
                MessageBox.Show("No data selected for update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvProductDetails.CurrentRow.Selected)
            {
                bool dis = this.Ir.DeleteData(this.dgvProductDetails.CurrentRow.Cells["productCode"].Value.ToString());
                if (dis)
                {
                    this.PopulateGridPro();
                    MessageBox.Show("Deletion successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                    MessageBox.Show("Deletion not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No data selected for delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        private void CompanyFill()
        {
            List<string> company = new List<string>();
                company = Ir.FillCmbCompany();
                int x = 0;
                while (x < company.Count)
                {
                    this.cmbInventoryCompany.Items.Add(company[x]);
                    x++;
                }
        }
        private void CategoryFill()
        {
            List<string> Category = new List<string>();
                Category = Ir.FillCmbCategory();
                int x = 0;
                while (x < Category.Count)
                {
                    this.cmbInventoryCatagory.Items.Add(Category[x]);
                    x++;
                }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtInventorySearch.Clear();
            this.cmbInventoryCatagory.SelectedIndex = -1;
            this.cmbInventoryCompany.SelectedIndex = -1;
            this.dtpStockDate.Text=DateTime.Today.ToString();
            this.PopulateGridPro();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.PopulateGridPro(this.txtInventorySearch.Text, this.cmbInventoryCatagory.Text,
                this.dtpStockDate.Value.ToString(), this.cmbInventoryCatagory.Text);
        }
    }
}
