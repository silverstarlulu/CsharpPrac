using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -5;
            int num2 = 5;
            long bignum = 1000000000000L;
            short smallnum = 5000;
            byte smallnum2 = 250;
            bool logic = true;
            char str1 = 'a';
            string str2 = "abcd";
            float f1 = 0.5F;
            double doublenum = 0.5555555D;

            int a = 5;
            string b = "";
            b = a.ToString();

            string d = "5";
            int dd = Int32.Parse(d);

            Console.WriteLine(dd);

            
        }
    }
}
