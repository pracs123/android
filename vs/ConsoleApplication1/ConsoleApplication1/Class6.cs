using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class FunctionOverloading
    {
        static void area(int a, int b)
        {
            Console.WriteLine("Area of Rectangle is:" + (a * b));
        }
        static void area(int x)
        {
            Console.WriteLine("Area of Square is:" + (x * x));
        }
        static void area(int i, int j, int k)
        {
            Console.WriteLine("Area of Triangle is:" + (i * j * k));
        }
        static void m(string[] args)
        {
            area(23);
            area(12, 45);
            area(12, 23, 14);
            Console.ReadLine();
        }
    }
}
