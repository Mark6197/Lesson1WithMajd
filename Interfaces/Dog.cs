using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Dog : IAnimal
    {
        public void Bark()
        {
            Console.WriteLine("How How");
        }
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public string SaySomething(string sound)
        {
            Console.WriteLine(sound);
            return sound;
        }
        public override string ToString()
        {
            return "Dog";
        }
    }
}
