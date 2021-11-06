using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingShopManagementSystem.Data;
using ClothingShopManagementSystem.Entity;



namespace ClothingShopManagementSystem.Repository
{
    public class LoginInfoRepo
    {
        private DataAccess Da { get; set; }
        public LoginInfoRepo()
        {
            this.Da = new DataAccess();
        }
        public Login Search(Login lg)
        {
            var quiry = "select * from vWLogin where id='" + lg.id + "'and password='" + lg.password + "';";
            var dt = this.Da.ExecuteQuiry(quiry);
            if (dt.Tables[0].Rows.Count == 1 && dt.Tables[0].Rows[0]["password"].ToString() == lg.password && dt.Tables[0].Rows[0]["Id"].ToString()==lg.id)
            {   
              Login g = new Login();
              g.password = dt.Tables[0].Rows[0]["password"].ToString();
              g.id = dt.Tables[0].Rows[0]["id"].ToString();
              g.role = dt.Tables[0].Rows[0]["role"].ToString();
              g.name = dt.Tables[0].Rows[0]["name"].ToString();
                
              return g;
            }
            else
            {
                return null;
            }
        }
        public void InseartIntoLoginHistory(Login lg)
        {
            try
            {
                var sql = "insert into LoginHistories values('" + lg.name + "','" + lg.id + "','"+DateTime.Now.ToString("G")+"');";
                this.Da.ExecuteDml(sql);
            }
            catch(Exception)
            { return; }
        }
    }
}
