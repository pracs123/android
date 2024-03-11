using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        int RollNo;
        string Name;
        static void m(string[] args)
        {
            Student s1 = new Student();
            s1.RollNo = 1;
            s1.Name = "Ankur";
            Console.WriteLine(s1.RollNo);
            Console.WriteLine(s1.Name);
            Console.ReadLine();
        }
    }
}
