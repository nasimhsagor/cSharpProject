using LMS_ADMIN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_ADMIN
{
    public partial class AdminHomeForm : Form
    {
        UserData _currentUser = new UserData();
        public AdminHomeForm(UserData u)
        {
            InitializeComponent();

            _currentUser = u;
            UserNameTxxt.Text = u.Name;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 l = new Form1();
            l.ShowDialog();
            this.Close();
        }

        private void RemoveStudentBtn_Click(object sender, EventArgs e)
        {
            RemoveStudentForm r = new RemoveStudentForm();
            r.ShowDialog();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBookForm a = new AddBookForm();
            a.ShowDialog();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            AddStudentForm a = new AddStudentForm();
            a.ShowDialog();
        }

        private void AddLibBtn_Click(object sender, EventArgs e)
        {
            AddLibrarianForm a = new AddLibrarianForm();
            a.ShowDialog();
        }

        private void RemoveLibBtn_Click(object sender, EventArgs e)
        {
            RemoveLibrarianForm l = new RemoveLibrarianForm();
            l.ShowDialog();
        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            RemoveBookForm r = new RemoveBookForm();
            r.ShowDialog();
        }

        private void TotalBookBTn_Click(object sender, EventArgs e)
        {
            AllBookRecForm a = new AllBookRecForm();
            a.ShowDialog();
        }

        private void TotalStudentBtn_Click(object sender, EventArgs e)
        {
            TotalStudentForm t = new TotalStudentForm();
            t.ShowDialog();
        }
    }
}
