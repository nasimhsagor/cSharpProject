using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ClothingShopManagementSystem.Entity;
using ClothingShopManagementSystem.Framework;
using ClothingShopManagementSystem.Repository;

namespace ClothingShopManagementSystem.App
{
   
    public partial class Crud : MetroForm
    {
        private DelegateList.InventoryPopulateGrid Populate { set; get; }
        private InventoryRepo Ir { get; set; }
        private Products Product { get; set; }
        public Crud()
        {
            InitializeComponent();
            this.Ir = new InventoryRepo();
        }
        public Crud(DelegateList.InventoryPopulateGrid a):this()
        {
            this.Populate = a;
        }
        public Crud(Products p,DelegateList.InventoryPopulateGrid a):this()
        {
            this.Product = new Products();
            this.Populate = a;
            this.btnProductAdd.Visible = false;
            this.btnUpdate.Visible = true;
            this.txtProductCode.ReadOnly = true;
            this.btnUpdate.Location = new Point(104, 868);
            if(p!=null)
            {
                this.Product = p;
                this.FillForm();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void cbNewCompany_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbNewCompany.Checked)
            {
                DelegateList.CompanyFill C = this.CompanyFill;
                NewCompany n = new NewCompany(C);
                n.Show();
            }
        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
             if(!Validation.IsStringValid(this.txtProductName.Text)||!Validation.IsStringValid(this.cmbProductCategory.Text)||
               !Validation.IsStringValid(this.cmbCompany.Text)||!Validation.IsStringValid(this.txtProductCode.Text)||
               !Validation.IsStringValid(this.txtProductSize.Text)||!Validation.IsIntValid(this.udProductQuantity.Value.ToString())||
               !Validation.IsDoubleValid(this.txtProductCost.Text)||! Validation.IsDoubleValid(this.txtProductUnitPrice.Text)||
               !Validation.IsDoubleValid(this.txtDiscount.Text))
             {
                    MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
            else
            {
                bool check = this.Ir.AddProduct(this.ConvertProduct());
                if (check)
                {
                    MessageBox.Show("Successfully saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Populate();
                    this.Close();
                } 
                else
                    MessageBox.Show("Can not save data", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        

        private void Crud_Load(object sender, EventArgs e)
        {

            this.CategoryFill();
            this.CompanyFill();
           
        }
        private void CategoryFill()
        {
            List<string> Category = new List<string>();
                Category = Ir.FillCmbCategory();
                int x = 0;
                while (x < Category.Count)
                {
                    this.cmbProductCategory.Items.Add(Category[x]);
                    x++;
                }
        }
        private void CompanyFill()

        {
            this.cmbCompany.Items.Clear();
            List<string> Company = new List<string>();
                Company = Ir.FillCmbCompany();
                int x = 0;
                while (x < Company.Count)
                {
                    this.cmbCompany.Items.Add(Company[x]);
                    x++;
                }
        }
        private void FillForm()
        {
            this.cmbProductCategory.Text= this.Product.category;
            this.txtProductName.Text= this.Product.name;
            this.txtProductCode.Text=this.Product.productCode;
            this.udProductQuantity.Value= this.Product.quantity;
            this.txtProductSize.Text=this.Product.size;
            this.txtProductUnitPrice.Text=this.Product.retailUnitPrice.ToString();
            this.txtProductCost.Text=this.Product.holeSaleUnitPrice.ToString();
            this.dtpStockDate.Text= this.Product.stockDate;
            this.cmbCompany.DropDownStyle = ComboBoxStyle.DropDown;
            this.cmbCompany.Text = this.Product.companyName;
            this.cmbCompany.Enabled = false;
            this.txtDiscount.Text=this.Product.discountAmount.ToString();
        }
        private Products ConvertProduct()
        {
                var Product = new Products();
                Product.category = this.cmbProductCategory.Text;
                Product.name = this.txtProductName.Text;
                Product.productCode = this.txtProductCode.Text;
                Product.quantity = Convert.ToInt32(this.udProductQuantity.Value.ToString());
                Product.size = this.txtProductSize.Text;
                Product.retailUnitPrice = Double.Parse(this.txtProductUnitPrice.Text);
                Product.holeSaleUnitPrice= Double.Parse(this.txtProductCost.Text);
                Product.stockDate = this.dtpStockDate.Value.ToString();
                Product.companyName = this.cmbCompany.Text;
            Product.discountAmount = Double.Parse(this.txtDiscount.Text);
                return Product;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (!Validation.IsStringValid(this.txtProductName.Text) || !Validation.IsStringValid(this.cmbProductCategory.Text) ||
              !Validation.IsStringValid(this.cmbCompany.Text) || !Validation.IsStringValid(this.txtProductCode.Text) ||
              !Validation.IsStringValid(this.txtProductSize.Text) || !Validation.IsIntValid(this.udProductQuantity.Value.ToString()) ||
              !Validation.IsDoubleValid(this.txtProductCost.Text) || !Validation.IsDoubleValid(this.txtProductUnitPrice.Text) ||
              !Validation.IsDoubleValid(this.txtDiscount.Text))
            {
                MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                bool valid = this.Ir.UpdateData(this.ConvertProduct());
                if(valid)
                {
                    MessageBox.Show("Data successfully updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Populate();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data can not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string AutoCode(string category)
        {
           if(category !=null)
            {
                try
                {
                    string r;
                    var s = category.Substring(0, 2);
                    var data = this.Ir.GetCode(category);
                    if (data == null)
                    {
                        r = s + "-1";
                    }
                    else
                    {
                        var value = Convert.ToInt32(data.Substring(3, data.Length - 3));
                        r = s + "-" + Convert.ToString(++value);
                    }
                    return r;
                }
                catch(Exception)
                { return null; }
               
            }
            return null;
        }

        private void cmbProductCategory_Leave(object sender, EventArgs e)
        {
            this.txtProductCode.Text = this.AutoCode(this.cmbProductCategory.Text);
        }
    }
}
