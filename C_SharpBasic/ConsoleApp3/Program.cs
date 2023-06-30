using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            a++;
            Console.WriteLine(a);

            int b = 3;
            int c;
            c = b - a;
            Console.WriteLine(c);

            int d = (5 > 3) ? 2 : 0;
            Console.WriteLine(d);

            int aa = 4;
            int bb = 3;
            bb = aa;
            Console.WriteLine(bb);

            int q = 5;
            Console.WriteLine(q++);
            Console.WriteLine(q);

            int w = 1;
            int e = w++;
            Console.WriteLine(w);
            Console.WriteLine(e);

            bool result = true;
            bool result2 = false;
            Console.WriteLine(!result);
            Console.WriteLine(result && result2);
            Console.WriteLine(result || result2);

            int A = 1;
            int B = 5;
            Console.WriteLine(A & B);
            Console.WriteLine(A | B);
            Console.WriteLine(A ^ B);
        }
    }
}
