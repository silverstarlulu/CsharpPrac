using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal=new Animal();
            animal.animalSound();

            Dog dog = new Dog();
            dog.animalSound();

            Cat cat = new Cat();
            cat.animalSound();

            Bird bird = new Bird();
            bird.animalSound();

            animal = new Dog();
            animal.animalSound();

        }
    }
}
