using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LMS1._0
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }
        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }
        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            set { this.sda = value; }
            get { return this.sda; }
        }
        private DataSet ds;
        public DataSet Ds
        {
            set { this.ds = value; }
            get { return this.ds; }
        }
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=SAGOR-PC\SQLEXPRESS2019;Initial Catalog=LMSDB;Persist Security Info=True;User ID=sa;Password=1122");
            this.Sqlcon.Open();
        }
        public DataSet ExecuteQuiry(string quiry)
        {
            try
            {
                this.Sqlcom = new SqlCommand(quiry, this.Sqlcon);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Ds = new DataSet();
                this.Sda.Fill(Ds);
                return this.Ds;
            }
            catch
            {
                return null;
            }
        }
        public int ExecuteDml(string quiry)
        {
            try
            {
                this.Sqlcom = new SqlCommand(quiry, this.Sqlcon);
                int u = this.Sqlcom.ExecuteNonQuery();
                return u;
            }
            catch
            {
                return 0;
            }
        }
    }
}
