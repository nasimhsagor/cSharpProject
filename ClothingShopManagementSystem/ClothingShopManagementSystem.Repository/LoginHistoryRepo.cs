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
    public class LoginHistoryRepo
    {
        private DataAccess Da { set; get; }
        public LoginHistoryRepo()
        {
            this.Da = new DataAccess();
        }
        public List<LoginHistories> GetAll(string date)
        {
            var history = new List<LoginHistories>();
            try
            {
                var sql = "select* from loginhistories;";
                if(date!=null)
                    sql= "select* from LoginHistories where cast(DateTime as date)='" + date+"';";
                var dt = this.Da.ExecuteQuiry(sql);
                int count = 0;
                while (count < dt.Tables[0].Rows.Count)
                {
                    var log = this.Convert(dt.Tables[0].Rows[count++]);
                    history.Add(log);
                }
                return history;
        }
            catch (Exception)
            {
                return null;
            }
}
        private LoginHistories Convert(DataRow dr)
        {
            if (dr == null)
                return null;
            var log = new LoginHistories();
            log.lEmployeDetail_Id = dr["EmployeeDetail_Id"].ToString();
            var dt = (DateTime)dr["DateTime"];
            log.time = dt.ToString("T");
            log.ldate = dt.ToString("dd-MMMM-yyyy");
            log.name = dr["name"].ToString();
            return log;
        }
    }
}
