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
    public partial class EmployeeAdd : MetroForm
    {
        private EmployeeRepo EmpRepo { get; set; }
        private EmployeeDetails EmpDetails { get; set; }
        private DelegateList.PopulateGrid Populate { set; get; }
        public EmployeeAdd()
        {
            InitializeComponent();
            this.EmpRepo = new EmployeeRepo();
            this.EmpDetails = new EmployeeDetails();
            this.btnUpdate.Visible = false;
        }
        public EmployeeAdd(EmployeeDetails ed,DelegateList.PopulateGrid ob):this()
        {
            this.EmpDetails = ed;
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeePass.Visible = false;
            this.lblPass.Visible = false;
            this.cbAutoGenerate.Visible = false;
            this.cbShowPassword.Visible = false;
            this.lblDate.Location = new Point(165, 373);
            this.dtpEmployeeJoinDate.Location = new Point(80, 403);
            this.btnReceive.Visible = false;
            this.btnUpdate.Visible = true;
            this.btnUpdate.Location = new Point(123,468);
            this.Populate = ob;
            this.PopulateTxt();
        }
        public EmployeeAdd(DelegateList.PopulateGrid a) : this()
          {
            this.Populate = a;
          }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbShowPassword.Checked)
            {
                this.txtEmployeePass.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtEmployeePass.UseSystemPasswordChar = true;
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (this.InsideValidation())
            {
                MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool confirm = this.EmpRepo.AddEmployee(this.Fill());
                if (confirm)
                {
                    MessageBox.Show("Insertn successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Populate();
                }
                else
                    MessageBox.Show("Could not insert", "Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       private bool InsideValidation()
        {
            if (!Validation.IsStringValid(this.txtEmployeeName.Text) || !Validation.IsStringValid(this.txtEmployeeId.Text) ||
                !Validation.IsStringValid(this.txtEmployeePass.Text) || !Validation.IsPhoneNumberValid(this.txtPhoneNumber.Text) || !Validation.IsDoubleValid(this.txtEmployeeSal.Text))
                return true; 
            else
                return false;
        }
        private void PopulateTxt()
        {
            this.txtEmployeeId.Text = this.EmpDetails.Id;
            this.txtEmployeeName.Text = this.EmpDetails.name;
            this.txtEmployeeSal.Text = this.EmpDetails.salary.ToString();
            this.txtPhoneNumber.Text = this.EmpDetails.phonenumber;
            this.dtpEmployeeJoinDate.Text = this.EmpDetails.joinDate;
        }
        private EmployeeDetails Fill()
        {
            this.EmpDetails = new EmployeeDetails();
            this.EmpDetails.Id = this.txtEmployeeId.Text;
            this.EmpDetails.joinDate = this.dtpEmployeeJoinDate.Value.ToString();
            this.EmpDetails.phonenumber = this.txtPhoneNumber.Text;
            this.EmpDetails.salary = Convert.ToDouble(this.txtEmployeeSal.Text);
            this.EmpDetails.password = this.txtEmployeePass.Text;
            this.EmpDetails.name = this.txtEmployeeName.Text;
            return EmpDetails;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Validation.IsStringValid(this.txtEmployeeName.Text) || !Validation.IsStringValid(this.txtEmployeeId.Text)
               || !Validation.IsPhoneNumberValid(this.txtPhoneNumber.Text) || !Validation.IsDoubleValid(this.txtEmployeeSal.Text))
            {
                MessageBox.Show("Please fill all options properly", "Wrong value input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool des = this.EmpRepo.Upate(this.Fill());
                if (!des)
                    MessageBox.Show("Could not update", "Faild!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Update successful", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Populate();
                }
            }
        }
    }
}
