using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);

            }

            int[,] abc = { { 1, 2, 3 } , { 4, 5, 6 } };

            Console.WriteLine(abc[0,2]);

            int[][] hello = new int[3][];
            hello[0] = new int[4];
            hello[1] = new int[3];
            hello[2] = new int[2];

            hello[2][1] = 4;

            Console.WriteLine(hello[0][0]);
            Console.WriteLine(hello[2][1]);


        }
    }
}
