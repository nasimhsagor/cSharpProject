using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Entity
{
    public class SalesHistories
    {
        public string productName { get; set; }
        public string companyName { get; set; }
        public string category { get; set; }
        public double unitPrice { get; set; }
        public string productCode { get; set; }
        public string date { get; set; }
        public int quantity { get; set; }
        public double discountAmount { get; set; }
        public string customerPhoneNumber { get; set; }
        public int Product_Id { get; set; }
        public string EmployeeDetails_Id { get; set; }
        public double Total { get; set; }
        public int Id { set; get; }
    }
}
