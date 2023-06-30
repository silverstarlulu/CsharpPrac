using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        class Car
        {
            private string handle="";

            public void Run()
            {
                Console.WriteLine("달리기");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("글자찍기");
            Car car = new Car();
            car.Run();
        }
    }
}
