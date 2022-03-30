using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Mark";
            person.Age = 18;
            person.Age = -1;
            Console.WriteLine(person.Age);
            //person.SetAge(18);
            //person.SetAge(-1);
            //Console.WriteLine(person.GetAge());
        }
    }
}
