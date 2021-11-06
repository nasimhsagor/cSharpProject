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
    public partial class Financial : UserControl

    {
        private static Financial fin;
        public static Financial Fin
        {
            get
            {
                if (fin == null)
                    fin = new Financial();
                return fin;
            }
        }
        private CostRepo Cp { get; set; }
        private string costId{ get; set; }
        public Financial()
        {
            InitializeComponent();
            this.Cp = new CostRepo();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }

        private void Financial_Load(object sender, EventArgs e)
        {
            this.PopulateExpance();
        }
        private void FillType(ComboBox a)
        {
            a.Items.Clear();
            var add = this.Cp.GetAllType();
            int x = 0;
            while (x < add.Count)
            {
                a.Items.Add(add[x++]);
            }
        }
        private void PopulateExpance(string date =null, string type= null)
        {
            this.dgvExpence.AutoGenerateColumns = false;
            this.dgvExpence.DataSource = this.Cp.GetAllCost(date,type).ToList();
            this.dgvExpence.ClearSelection();
            this.FillType(this.cmbExpenceType);
            this.FillType(this.cmbSearchExpancetype);
            this.SetTotalCost();
        }

        private void RefreshCost()
        {
            this.PopulateExpance();
            this.txtAddexpence.Clear();
            this.txtExpenceAmmount.Clear();
            this.cmbSearchExpancetype.Text = "";
            this.cmbExpenceType.Text = "";
            this.dtpSearchExpence.Refresh();
        }  
        private Costs FillEntity()
        {
            var cst = new Costs();
            cst.date = DateTime.Today.ToString("yyyy-MM-dd");
            cst.type = this.cmbExpenceType.Text;
            cst.costdetails = this.txtAddexpence.Text;
            cst.amount = Double.Parse(this.txtExpenceAmmount.Text);
            return cst;
        }

        private void SetTotalCost()
        {
            this.lblExpenceCount.Text = this.CostCount();
        }
        private string CostCount()
        {
            double count=0;
            int index = 0;
            while(index<this.dgvExpence.RowCount)
            {
                count += Convert.ToDouble(this.dgvExpence.Rows[index++].Cells["amount"].Value);
            }
            return count.ToString();
        }

        private void btnSearchExpence_Click_1(object sender, EventArgs e)
        {
            this.PopulateExpance(this.dtpSearchExpence.Value.ToString(), this.cmbSearchExpancetype.Text);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.RefreshCost();
        }

        private void btnDeleteExpence_Click_1(object sender, EventArgs e)
        {
            if (!this.dgvExpence.CurrentRow.Selected)
                MessageBox.Show("No data Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool dis = this.Cp.DeleteCost(Convert.ToInt32(this.dgvExpence.CurrentRow.Cells["Id"].Value));
                if (dis)
                {
                    MessageBox.Show("Successfully deleted", "Successful", MessageBoxButtons.OK);
                    this.RefreshCost();
                }
                else
                    MessageBox.Show("Unable to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditExpence_Click_1(object sender, EventArgs e)
        {
            if (!this.dgvExpence.CurrentRow.Selected)
                MessageBox.Show("No data Selected", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var x = this.dgvExpence.CurrentRow.Cells;
                this.txtAddexpence.Text = x["costdetails"].Value.ToString();
                this.txtExpenceAmmount.Text = x["amount"].Value.ToString();
                this.cmbExpenceType.Text = x["type"].Value.ToString();
                this.btnAddExpence.Visible = false;
                this.btnUpadate.Visible = true;
                this.btnUpadate.Location = new Point(104, 397);
                this.costId = x["Id"].Value.ToString();
            }
        }

        private void btnAddExpence_Click_1(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtAddexpence.Text) && Validation.IsDoubleValid(this.txtExpenceAmmount.Text)
              && Validation.IsStringValid(this.cmbExpenceType.Text))
            {
                bool dis = this.Cp.AddCost(this.FillEntity());
                if (dis)
                {
                    MessageBox.Show("Successfully added", "Successful", MessageBoxButtons.OK);
                    this.RefreshCost();
                }
                else
                {
                    MessageBox.Show("Unable to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Fill information properly", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpadate_Click_1(object sender, EventArgs e)
        {
            if (Validation.IsStringValid(this.txtAddexpence.Text) && Validation.IsDoubleValid(this.txtExpenceAmmount.Text)
               && Validation.IsStringValid(this.cmbExpenceType.Text))
            {
                bool dis = this.Cp.UpdateCost(FillEntity(), this.costId);
                if (dis)
                {
                    MessageBox.Show("Successfully updated", "Successful", MessageBoxButtons.OK);
                    this.btnUpadate.Visible = false;
                    this.btnAddExpence.Visible = true;
                    this.RefreshCost();
                }
                else
                {
                    MessageBox.Show("Unable to save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.btnUpadate.Visible = false;
                    this.btnAddExpence.Visible = true;
                }
            }
            else
                MessageBox.Show("Fill information properly", "Wrong input", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
