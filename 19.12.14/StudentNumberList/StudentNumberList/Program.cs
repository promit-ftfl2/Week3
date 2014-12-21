using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentNumberList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students=new List<Student>();
            Student student1=new Student();
            Student student2=new Student();
            Student student3=new Student();
            student1.regNo = "432";
            student2.regNo = "564";
            student3.regNo = "765";
            student1.lastName = "rew";
            student2.lastName = "uyt";
            student3.lastName = "nbc";
            student1.firstName = "fds";
            student2.firstName = "klj";
            student3.firstName = "gcn";
            Student.Add(student1);
            Student.Add(student2);
            Student.Add(student3);
            foreach (Student aStudent  in students)
            {
               Console.WriteLine(aStudent.GetfulName()); 
            }
            Console.ReadKey();
        }
    }
}
