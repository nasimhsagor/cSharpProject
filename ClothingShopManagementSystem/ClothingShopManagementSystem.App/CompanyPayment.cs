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
using ClothingShopManagementSystem.Repository;
using ClothingShopManagementSystem.Entity;
using ClothingShopManagementSystem.Framework;

namespace ClothingShopManagementSystem.App
{
    public partial class CompanyPayment : MetroForm
    {
        private DelegateList.PopulateGrid D { get; set; }
        private CompanyRepo Cp { get; set; }
        public CompanyPayment()
        {
            InitializeComponent();
            this.Cp = new CompanyRepo();
        }
        public CompanyPayment(DelegateList.PopulateGrid a):this()
        {
            this.D = a;
        }
        private void CompanyFill()
        {
            List<string> company = new List<string>();
            company = this.Cp.FillCmbCompany();
            int x = 0;
            while (x < company.Count)
            {
                this.cmbCompanyName.Items.Add(company[x]);
                x++;
            }
        }

        private void CompanyPayment_Load(object sender, EventArgs e)
        {
            this.CompanyFill();
        }

        private void cmbCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = new List<Companies>();
            a = this.Cp.GetAll(this.cmbCompanyName.Text);
            this.txtLiabilities.Text = a[0].liabilities.ToString();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            
            if(Validation.IsDoubleValid(this.txtPaidAmount.Text))
            {
                double liabilities = Convert.ToDouble(this.txtLiabilities.Text);
                double paid = Convert.ToDouble(this.txtPaidAmount.Text);
                if(paid>liabilities)
                {
                    MessageBox.Show("Payment cant be greater than liabilities", "Errorr",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(paid<0)
                {
                    MessageBox.Show("Minimum value 0 for payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var a = this.Cp.GetAll(this.cmbCompanyName.Text);
                    var c = new Companies();
                    c.name = a[0].name;
                    c.liabilities = a[0].liabilities - Convert.ToDouble(this.txtPaidAmount.Text);
                    c.paidAmount = a[0].paidAmount + Convert.ToDouble(this.txtPaidAmount.Text);
                    c.address = a[0].address;
                    this.Cp.UpdateData(c, a[0].name);
                    MessageBox.Show("Saved");
                    this.Cp.AddToCost(Convert.ToDouble(this.txtPaidAmount.Text), c.name);
                    this.D();
                }
            }    
        }
    }
}
