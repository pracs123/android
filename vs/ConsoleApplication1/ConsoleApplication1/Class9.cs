using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using Second;
namespace First
{
    class NamespaceDemo1
    {
        public void sayHi()
        {
            Console.WriteLine("Hi First Namespace");
        }
    }
}
namespace Second
{
    class NamespaceDemo2
    {
        public void saywelcome()
        {
            Console.WriteLine("Welcome Second Namespace");
        }
    }
}
class TestNamespace
{
    static void Main(string[] args)
    {
        NamespaceDemo1 h1 = new NamespaceDemo1();
        NamespaceDemo2 h2 = new NamespaceDemo2();
        h1.sayHi();
        h2.saywelcome();
        Console.ReadLine();
    }
}
