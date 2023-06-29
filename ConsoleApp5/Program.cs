using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 10;

            if (a < b)
            {
                Console.WriteLine("a보다 b가 더 큽니다.");
            }
            else if (a > b)
            {
                Console.WriteLine("b보다 a가 더 큽니다.");
            }
            else
            {
                Console.WriteLine("a와 b의 값은 같습니다.");
            }

            int week = 3;

            switch (week)
            {
                case 1: 
                    Console.WriteLine("월요일"); 
                    break;
                case 2: 
                    Console.WriteLine("화요일"); 
                    break;
                case 3: 
                    Console.WriteLine("수요일"); 
                    break;
                case 4: 
                    Console.WriteLine("목요일"); 
                    break;
                default: 
                    Console.WriteLine("금요일"); 
                    break;
            }
        }
    }
}
