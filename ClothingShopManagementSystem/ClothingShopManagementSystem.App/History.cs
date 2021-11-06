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

namespace ClothingShopManagementSystem.App
{
    public partial class History : UserControl
       
    {
        private double totalSale = 0;
        private SalesHistoryRepo Shp { set; get; }
        private LoginHistoryRepo Lhp { get; set; }
        private static History his;
        public static History His
        {
            get
            {
                if (his == null)
                    his = new History();
                return his;
            }
        }
        public History()
        {
            InitializeComponent();
            this.Shp = new SalesHistoryRepo();
            this.dtpSellHistoryDate.Value = DateTime.Today;
            this.Lhp = new LoginHistoryRepo();
            this.dtpDateLoginHistory.Value = DateTime.Today;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }
        private void PopulateGrid(string date=null)
        {
            this.dgvSalesDetails.AutoGenerateColumns = false;
            this.dgvSalesDetails.DataSource = this.Shp.GetAllData(date).ToList();
            this.dgvSalesDetails.ClearSelection();
            this.dgvSalesDetails.Refresh();
            this.PopulateLbl();
            this.GetTotalSale();
        }

        private void History_Load(object sender, EventArgs e)
        {
            this.PopulateGrid();
            this.PopulateLogin(DateTime.Today.ToString("yyyy-MM-dd"));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGrid();
            this.dtpSellHistoryDate.Value = DateTime.Today;
        }

        private void dtpSellHistoryDate_ValueChanged(object sender, EventArgs e)
        {
            this.PopulateGrid(this.dtpSellHistoryDate.Value.ToString("yyyy-MM-dd"));
            this.PopulateLbl(this.dtpSellHistoryDate.Value.ToString("yyyy-MM-dd"));
        }
        private void GetTotalSale()
        {
            int count = 0;
            this.totalSale = 0;
            while (count < this.dgvSalesDetails.Rows.Count)
            {
                this.totalSale += Convert.ToDouble(this.dgvSalesDetails.Rows[count++].Cells["Total"].Value);
            }
            this.lblTotalsell.Text = this.totalSale.ToString();
        }
        private void PopulateLogin(string date =null)
        {
            this.dgvLogin.AutoGenerateColumns = false;
            this.dgvLogin.DataSource = this.Lhp.GetAll(date).ToList();
            this.dgvLogin.ClearSelection();
            this.dgvLogin.Refresh();
        }

        private void btnRefreshLogin_Click(object sender, EventArgs e)
        {
            this.PopulateLogin(DateTime.Today.ToString("yyyy-MM-dd"));
            this.dtpDateLoginHistory.Value = DateTime.Today;
        }

        private void dtpDateLoginHistory_ValueChanged(object sender, EventArgs e)
        {
            this.PopulateLogin(this.dtpDateLoginHistory.Value.ToString("yyyy-MM-dd"));
        }
        private void PopulateLbl(string date = null)
        {
            var s = this.Shp.getTotalSale(date);
            var c = this.Shp.getTotalCost(date);
            this.lblIncome.Text = (s - c).ToString()+" Tk.";
        }
    }
}
