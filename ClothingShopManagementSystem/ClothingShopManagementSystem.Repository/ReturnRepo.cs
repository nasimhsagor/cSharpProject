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
    public class ReturnRepo
    {
        private DataAccess Da { get; set; }
        public ReturnRepo()
        {
            this.Da = new DataAccess();
        }
        public List<ReturnList> GetAllData(string txtsearch,string date)
        {
            var product = new List<ReturnList>();
            try
            {
                var sql = "select* from vWReturnList;";
                if (txtsearch != null && date == null)
                    sql = "select* from vWReturnList where productName like'%" + txtsearch + "%'or productCode like'%" + txtsearch + "%'or customerphonenumber Like'%" + txtsearch + "%';";
                else if (date != null)
                    sql = "select* from vWReturnList where date='" + date + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    var data = this.ConvertData(dt.Tables[0].Rows[count]);
                    product.Add(data);
                    count++;
                }
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private ReturnList ConvertData(DataRow dr)
        {
            if (dr != null)
            {
                var rl = new ReturnList();
                rl.category = dr["category"].ToString();
                rl.name = dr["name"].ToString();
                rl.Id = Int32.Parse(dr["Id"].ToString());
                rl.productCode = dr["productCode"].ToString();
                rl.quantity = Int32.Parse(dr["quantity"].ToString());
                rl.Product_Id = Int32.Parse(dr["Product_Id"].ToString());
                rl.productName = dr["productName"].ToString();
                rl.Total = Double.Parse(dr["Total"].ToString());
                rl.unitprice = Double.Parse(dr["unitprice"].ToString());
                rl.customerPhoneNumber = dr["customerPhoneNumber"].ToString();
                var dt = (DateTime)dr["date"];
                rl.date = dt.ToString("dd-MM-yy");
                rl.discount = Double.Parse(dr["discountAmount"].ToString());
                return rl;
            }
            else
                return null;
        }
        public bool UpdateInSalesTable(ReturnList rl)
        {
            if (rl == null)
                return false;
            if (rl.quantity == 0)
            {
                try
                {
                    var sql = "delete from saleshistories where Id=" + rl.Id + ";";
                    int dis = this.Da.ExecuteDml(sql);
                    if (dis == 1)
                        return true;
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    var sql = "update SalesHistories set quantity=" + rl.quantity + ",total=" + rl.Total + " where Id=" + rl.Id+";" ;
                    int dis = this.Da.ExecuteDml(sql);
                    if (dis == 1)
                        return true;
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool updateInProductTable(ReturnList rl,int quantity)
        {
            if(rl==null)
                return false;
            try
            {
                var dt = this.Da.ExecuteQuiry("select quantity from products where Id=" + rl.Product_Id + ";");
                var sql = " update Products set quantity = " + (Int32.Parse(dt.Tables[0].Rows[0]["quantity"].ToString())+quantity) + " where Id = " + rl.Product_Id + "; ";
                int dis = this.Da.ExecuteDml(sql);
                if (dis == 1)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
 } 


