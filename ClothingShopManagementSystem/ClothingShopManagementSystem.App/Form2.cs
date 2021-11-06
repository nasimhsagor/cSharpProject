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
        }
        private void BtnClickedClolor(object sender)
        {
              this.BtnLeaveColor();
              this.Flag = (IconButton)sender;
              this.Flag.BackColor = Color.FromArgb(240, 240, 240);
              this.Flag.ForeColor = Color.FromArgb(61,118,204);
              this.Flag.IconColor = Color.FromArgb(61,118,204);
        }
        private void BtnLeaveColor()
        {
            if(this.Flag!=null)
            {
                this.Flag.BackColor = Color.FromArgb(61,118,204);
                this.Flag.ForeColor = Color.FromArgb(240, 240, 240);
                this.Flag.IconColor = Color.FromArgb(240, 240, 240);
            }    
           
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void btnReceiveItem_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void btnSalesman_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void BtnCompany_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void btnFinansial_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.BtnClickedClolor(sender);
        }
    }
}
