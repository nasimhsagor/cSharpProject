using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingShopManagementSystem.Repository;
using ClothingShopManagementSystem.Entity;

namespace ClothingShopManagementSystem.App
{
    public partial class Company : UserControl
    {
        private static Company com;
        public static Company Com
        {
            get
            {
                if (com == null)
                    com = new Company();
                return com;
            }
        }
        private CompanyRepo Cp { get; set; }
        public Company()
        {
            InitializeComponent();
            this.Cp = new CompanyRepo();
        }

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            DelegateList.PopulateGrid company = this.PoulateGrid;
            new NewCompany(company).Show();
        }

        private void btnCompanyEdit_Click(object sender, EventArgs e)
        {
            if (!this.dgvEmployeeDetails.CurrentRow.Selected)
                MessageBox.Show("No data selected to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DelegateList.PopulateGrid a = this.PoulateGrid;
                var company = new Companies();
                var dt = this.dgvEmployeeDetails.CurrentRow.Cells;
                company.address = dt["address"].Value.ToString();
                company.name = dt["name"].Value.ToString();
                company.liabilities = Convert.ToDouble(dt["liabilities"].Value.ToString());
                company.paidAmount = Convert.ToDouble(dt["paidAmount"].Value.ToString());
                new NewCompany(a, company).Show();
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            DelegateList.PopulateGrid a = this.PoulateGrid;
            new CompanyPayment(a).Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            this.PoulateGrid();
        }
        private void PoulateGrid(string name=null)
        {
            this.dgvEmployeeDetails.AutoGenerateColumns = false;
            this.dgvEmployeeDetails.DataSource = this.Cp.GetAll(name);
            this.dgvEmployeeDetails.ClearSelection();
            this.dgvEmployeeDetails.Refresh();
        }

        private void txtCompanySearch_TextChanged(object sender, EventArgs e)
        {
            this.PoulateGrid(this.txtCompanySearch.Text);
        }

        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            if (!this.dgvEmployeeDetails.CurrentRow.Selected)
                MessageBox.Show("No data selected to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool dis = this.Cp.DeleteData(this.dgvEmployeeDetails.CurrentRow.Cells["name"].Value.ToString());
                if (dis)
                {
                    MessageBox.Show("Successfully deleted", "Successful", MessageBoxButtons.OK);
                    this.PoulateGrid();
                }
                else
                    MessageBox.Show("Can not delete value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
