using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class OwnerDashboard : Form
    
    {
        OrderHistory ou = new OrderHistory();
        public OwnerDashboard()
        {
            InitializeComponent();
            this.panel1.Controls.Add(ou);
            ou.Visible = false;

            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee fe = new Employee();
            fe.Visible = true;
            this.Visible = false;
        }

        private void oderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ou.Visible = true;
            btnLogout.Visible = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("For Adding  click on Add  \n For Showing Order and Transaction History click on History\n To Show initial Dashboard ,click on home ");
            

        }

        private void OwnerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
                Welcome wf = new Welcome();
                wf.Visible = true;
            }
        }

        private void developmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Using C#\n Group Alpha");
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerDashboard fm = new ManagerDashboard();
            fm.Visible = true;
            this.Visible = false;
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanDashboard sf = new SalesmanDashboard();
            sf.Visible = true;
            this.Visible = false;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ou.Visible = false;
            btnLogout.Visible = true;

        }
    }
}
