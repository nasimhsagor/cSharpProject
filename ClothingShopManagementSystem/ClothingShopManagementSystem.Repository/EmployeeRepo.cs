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
     public class EmployeeRepo
    {
        private DataAccess Da { get; set; }
        public EmployeeRepo()
        {
            this.Da = new DataAccess();
        }
        public List<EmployeeDetails> GetAllData(string bind)
        {
            List<EmployeeDetails> emp = new List<EmployeeDetails>();
            var sql = "select * from EmployeeDetails where name like '%" + bind + "%' or id like '%" + bind + "%';";
            try
            {
                if (bind==null)
                    sql = "select * from EmployeeDetails;";
                var dt = Da.ExecuteQuiry(sql);
                int loop = 0;
                while(loop<dt.Tables[0].Rows.Count)
                {
                    EmployeeDetails empd = this.Convert(dt.Tables[0].Rows[loop]);
                    emp.Add(empd);
                    loop++;
                }
                return emp;
            }
            catch
            {
                return null;
            }
        }
        private EmployeeDetails Convert(DataRow da)
        {
            if (da == null)
                return null;
            var dt = (DateTime)da["joinDate"];
            EmployeeDetails p = new EmployeeDetails();
            p.Id = da["Id"].ToString();
            p.joinDate = dt.ToString("dd-MMM-yyyy");
            p.name = da["name"].ToString();
            p.phonenumber = da["phonenumber"].ToString();
            p.salary = Double.Parse(da["salary"].ToString());
            return p;
        }
        public bool AddEmployee(EmployeeDetails emp)
        {
            if (emp == null)
                return false;
            int s;
            try
            {
                var sql = "insert into EmployeeDetails values('" + emp.Id + "','" + emp.name +
                      "','" + emp.joinDate + "'," + emp.salary + ",'" + emp.phonenumber + "');";
                 s = this.Da.ExecuteDml(sql);
                var quiry = "insert into LoginInfo values('" + emp.Id + "','" + emp.password +"','"+emp.role+"');";
                this.Da.ExecuteDml(quiry);
            }
            catch { return false; }
            if(s==1)
                return true;
            return false;
        }
        public bool DeleteData(string data)
        {
            if (data == null)
                return false;
            try
            {
                var sql = "delete from EmployeeDetails where id='" + data + "';";
                int count = this.Da.ExecuteDml(sql);
                if (count == 1)
                    return true;
                return false;
            }
            catch { return false; }
        }
        public bool Upate(EmployeeDetails e)
        {
            try
            {
                var sql = "update EmployeeDetails set name='" + e.name + "',joinDate='" + e.joinDate + 
                    "',phonenumber='" + e.phonenumber + "',salary=" + e.salary + " where Id='" + e.Id + "';";
                int x = this.Da.ExecuteDml(sql);
                if (x != 1)
                    return false;
                return true;
            }
            catch { return false; }
        }
    }
}
