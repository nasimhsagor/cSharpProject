using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    internal class Employee : Person
    {
        private double salary;
        internal double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        internal Employee(int id, string name, AddressFormat homeAddress, string bloodGroup, double salary) : base(id, name, homeAddress, bloodGroup)
        {
            //this.Id=id;
            //this.Name=name;
            //this.AddressFormat=homeAddress;
            //this,BloodGroup=bloodgroup;
            this.Salary = salary;
        }
    }
}
