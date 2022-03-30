using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating..");
        }

        public string SaySomething(string sound)
        {
            throw new NotImplementedException();
        }
    }
}
