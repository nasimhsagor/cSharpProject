using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ClothingShopManagementSystem.App
{
    public partial class DashBord : Form
    {
        private IconButton Flag { get; set; }
        public DashBord()
        {
            InitializeComponent();
            this.AddToPanel();
            if(Adjustment.Role=="salesman")
            {
                this.btnCompany.Visible = false;
                this.btnHistory.Visible = false;
                this.btnEmployee.Visible = false;
                this.btnFinansial.Visible = false;
            }
        }
        private void BtnClickedClolor(object sender)
        {
            this.BtnLeaveColor();
            this.Flag = (IconButton)sender;
            this.Flag.BackColor = Color.FromArgb(240, 240, 240);
            this.Flag.ForeColor = Color.FromArgb(64, 118, 204);
            this.Flag.IconColor = Color.FromArgb(64, 118, 204);
        }
        private void BtnLeaveColor()
        {
            if (this.Flag != null)
            {
                this.Flag.BackColor = Color.FromArgb(64, 118, 204);
                this.Flag.ForeColor = Color.FromArgb(240, 240, 240);
                this.Flag.IconColor = Color.FromArgb(240, 240, 240);
            }

        }
        private void AddToPanel()
        {
            this.pnlContainer.Controls.Clear();
            this.pnlContainer.Controls.Add(Initial.Start);
            Initial.Start.Dock = DockStyle.Fill;
        }
        private void ClearPanelAndAdd(UserControl ob)
        {
            this.pnlContainer.Controls.Clear();
            this.ipbBack.IconChar = IconChar.ChevronCircleLeft;
            this.pnlContainer.Controls.Add(ob);
            ob.Dock = DockStyle.Fill;

        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(Inventory.Inv);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(UcCart.Cart);
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(Company.Com);
        }

        private void btnFinansial_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(Financial.Fin);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            new LoginDialog().Show();
            this.Close();
           
        }

        private void ipbBack_Click(object sender, EventArgs e)
        {
            this.ipbBack.IconChar = IconChar.StoreAlt;
            this.AddToPanel();
            this.BtnLeaveColor();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(Return.Rtn);
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(Employee.NewEmployee);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
            this.ClearPanelAndAdd(History.His);
        }
    }
}
