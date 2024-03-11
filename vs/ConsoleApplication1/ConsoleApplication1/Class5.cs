using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FactorialExample
    {
        public int factorial(int n)
        {
            int result;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(n - 1) * n;
                return result;
            }
        }
        static void m(string[] args)
        {
            FactorialExample f = new FactorialExample();
            int fact = f.factorial(5);
            Console.WriteLine("Factorial of Number is:" + fact);
            Console.ReadLine();
        }
    }
}
