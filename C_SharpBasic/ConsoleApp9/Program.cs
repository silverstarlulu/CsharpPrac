using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //Car car2 = new Car();

            //car1.getModel();
            //car1.handle = "1000";
            //car1.getHandle();

            //car2.getModel();
            //car2.getHandle();

            CarRenew r1 = new CarRenew();
            r1.getModel();
            r1.handle = "2000";
            r1.getHandle();

            r1.getA();

        }
    }
}
