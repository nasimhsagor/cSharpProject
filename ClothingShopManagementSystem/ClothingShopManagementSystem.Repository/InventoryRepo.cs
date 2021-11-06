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
     public class InventoryRepo
    {
        private DataAccess Da { get; set; }
        public InventoryRepo()
        {
            this.Da = new DataAccess();
        }
        public List<Products> GetProduct(string nameOrCode, string category, string date, string companyName)
        {
            var sql = "select * from Products where name ='" + nameOrCode + "'or productCode = '" + nameOrCode + "' or category='"
                + category + "' or stockDate='" + date + "' or companyName='" + companyName + "';";
           
            List<Products> pro = new List<Products>();
            try
            {
                if (nameOrCode == null && category == null && date == null && companyName == null)
                    sql = "select* From Products;";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while(count<dt.Tables[0].Rows.Count)
                {
                    Products p = this.ConvertData(dt.Tables[0].Rows[count]);
                    pro.Add(p);
                    count++;
                }
                return pro;
        }
            catch {return null ; }
        }
        private Products ConvertData(DataRow dr)
        {
            if (dr == null)
                return null;
            Products pro = new Products();
            pro.Id = Convert.ToInt32(dr["Id"].ToString());
            pro.productCode = dr["productCode"].ToString();
            pro.name = dr["name"].ToString();
            pro.category = dr["category"].ToString();
            var dt = (DateTime)dr["stockDate"];
            pro.stockDate = dt.ToString("dd-MMM-yyyy");
            pro.size = dr["size"].ToString();
            pro.retailUnitPrice = Convert.ToDouble(dr["retailUnitPrice"].ToString());
            pro.holeSaleUnitPrice = Convert.ToDouble(dr["holeSaleUnitPrice"].ToString());
            pro.companyName = dr["companyName"].ToString();
            pro.discountAmount = Convert.ToDouble(dr["discountAmount"].ToString());
            pro.quantity = Convert.ToInt32(dr["quantity"].ToString());
            return pro;
        }
        public bool AddProduct(Products newpro)
        {
            int i = 0;
            try
            {
                var sql="insert into products values('"+newpro.name+"','"+newpro.companyName+"','"+newpro.size+"','"
                    +newpro.category+"',"+newpro.holeSaleUnitPrice+","+newpro.retailUnitPrice+",'"+newpro.productCode+"','"+newpro.stockDate+"',"
                    +newpro.quantity+","+newpro.discountAmount+");";
                 i = this.Da.ExecuteDml(sql);
                if (i == 0)
                    return false;
                return true;
            }
            catch { return false; }
        }
        public List<string> FillCmbCategory()
        {
            List < string > data = new List<string>();
            try
            {
                var sql = "select distinct category from products;";
                var dt = this.Da.ExecuteQuiry(sql);
                int ax = 0;
                while(ax<dt.Tables[0].Rows.Count)
                {
                    data.Add(dt.Tables[0].Rows[ax]["category"].ToString());
                    ax++;
                }
                return data;
            }
            catch { return null; }
        }
        public List<string> FillCmbCompany()
        {
            List<string> data = new List<string>();
            try
            {
                var sql = "select name from companies;";
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
        public bool UpdateData(Products p)
        {
            try
            {
                var sql = "update Products set name='" + p.name + "',companyName='" + p.companyName + "',size='" + p.size + "',quantity=" + p.quantity + ",holeSaleUnitPrice=" + p.holeSaleUnitPrice
                    + ",retailUnitPrice=" + p.retailUnitPrice + ",discountAmount=" + p.discountAmount + ",stockDate='" + p.stockDate + "',productCode='" + p.productCode +
                    "',category='" + p.category + "' where productCode='"+p.productCode+"';";
                int x = this.Da.ExecuteDml(sql);
                if (x == 1)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteData(string s)
        {
            try
            {
                var sql = "Delete from products where productCode='" + s + "';";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public string GetCode(string category)
        {
            try
            {
                var sql = " select productCode from Products where category = '" + category + "' order by productCode desc;";
                var dt = this.Da.ExecuteQuiry(sql);
                if (dt.Tables[0].Rows.Count!=0)
                    return dt.Tables[0].Rows[0][0].ToString();
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}
