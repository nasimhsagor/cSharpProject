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
using ClothingShopManagementSystem.Framework;
using ClothingShopManagementSystem.Repository;

namespace ClothingShopManagementSystem.App
{
    public partial class NewCompany : Form
    {
        private DelegateList.PopulateGrid Com { get; set; }
        private DelegateList.CompanyFill Fill { get; set; }
        private CompanyRepo Cr { get; set; }
        private string name { get; set; }
        public NewCompany()
        {
            InitializeComponent();
            this.Cr = new CompanyRepo();
        }
        public NewCompany(DelegateList.CompanyFill c):this()
        {
            this.Fill = c;
            this.lblLaiability.Visible = false;
            this.txtLiability.Visible = false;
            this.txtPaid.Visible = false;
            this.lblPaid.Visible = false;
            this.btnSave.Location = new Point(92, 242);
        }
        public NewCompany(DelegateList.PopulateGrid a): this()
        {
            this.Com = a;
        }
        public NewCompany(bool e): this()
        {
            this.lblHide.Visible = false;
            this.txtNewCompanyAddress.Visible = false;
            this.lblLaiability.Location = new Point(150, 139);
            this.txtLiability.Location = new Point(41, 169);
            this.lblPaid.Location = new Point(164, 229);
            this.txtPaid.Location = new Point(41, 259);
            this.btnSave.Location = new Point(97, 330);
        }
        public NewCompany(DelegateList.PopulateGrid a, Companies c):this()
        {
            this.Com = a;
            this.txtNewCompanyName.Text = c.name;
            this.name = c.name;
            this.txtNewCompanyAddress.Text = c.address;
            this.txtLiability.Text = c.liabilities.ToString();
            this.txtPaid.Text = c.paidAmount.ToString();
            this.btnSave.Visible = false;
            this.btnUpdate.Visible = true;
            this.btnUpdate.Location = new Point(97, 414);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!Validation.IsStringValid(this.txtNewCompanyName.Text)||!Validation.IsStringValid(this.txtNewCompanyAddress.Text)||
                !Validation.IsDoubleValid(this.txtLiability.Text)||!Validation.IsDoubleValid(this.txtPaid.Text))
            {
                MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToDouble(this.txtPaid.Text) > Convert.ToDouble(this.txtLiability.Text))
                    MessageBox.Show("Value can not be greater than Liabilities", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.txtLiability.Text = Convert.ToString(Convert.ToDouble(this.txtLiability.Text) - Convert.ToDouble(this.txtPaid.Text));
                    bool confirm = this.Cr.AddCompany(this.GetEntity());
                    if (confirm)
                    {
                        MessageBox.Show("Company added", "Successful", MessageBoxButtons.OK);
                        if(this.Com!=null)
                            this.Com();
                        this.Close();
                        if (this.Fill != null)
                            this.Fill();
                    }
                    else
                        MessageBox.Show("Can not add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private Companies GetEntity()
        {
            var a = new Companies();
            a.name = this.txtNewCompanyName.Text;
            a.address = this.txtNewCompanyAddress.Text;
            a.liabilities = Convert.ToDouble(this.txtLiability.Text);
            if (this.txtLiability.Text == "")
                a.liabilities = 0.00;
            a.paidAmount = Convert.ToDouble(this.txtPaid.Text);
            if (this.txtPaid.Text == "")
                a.paidAmount = 0.00;
            return a;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation.IsStringValid(this.txtNewCompanyName.Text) || !Validation.IsStringValid(this.txtNewCompanyAddress.Text) ||
               !Validation.IsDoubleValid(this.txtLiability.Text) || !Validation.IsDoubleValid(this.txtPaid.Text))
            {
                MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool dis = this.Cr.UpdateData(GetEntity(), this.name);
                if(!dis)
                    MessageBox.Show("Can not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Company added", "Successful", MessageBoxButtons.OK);
                    this.Com();
                    this.Close();
                }
            }
        }
        }
    }

