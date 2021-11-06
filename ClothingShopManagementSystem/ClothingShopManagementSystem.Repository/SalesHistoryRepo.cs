using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClothingShopManagementSystem.Data;
using ClothingShopManagementSystem.Entity;

namespace ClothingShopManagementSystem.Repository
{
    public class SalesHistoryRepo
    {
        private DataAccess Da { set; get; }
        public SalesHistoryRepo()
        {
            this.Da = new DataAccess();
        }
        public List<SalesHistories> GetAllData(string date)
        {
            var data = new List<SalesHistories>();
            try
            {
                var sql = "select * from SalesHistories where date='" + DateTime.Today.ToString("yyyy-MM-dd") + "';";
                if (date != null)
                    sql = "select * from SalesHistories where date='" + date + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    var his = this.Convert(dt.Tables[0].Rows[count++]);
                    data.Add(his);
                }
                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private SalesHistories Convert(DataRow dr)
        {
            if (dr == null)
                return null;
            var sh = new SalesHistories();
            sh.category = dr["category"].ToString();
            sh.productCode = dr["productCode"].ToString();
            sh.quantity = Int32.Parse(dr["quantity"].ToString());
            sh.Product_Id = Int32.Parse(dr["Product_Id"].ToString());
            sh.Id = Int32.Parse(dr["Id"].ToString());
            sh.Total = Double.Parse(dr["Total"].ToString());
            sh.unitPrice = Double.Parse(dr["unitPrice"].ToString());
            sh.discountAmount = Double.Parse(dr["discountAmount"].ToString());
            var dt = (DateTime)dr["date"];
            sh.date = dt.ToString("dd-MM-yy");
            sh.EmployeeDetails_Id = dr["EmployeeDetail_Id"].ToString();
            sh.customerPhoneNumber = dr["customerPhoneNumber"].ToString();
            sh.companyName = dr["companyName"].ToString();
            sh.productName = dr["productName"].ToString();
            return sh;
        }
        public double getTotalSale(string date)
        {
            try
            {
                var sql = "select Total from saleshistories where date='" + DateTime.Today.ToString("yyyy-MM-dd") + "';";
                if (date != null)
                    sql = "select Total from saleshistories where date='" + date + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                double b = 0.00;
                while (count < dt.Tables[0].Rows.Count)
                {
                    b += Double.Parse(dt.Tables[0].Rows[count++]["Total"].ToString());
                }
                return b;
            }
            catch (Exception)
            {
                return 0.00;
            }
        }
        public double getTotalCost(string date)
        {
            try
            {
                var sql = "select amount from costs where date='" + DateTime.Today.ToString("yyyy-MM-dd") + "';";
                if (date != null)
                    sql = "select amount from costs where date='" + date + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                double b = 0.00;
                while (count < dt.Tables[0].Rows.Count)
                {
                    b += Double.Parse(dt.Tables[0].Rows[count++]["amount"].ToString());
                }
                return b;
            }
            catch (Exception)
            {
                return 0.00;
            }
        }
    }
}