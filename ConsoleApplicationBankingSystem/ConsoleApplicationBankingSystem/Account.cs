using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationBankingSystem
{
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
            Console.WriteLine("JOINING DATE:");
            Console.WriteLine("DAY : {0}", this.day);
            Console.WriteLine("MONTH: {0}", this.month);
            Console.WriteLine("YEAR: {0}", this.year);

        }
    }



    struct AddressFormat
    {
        private byte apartmentNo;
        private byte roadNo;
        private string district;
        private string country;

        public AddressFormat(byte apartmentNo, byte roadNo, string district, string country)
        {

            this.apartmentNo = apartmentNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;


        }

        public void PrintAddress()
        {
            Console.WriteLine("ADDRESS:");
            Console.WriteLine("APARTMENT NO : {0}", this.apartmentNo);
            Console.WriteLine("ROAD NO : {0}", this.roadNo);
            Console.WriteLine("DISTRICT: {0}", this.district);
            Console.WriteLine("COUNTRY : {0}", this.country);

        }
    }



    internal class Account
    {
        private string name;
        protected string id;
        private DateFormat openingDate;
        private AddressFormat address;
        private double balance;

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal DateFormat OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }
        internal AddressFormat Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        internal Account(string name, string id, DateFormat openingDate, AddressFormat address, double balance)
        {
            this.Name = name;
            this.Id = id;
            this.OpeningDate = openingDate;
            this.Address = address;
            this.Balance = balance;

        }
        internal virtual void AccountDetails()
        {
            Console.WriteLine("NAME :{0}", this.Name);
            Console.WriteLine("ID :{0}", this.Id);
            this.OpeningDate.PrintDate();
            this.Address.PrintAddress();
            Console.WriteLine("BALANCE : {0}", this.Balance);
        }
    }
}
