using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationClassPract
{
    class Student
    {
        public string name;
        public string id;
        public double cgpa;

        public Student(string name, string id, double cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
        }

        public void ShowInfo()
        {
            Console.WriteLine("**STUDENT INFORMATION**");
            Console.WriteLine("NAME:{0}", this.name);
            Console.WriteLine("ID:{0}", this.id);
            Console.WriteLine("CGPA:{0}", this.cgpa);
        }
    }
}
