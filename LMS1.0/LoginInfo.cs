using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LMS1._0
{
    public class LoginInfo
    {
        private DataAccess da { get; set; }
        public LoginInfo()
        {
            this.da = new DataAccess();
        }
        public Login Search(Login lg)
        {
            var quiry = "select * from UserDatas where Name='" + lg.Name + "'and Password='" + lg.Password + "';";
            var dt = this.da.ExecuteQuiry(quiry);
            if (dt.Tables[0].Rows.Count == 1 && dt.Tables[0].Rows[0]["Password"].ToString() == lg.Password && dt.Tables[0].Rows[0]["Name"].ToString() == lg.Name)
            {
                Login g = new Login();
                g.Password = dt.Tables[0].Rows[0]["Password"].ToString();
                g.Name = dt.Tables[0].Rows[0]["Name"].ToString();

                return g;
            }
            else
            {
                return null;
            }
        }
      
    }
}
