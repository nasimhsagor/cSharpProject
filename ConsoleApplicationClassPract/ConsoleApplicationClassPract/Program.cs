using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationClassPract
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("RIMON","18-38911-3",3.75);
            s1.ShowInfo();
           
            Student s2 = new Student("SAGOR", "18-38910-3", 3.37);
            s2.ShowInfo();
        }
    }
}
