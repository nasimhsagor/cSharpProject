using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class OrderHistory : UserControl
    {
        public DataAccess Da { get; set; }
        internal string Sql { get; set; }
        public OrderHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql = "select * from OrderHistory;")
        {
            try
            {
                DataSet ds = this.Da.ExecuteQuery(sql);

                this.dgvOrder.AutoGenerateColumns = false;
                this.dgvOrder.DataSource = ds.Tables[0];

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.Sql = @"select * from OrderHistory where  Date like '" + this.txtSearch.Text + "%' or  Id like '" + this.txtSearch.Text + "%'or  Item like '" + this.txtSearch.Text + "%' ;";
            this.PopulateGridView(this.Sql);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblTotal.Text = "0";
            int i=0;
            while (i < dgvOrder.Rows.Count)
            { 
                this.lblTotal.Text= Convert.ToString(double.Parse(this.lblTotal.Text)+double.Parse(dgvOrder.Rows[i].Cells[2].Value.ToString()));
                i++;
            
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            this.lblDiscount.Text = "0";
            int i = 0;
            while (i < dgvOrder.Rows.Count)
            {
                this.lblDiscount.Text = Convert.ToString(double.Parse(this.lblDiscount.Text) + double.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString()));
                i++;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.lblDiscount.Text = "0";
            this.dgvOrder.DataSource = "";
            this.txtSearch.Text = "";
            this.lblTotal.Text = "0";
        }

     

       
    }
}
