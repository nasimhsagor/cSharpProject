using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("This number is Even");
                }
                else
                {
                    Console.WriteLine("This number is Odd");
                }
            }
        }
    }
}
