using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DateFormat d1 = new DateFormat(24,06,2010);
            DateFormat d2 = new DateFormat(29,09,2015);
            AddressFormat a1 = new AddressFormat(58, "KURATOLI", "KURIL");
            AddressFormat a2 = new AddressFormat(7, "HAZIPARA", "RAMPURA");
            Employee e1 = new Employee();
            e1.Id = 01;
            e1.Name = "SAJIB HASAN";
            e1.Salary = 25000;
            e1.JoiningDate = d1;
            e1.Address = a1;
            e1.ShowEmployeeInfo();
            Employee e2 = new Employee(02, "PARTHO KABIR", 30000, d2, a2);
            e2.ShowEmployeeInfo();
            e2.YearlySalary(30000);
        }
    }
}
