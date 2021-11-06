using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPartOfProductManagement
{
    public struct DateFormat
    {
        byte day;
        byte month;
        ushort year;

        public DateFormat(byte day,byte month,ushort year)
        {
            this.day=day;
            this.month=month;
            this.year=year;
        }
        public void ShowDate()
        {
            Console.WriteLine("Day: {0}",this.day);
            Console.WriteLine("Month: {0}",this.month);
            Console.WriteLine("Year: {0}",this.year);
        }

    }
    class Product
    {
        private int id;
        private double quantity;
        private double price;
        private DateFormat productionDate;
        private string manufacturerName;

        internal int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        internal double Quantity
        {
            set { this.quantity = value; }
            get { return this.quantity; }
        }
        internal double Price
        {
            set { this.price= value; }
            get { return this.price; }
        }
        internal DateFormat ProductionDate
        {
            set { this.productionDate = value; }
            get { return this.productionDate; }
        }
        internal string ManufacturerName
        {
            set { this.manufacturerName = value; }
            get { return this.manufacturerName; }
        }
        internal Product(int id, double quantity, double price, DateFormat productionDate, string manufacturerName)
        {
            this.id = id;
            this.quantity = quantity;
            this.price = price;
            this.productionDate = productionDate;
            this.manufacturerName = manufacturerName;
 
        }
        internal virtual void ShowProduct()
        {
            Console.WriteLine("Id: {0}", this.id);
            Console.WriteLine("Quantity: {0}", this.quantity);
            Console.WriteLine("Price: {0}", this.price);
            Console.WriteLine("ProductionDate: {0}", this.productionDate);
            Console.WriteLine("ManufacturerName: {0}", this.manufacturerName);
        }

    }
    
}
