using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class student
    {
        public int hin, mar, eng, sports, tot, avg;
        public void getmarks()
        {
            Console.Write("Enter marks of three subjects:");
            hin = Convert.ToInt32(Console.ReadLine());
            mar = Convert.ToInt32(Console.ReadLine());
            eng = Convert.ToInt32(Console.ReadLine());
        }
    }
    class sportsclass : student
    {
        public void getsports()
        {
            Console.Write("Enter marks of sports:");
            hin = Convert.ToInt32(Console.ReadLine());
        }
    }
    class result : sportsclass
    {
        public void cal()
        {
            tot = hin + mar + eng + sports;
            avg = tot / 3;
            Console.WriteLine("Total marks:" + tot);
            Console.WriteLine("Average:" + avg);
        }
    }
    class D
    {
        public static void m(String[] args)
        {
            result r = new result();
            r.getmarks();
            r.getsports();
            r.cal();
            Console.ReadLine();
        }
    }
}
