using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IAnimal animal = new Dog();
            Cat cat = new Cat();
            
            animal.Eat();

            cat.Eat();

            bool b = cat is object;
            Console.WriteLine(b);

            Dog dog = animal as Dog;
            Console.WriteLine(dog);
            //(animal as Dog).Bark();
        }
    }
}
