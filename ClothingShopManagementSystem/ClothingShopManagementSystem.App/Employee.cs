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
    public partial class Employee : UserControl
    {
        private static Employee newEmployee;
        public static Employee NewEmployee
        {
            get
            {
                if (newEmployee == null)
                    newEmployee = new Employee();
                return newEmployee;
            }
        }
        private EmployeeRepo Ep { get; set; }
        private EmployeeDetails Ed { get; set; }
        public Employee()
        {
            InitializeComponent();
            this.Ep = new EmployeeRepo();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            DelegateList.PopulateGrid populate = this.PopulateGridView;
            new EmployeeAdd(populate).Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }
        private void PopulateGridView(string nameOrId=null)
        {
            this.dgvEmployeeDetails.AutoGenerateColumns = false;
            this.dgvEmployeeDetails.DataSource = this.Ep.GetAllData(nameOrId).ToList();
            this.dgvEmployeeDetails.ClearSelection();
            this.dgvEmployeeDetails.Refresh();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            this.PopulateGridView(this.txtEmployeeSearch.Text);
        }

        private void btnInventoryDelete_Click(object sender, EventArgs e)
        {
            bool dis =this.Ep.DeleteData(this.dgvEmployeeDetails.CurrentRow.Cells["Id"].Value.ToString());
            if (!dis)
                MessageBox.Show("Deletion not complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.PopulateGridView();
                MessageBox.Show("Deletion successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {
            var dt = this.dgvEmployeeDetails.CurrentRow.Cells;
            this.Ed = new EmployeeDetails();
            this.Ed.name = dt["name"].Value.ToString();
            this.Ed.joinDate = dt["joinDate"].Value.ToString();
            this.Ed.salary =Double.Parse( dt["salary"].Value.ToString());
            this.Ed.phonenumber = dt["phonenumber"].Value.ToString();
            this.Ed.Id = dt["Id"].Value.ToString();
            DelegateList.PopulateGrid populate = this.PopulateGridView;
            new EmployeeAdd(this.Ed,populate).Show();
        }
    }
}
