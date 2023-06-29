using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Car
    {
        private string model = "DefaultModel";
        public string handle = "DefaultHandle";

        protected string a = "A";

        public void getModel()
        {
            Console.WriteLine(model);
        }

        public void getHandle()
        {
            Console.WriteLine(handle);
        }
    }
}
