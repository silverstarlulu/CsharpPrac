using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;

            Class1 c1 = new Class1();
            int c = c1.addsum(a, b);

            Console.WriteLine(c);

            c1.sound();
        }

       
    }
}
