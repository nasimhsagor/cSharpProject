using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPartOfProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] productlist = new Product[2];
            productlist[0] = new CannedFood(001, 1.5, 550, new DateFormat(01, 10, 2021), "ACI", new DateFormat(30, 12, 2022));
            productlist[1] = new Laptop(101, 25, 45000, new DateFormat(01, 01, 2021), "DELL", 500, 2.15, 10);
            foreach (Product p in productlist)
            {
                p.ShowProduct();
                Console.WriteLine();


            }
        }
    }
}
