using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
    struct AddressFormat
    {
        private byte road;
        private byte house;
        private string policeStation;
        private string district;
        private string postOffice;
        private byte postCode;

        public AddressFormat(byte road, byte house, string policeStation, string district, string postOffice, byte postCode)
        {
            this.road = road;
            this.house = house;
            this.policeStation = policeStation;
            this.district = district;
            this.postOffice = postOffice;
            this.postCode = postCode;
        }
        public void PrintAddress()
        {
            Console.WriteLine("House:{0}", house);
            Console.WriteLine("Road:{0}", road);
            
            Console.WriteLine("PostOffice:{0}", postOffice);
            Console.WriteLine("PostCode:{0}", postCode);
            Console.WriteLine("PoliceStation:{0}", road);
            Console.WriteLine("District:{0}", district);
        }
    }

    class Person
    {
        private int id;
        private string name;
        private AddressFormat homeAddress;
        private string bloodGroup;

        internal int Id
        {
	        get{return this.id;}
	        set{this.id = value;}
	
        }
        internal string Name
        {
	        get{return this.name;}
	        set{this.name = value;}
	
        }
        internal AddressFormat HomeAddress
        {
	        get{return this.homeAddress;}
	        set{this.homeAddress = value;}
	
        }
        internal string BloodGroup
        {
	        get{return this.bloodGroup;}
	        set{this.bloodGroup = value;}
	
        }

        internal Person(int id,string name,AddressFormat homeAddress,string bloodGroup)
        {
	        this.Id=id;
	        this.Name=name;
	        this.HomeAddress=homeAddress;
	        this.BloodGroup=bloodGroup;

        }
        internal void ShowInfo()
        {
	        Console.WriteLine("Id: {0}",this.Id);
	        Console.WriteLine("Name: {0}",this.Name);
	        this.homeAddress.PrintAddress();

	        Console.WriteLine("BloodGroup: {0}",this.BloodGroup);

        }
    }
}
