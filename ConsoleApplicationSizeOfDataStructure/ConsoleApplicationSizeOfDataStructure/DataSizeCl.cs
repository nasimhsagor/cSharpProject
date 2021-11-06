using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSizeOfDataStructure
{
    public class DataSizeCl
    {
        public int a;
        public double b;

        public void DataSize(int a, double b)
        {
            this.a = a;
            this.b = b;

        }
        public void Show()
        {
            Console.WriteLine("Size of integer in byte : {0}", sizeof(a));
            Console.WriteLine("Size of double in byte : {0}", sizeof(b));
        }
    }
    
}
