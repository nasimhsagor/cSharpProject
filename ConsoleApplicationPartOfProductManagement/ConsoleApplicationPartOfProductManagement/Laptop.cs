using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPartOfProductManagement
{
    class Laptop:Product

    {
        private ushort memorySize;
        private double clockSpeed;
        private byte batteryLife;

        internal ushort MemorySize
        {
            get { return this.memorySize; }
            set { this.memorySize = value; }
        }
        internal double ClockSpeed
        {
            get { return this.clockSpeed; }
            set { this.clockSpeed = value; }
        }
        internal byte BatteryLife
        {
            get { return this.batteryLife; }
            set { this.batteryLife = value; }
        }


        internal Laptop(ushort id, double quantity, double price, DateFormat productionDate, string manufacturerName, ushort memorySize, double clockSpeed, byte batteryLife)
            : base(id, quantity, price, productionDate, manufacturerName)
        {
            this.MemorySize = memorySize;
            this.ClockSpeed = clockSpeed;
            this.BatteryLife = batteryLife;

        }
        internal void ExtraChargeLaptop(double price)
        {
            double extra, extraVAT, surCharge;
            this.Price = price;
            extraVAT = price * .1;
            surCharge = price * .02;
            extra = extraVAT + surCharge;
            Console.WriteLine("Extra Charge :{0}", extra);
        }

        internal override void ShowProduct()
        {
            base.ShowProduct();
            Console.WriteLine("Memory Size: {0}", this.MemorySize);
            Console.WriteLine("Clock Speed: {0}", this.ClockSpeed);
            Console.WriteLine("Battery Life: {0}", this.BatteryLife);
        }

    }
}
