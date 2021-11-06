using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEmployeeManagementUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateFormat d1 = new DateFormat(24,07,2010);
            DateFormat d2 = new DateFormat(15,03,2014);
            AddressFormat a1 = new AddressFormat(58, "KURATOLI", "KURIL");
            AddressFormat a2 = new AddressFormat(7, "HAZIPARA", "RAMPURA");
            Employee e1 = new Employee();
            e1.Id = 01;
            e1.Name = "SAJIB HASAN";
            e1.Salary = 35000;
            e1.JoiningDate = d1;
            e1.Address = a1;
            e1.ShowEmployeeInfo();
            Employee e2 = new Employee(02, "PATRHO KUMAR", 30000, d2, a2);
            e2.ShowEmployeeInfo();
            e2.YearlySalary(30000);
            e2.BreakDownYearlySalary(30000);


        }
    }
}