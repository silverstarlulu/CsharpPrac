using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;

            //} while (i < 0);

            //Console.WriteLine(i);

            for(int i=0; i < 5; i++)
            {
                Console.WriteLine(i);
             
            }

            string[] strs = { "blue", "pink", "orange", "gray" };

            foreach(string str in strs)
            {
                Console.WriteLine(str);
            }

            for(int i=0; i < 3; i++)
            {
                for(int j=0; j < 2; j++)
                {
                    Console.WriteLine(i + "," + j);
                }
            }

        }
    }
}
