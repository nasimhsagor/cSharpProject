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
    public class CartRepo
    {
        private DataAccess Da { get; set; }
        public CartRepo()
        {
            this.Da = new DataAccess();
        }
        public List<string> FillCmbCategory()
        {
            List<string> data = new List<string>();
            try
            {
                var sql = "select distinct category from products;";
                var dt = this.Da.ExecuteQuiry(sql);
                int ax = 0;
                while (ax < dt.Tables[0].Rows.Count)
                {
                    data.Add(dt.Tables[0].Rows[ax]["category"].ToString());
                    ax++;
                }
                return data;
            }
            catch { return null; }
        }
        public List<string> FillCmbSize(string code)
        {
            List<string> size = new List<string>();
            try
            {
                var sql = "select size from products where productCode='" + code + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    size.Add(dt.Tables[0].Rows[count++]["size"].ToString());
                }
                return size;
            }
            catch { return null; }
        }
        public List<string> FillCmbEmployee()
        {
            List<string> name = new List<string>();
            try
            {
                var sql = "select name from employeeDetails;";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    name.Add(dt.Tables[0].Rows[count++]["name"].ToString());
                }
                return name;
            }
            catch { return null; }
        }
        public List<Products> FillProductNameList(string category, string nameOrId)
        {
            List<Products> product = new List<Products>();
            try
            {
                var sql = "select * from products where category='" + category + "' and quantity != 0 ;";
                if (nameOrId != null)
                    sql = "select * from products where  (name like '%" + nameOrId + "%' or productCode like'%"
                     + nameOrId + "%') and quantity != 0;";

                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    product.Add(ConvertData(dt.Tables[0].Rows[count++]));
                }
                return product;
            }
            catch { return null; }
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
        public string Id(string name)
        {
            try
            {
                var sql = "select Id from employeeDetails where name ='" + name + "';";
                var dt = this.Da.ExecuteQuiry(sql);
                return dt.Tables[0].Rows[0]["Id"].ToString();
            }
            catch { return null; }
        }
        public void UpdateInProductsDB(int Id, int quantity)
        {
            try
            {
                var sql = "update Products set quantity=" + quantity + "where id =" + Id + ";";
                this.Da.ExecuteDml(sql);
            }
            catch { return; }
        }
        public int GetCurrentProductQuantity(int id)
        {
            try
            {
                var sql = "select quantity from products where id="+id+";";
                var dt=this.Da.ExecuteQuiry(sql);
                return Convert.ToInt32(dt.Tables[0].Rows[0]["quantity"]);
            }
            catch { return 0; }
        }
        public bool InsertIntoSalesHisDB(List<SalesHistories> his)
        {
            int count = 0;
            int dmlCount = 0;
            try
            {
                while (count < his.Count)
                {

                    var sql = "Insert into SalesHistories values('" + his[count].productCode+"','" + his[count].date + "','" + his[count].productName + "',"
                        + his[count].quantity + "," + his[count].unitPrice + ",'" + his[count].customerPhoneNumber + "','" +
                        his[count].companyName + "'," + his[count].Product_Id + ",'" + his[count].EmployeeDetails_Id +
                        "','" + his[count].category + "'," + his[count].discountAmount + "," + his[count].Total + ");";
                    
                    dmlCount += this.Da.ExecuteDml(sql);
                    count++;
                }
                if (dmlCount == his.Count)
                    return true;
                return false;
            }
            catch { return false; }
        }
    }
}
