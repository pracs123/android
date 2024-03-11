using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class3
    {
        static void m(string[] args)
        {
            int p = 0;
            Console.WriteLine("Enter Number");
            int n = Int16.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    p++;
                }
            }
            if (p == 2)
            {
                Console.WriteLine("Entered Number is Prime");
            }
            else
            {
                Console.WriteLine("Entered Number is not Prime");
            }
            Console.ReadLine();

        }
    }
}

