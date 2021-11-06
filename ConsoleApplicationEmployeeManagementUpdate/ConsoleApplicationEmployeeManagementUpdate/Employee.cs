using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationEmployeeManagementUpdate
{

    struct AddressFormat
    {
        private byte houseNo;
        private string streetName;
        private string upazilaName;

        public AddressFormat(byte houseNo, string streetName, string upazilaName)
        {
            this.houseNo = houseNo;
            this.streetName = streetName;
            this.upazilaName = upazilaName;

        }

        public void PrintAddress()
        {
            Console.WriteLine("Employee Address:");
            Console.WriteLine("House No : {0}", this.houseNo);
            Console.WriteLine("Street Name: {0}", this.streetName);
            Console.WriteLine("Upazila Name : {0}", this.upazilaName);

        }
    }


    struct DateFormat
    {
        private byte day;
        private byte month;
        private ushort year;


        public DateFormat(byte day, byte month, ushort year)
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
            Console.WriteLine("***** Joining Date *****");
            Console.Write("Day: {0}", this.day);
            Console.Write("Month: {0}", this.month);
            Console.WriteLine("Year: {0}", this.year);

        }
    }

    class Employee
    {
        private ushort id;
        private string name;
        private int salary;
        private DateFormat joiningDate;
        private AddressFormat address;


        internal ushort Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }

        }

        internal DateFormat JoiningDate
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }

        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Employee()
        { }
        public Employee(ushort id, string name, int salary, DateFormat joiningDate, AddressFormat address)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.JoiningDate = joiningDate;
            this.Address = address;
        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine("***** Employee Information *****");
            Console.Write("Employee ID: {0}", this.Id);
            Console.Write("Employee Name: {0}", this.Name);
            Console.WriteLine("Employee Salary: {0}", this.Salary);
            this.JoiningDate.PrintDate();
            this.Address.PrintAddress();
        }
        public void YearlySalary(int salary)
        {
            double yearlySalary;
            yearlySalary = this.salary * 12;
            Console.WriteLine("yearly salary {0}", yearlySalary);
        }
        public void BreakDownYearlySalary(int salary)
        {
            double yearlySalary;
            yearlySalary = this.salary * 12;
            double basicSalary, houseRent, medicalAllowance, phoneBill;
            basicSalary = yearlySalary * .5;
            houseRent = yearlySalary * .3;
            medicalAllowance = yearlySalary * .15;
            phoneBill = yearlySalary * .05;
            Console.WriteLine("Basic Salary {0}", basicSalary);
            Console.WriteLine("House Rent {0}", houseRent);
            Console.WriteLine("Medical  Allowance {0}", medicalAllowance);
            Console.WriteLine("Cell phone Bill {0}", phoneBill);



        }

    }
}