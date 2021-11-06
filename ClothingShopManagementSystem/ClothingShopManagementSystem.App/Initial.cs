using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingShopManagementSystem.App
{
    public partial class Initial : UserControl
    {
        private static Initial start;
        public static Initial Start
        {
            get
            {
                if(start==null)
                    start = new Initial();
                return start;
            }
        }
        public Initial()
        {
            InitializeComponent();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (Adjustment.IsProductInCart)
                MessageBox.Show("Please remove products from cart to exit", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Application.Exit();
        }
    }
}
