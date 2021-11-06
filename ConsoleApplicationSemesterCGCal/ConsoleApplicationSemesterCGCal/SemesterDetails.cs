using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationSemesterCGCal
{
    class SemesterDetails
    {
        String name;
        String id;
        int sem;
        float cgpa;



        public SemesterDetails()
        {

        }
        public SemesterDetails(String name, String id, int sem)
        {
            this.name = name;
            this.id = id;
            this.sem = sem;
        }
        public void showInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
           Console.WriteLine("Semester : " + sem);
        }
        public void GPACalculator(params float[] x)
        {
            float s=0;
            for (int i = 0; i < x.Length; i++)
            {
                sum = sum + cg[i];
            }

             cgpa = sum / c;
           
            Console.WriteLine("CGPA: " + cgpa);

        }
       public void ListOfSubjects(params object[] y)
        {
            Console.WriteLine("List of Subjects: ");
            for (int i = 0; i <= y.Length; i++)
            {
                
                Console.WriteLine(y[i]);
            }
        }
         
    }
}
