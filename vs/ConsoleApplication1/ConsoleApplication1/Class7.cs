using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Construct
    {
        public Construct(int a, int b)
        {
            Console.WriteLine("Area of Rectangle is:" + (a * b));
        }
        public Construct(int x)
        {
            Console.WriteLine("Area of Square is:" + (x * x));
        }
        public Construct(int i, int j, int k)
        {
            Console.WriteLine("Area of Triangle is:" + (i * j * k));
        }

        static void m(string[] args)
        {
            Construct c1 = new Construct(23);
            Construct c2 = new Construct(12, 45);
            Construct c3 = new Construct(12, 23, 14);
            Console.ReadLine();
        }
    }
}
