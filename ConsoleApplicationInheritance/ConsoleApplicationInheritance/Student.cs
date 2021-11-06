using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationInheritance
{
        internal class Student:Person
        {
	        private double cgpa;
	        internal double Cgpa
	        {
		        get{return this.cgpa;}
		        set{this.cgpa=value;}
	        }
	        internal Student(int id,string name,AddressFormat homeAddress,string bloodGroup,double cgpa) :base(id,name,homeAddress,bloodGroup)
	        {
		        //this.Id=id;
		        //this.Name=name;
		        //this.AddressFormat=homeAddress;
		        //this.BloodGroup = bloodGroup;
                this.Cgpa=cgpa;
	        }
        }
}
