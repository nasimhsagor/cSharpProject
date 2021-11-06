using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Entity
{
    public class ReturnList
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string date { get; set; }
        public int Product_Id { get; set; }
        public string productCode { get; set; }
        public int quantity { get; set; }
        public double unitprice { get; set; }
        public string category { get; set; }
        public double Total { get; set; }
        public string customerPhoneNumber { get; set; }
        public string name { get; set; }
        public double discount { get; set; }
    }
}
