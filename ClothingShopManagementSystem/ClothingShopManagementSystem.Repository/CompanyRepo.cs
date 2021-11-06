using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingShopManagementSystem.Data;
using ClothingShopManagementSystem.Entity;
using System.Data;

namespace ClothingShopManagementSystem.Repository
{
    public class CompanyRepo
    {
        private DataAccess Da { get; set; }
        public CompanyRepo()
        {
            this.Da = new DataAccess();
        }
        public List<Companies> GetAll( string name)
        {
            List<Companies> company = new List<Companies>();
            try
            {
                var sql = "select* from companies;";
                if (name != null)
                    sql = "select* from companies where name like '%" + name + "%';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    var cmp = new Companies();
                    cmp = this.ConvertCompany(dt.Tables[0].Rows[count]);
                    company.Add(cmp);
                    count++;
                }
                return company;
            }
            catch { return null; }
        }
        private Companies ConvertCompany(DataRow dr )
        {
            if (dr != null)
            {
                var cmp = new Companies();
                cmp.address = dr["address"].ToString();
                cmp.name = dr["name"].ToString();
                cmp.liabilities = Convert.ToDouble(dr["liabilities"]);
                cmp.paidAmount = Convert.ToDouble(dr["paidAmount"]);
                return cmp;
            }
            else
                return null;
        }
        public bool AddCompany(Companies a)
        {
            if (a == null)
                return false;
            try
            {
                var sql = "insert into companies values('" + a.name + "','" + a.address + "'," + a.liabilities + "," + a.paidAmount + ");";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public bool DeleteData(string a)
        {
            try
            {
                var sql = "delete from companies where name='" + a + "';";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public bool UpdateData(Companies a, string name)
        {
            try
            {
                var sql = "update companies set name='" + a.name + "', address='" + a.address + 
                    "',liabilities=" + a.liabilities + ",paidAmount=" + a.paidAmount + "where name='"+name+"';";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public List<string> FillCmbCompany()
        {
            List<string> data = new List<string>();
            try
            {
                var sql = "select distinct name from companies;";
                var dt = this.Da.ExecuteQuiry(sql);
                int ax = 0;
                while (ax < dt.Tables[0].Rows.Count)
                {
                    data.Add(dt.Tables[0].Rows[ax]["name"].ToString());
                    ax++;
                }
                return data;
            }
            catch { return null; }
        }
        public void AddToCost(double amount, string company)
        {
            try
            {
                var sql = "insert into costs values('" + company + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "'," + amount + ",' payment');";
                this.Da.ExecuteDml(sql);
            }
            catch { return; }
        }
    }
}
