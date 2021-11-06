using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployeeManagement
{
    struct AddressFormate
    {
        private byte HouseNo;
        private string StreetName;
        private string UpazilaName;
    }

    public void PrintAddress()
    {
        Console.WriteLine("EMPLOYEE ADDRESS:");
        Console.WriteLine("HOUSE NUMBER:{0}", this.HouseNo);
        Console.WriteLine("STREET NAME:{0}", this.StreetName);
        Console.WriteLine("UPAZILA NAME:{0}", this.UpazilaName);

    }

    struct DateFormate
    {
        private byte day;
        private byte month;
        private ushort year;
    }

    public DateFormate(byte day,byte month,ushort year)
    {
        if (day >= 1 && day <= 31)
            this.day = day;
        else
            this.day = 0;
        if (month >= 1 && month <= 12)
            this.month = month;
        else
            this.month = 0;
        this.year = year;

    }

    public void PrintDate()
    {
        Console.WriteLine("JOINING DATE:");
        Console.WriteLine("DAY:{0}",this.day);
        Console.WriteLine("MONTH:{0}",this.month);
        Console.WriteLine("YEAR:{0}",this.year);
    }
    class Employee
    {
        private ushort Id;
        private string Name;
        private int Salary;
        private DateFormat JoiningDate;
        private AddressFormat Address;

        internal ushort Id
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        internal string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        internal int Salary
        {
            get { return this.Salary; }
            set { this.Salary = value; }
        }

        internal DateFormat JoiningDate
        {
            get { return this.JoiningDate; }
            set { this.JoiningDate = value; }
        }

         internal AddressFormat Address
        {
            get { return this.Address; }
            set { this.Address = value; }
        }
        
        public Employee()
        { }
        public Employee(ushort Id, string Name, int Salary, DateFormat JoiningDate, AddressFormat Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.JoiningDate = JoiningDate;
            this.Address = Address;
        }



        public void ShowEmployeeInfo()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Employee ID: {0}", this.Id);
            Console.WriteLine("Employee Name: {0}", this.Name);
            Console.WriteLine("Employee Salary: {0}", this.Salary);
            this.JoiningDate.PrintDate();
            this.Address.PrintAddress();
        }
        public void YearlySalary(int Salary)
        {
            double YearlySalary;
            YearlySalary = this.Salary * 12;
            Console.WriteLine("yearly salary {0}", YearlySalary);
        }
        public void BreakDownYearlySalary(int Salary)
        {
            double YearlySalary;
            YearlySalary = this.Salary * 12;
            double BasicSalary, HouseRent, MedicalAllowance, PhoneBill;
            BasicSalary = YearlySalary * .5;
            HouseRent = YearlySalary * .3;
            MedicalAllowance = YearlySalary * .15;
            PhoneBill = YearlySalary * .05;
            Console.WriteLine("Basic Salary {0}", BasicSalary);
            Console.WriteLine("House Rent {0}", HouseRent);
            Console.WriteLine("Medical  Allowance {0}", MedicalAllowance);
            Console.WriteLine("Cell phone Bill {0}", PhoneBill);

        }

    }
}
