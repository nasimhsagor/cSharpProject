using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPartOfProductManagement
{
    class CannedFood:Product
    {
        private DateFormat expireDate;

        internal DateFormat ExpireDate
        {
            get { return this.expireDate; }
            set { this.expireDate = value; }
        
        }
        internal CannedFood(int id, double quantity, double price, DateFormat productionDate, string manufacturerName, DateFormat ExpireDate)
            : base(id, quantity, price, productionDate, manufacturerName)
        {
            this.ExpireDate = expireDate;

        }
        internal void ExtraChargeCannedFood(double price)
        {    
            double extra;
            this.Price = price;
            extra = price * .5;
            Console.WriteLine("Extra VAT :{0}",extra);
        }

        internal override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Expire Date:");
            this.ExpireDate.ShowDate();
        }

    }
}
