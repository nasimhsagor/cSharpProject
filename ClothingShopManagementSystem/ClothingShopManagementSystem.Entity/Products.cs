using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Entity
{
   public class Products
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string companyName { get; set; }
        public string size { get; set; }
        public string category { get; set; }
        public double holeSaleUnitPrice { get; set; }
        public double retailUnitPrice { get; set; }
        public string productCode { get; set; }
        public string stockDate { get; set; }
        public int quantity { get; set; }
        public double discountAmount { get; set; }
    }
}
