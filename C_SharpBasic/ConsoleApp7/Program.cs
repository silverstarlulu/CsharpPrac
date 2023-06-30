using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "";
            //a = Console.ReadLine();
            //int[] asd = { 0, 1, 2, 3 };

            //Console.WriteLine(asd[Int32.Parse(a)]);

            try
            {
                int[] asd = { 0, 1, 2, 3 };

                Console.WriteLine(asd[4]);
            }
            catch(Exception e)
            {
                Console.WriteLine("오류발생");
                Console.WriteLine(e.ToString());

            }
            finally
            {
                Console.WriteLine("오류 발생유무와 상관없이 출력");
            }
        }
    }
}
