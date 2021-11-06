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
    public partial class Welcome : Form
    {
        private int count = 1;
        public Welcome()
        {
            InitializeComponent();
            
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            string path = "C:\\Users\\nasim\\Desktop\\Image\\" + count + ".jpg";
            this.pbox.Image = Image.FromFile(path);
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if(this.progressBar1.Value>=100)
            {
                //this.timer1.Stop();
                this.progressBar1.Value = 0;
                count++;
                if (count == 3)
                    count = 1;
                string path = "C:\\Users\\nasim\\Desktop\\Image\\" + count + ".jpg";
                this.pbox.Image = Image.FromFile(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login lf = new Login();
            lf.Visible=true;
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close Application?", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}