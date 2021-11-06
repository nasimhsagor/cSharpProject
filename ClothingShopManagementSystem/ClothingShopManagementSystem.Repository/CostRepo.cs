using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingShopManagementSystem.Entity;
using ClothingShopManagementSystem.Data;
using System.Data;

namespace ClothingShopManagementSystem.Repository
{
    public class CostRepo
    {
        private DataAccess Da { get; set; }
        public CostRepo()
        {
            this.Da = new DataAccess();
        }
        public List<Costs> GetAllCost(string date, string type)
        {
            List<Costs> c = new List<Costs>();
            try
            {
                var sql = "select * from costs where date='" + DateTime.Today.ToString("yyyy-MM-dd") + "';";
                if (date != null || type != null)
                    sql = "select * from costs where date='" + date + "'or type ='" + type + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    var cost = new Costs();
                    cost = this.Convert(dt.Tables[0].Rows[count]);
                    c.Add(cost);
                    count++;
                }
                return c;
            }
            catch { return null; }
        }
        public Costs Convert(DataRow dr)
        {
            if (dr == null)
                return null;
            var p = new Costs();
            p.costdetails = dr["costdetails"].ToString();
            var dt = (DateTime)dr["date"];
            p.date = dt.ToString("yyyy-MM-dd");
            p.Id = Int32.Parse(dr["Id"].ToString());
            p.type = dr["type"].ToString();
            p.amount = Double.Parse(dr["amount"].ToString());
            return p;
        }
        public List<string> GetAllType()
        {
            List<string> a = new List<string>();
            try
            {
                var sql = "select distinct type from costs;";
                var dt = this.Da.ExecuteQuiry(sql);
                int cout = 0;
                string b;
                while (cout < dt.Tables[0].Rows.Count)
                {
                    b = dt.Tables[0].Rows[cout++]["type"].ToString();
                    a.Add(b);
                }
                return a;
            }
            catch { return null; }
        }
        public bool UpdateCost(Costs c, string Id)
        {
            try
            {
                var sql = "update costs set costdetails='" + c.costdetails + "',amount='" + c.amount + "',type='" + c.type
                    + "' where Id=" + Id + ";";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public bool AddCost(Costs c)
        {
            try
            {
                var sql = "insert into costs values('" + c.costdetails + "','" + c.date + "','" + c.amount + "','" + c.type + "');";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public bool DeleteCost(int c)
        {
            try
            {
                var sql = "delete from costs where id =" + c + ";";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public string GetDbLastDateOfCost()
        {
            try
            {
                var sql = "select date from costs order by date desc";
                var dt = this.Da.ExecuteQuiry(sql);
                if (dt != null)
                {
                    var date = (DateTime)dt.Tables[0].Rows[0]["date"];
                    return date.ToString("yyyy-MM-dd");
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
