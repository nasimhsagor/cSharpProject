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

        }

       
    }
}
