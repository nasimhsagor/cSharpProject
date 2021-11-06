using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Entity
{
     public class Costs
    {
        public int Id { get; set; }
        public string costdetails { get; set; }
        public string date { get; set; }
        public double amount { get; set; }
        public string type { get; set; }
    }
}
