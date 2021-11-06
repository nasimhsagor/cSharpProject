using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Entity
{
     public class EmployeeDetails
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string joinDate { get; set; }
        public double salary { get; set; }
        public string phonenumber { get; set;}
        public string password { set; get; }
        public string role = "salesman";
    }
}
