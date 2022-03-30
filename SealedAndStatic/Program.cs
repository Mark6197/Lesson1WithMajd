using System;

namespace SealedAndStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Age=18;
            Calculator calculator = new Calculator();
            Calculator calculator2 = new Calculator();
            Calculator calculator3 = new Calculator();
            Calculator calculator4 = new Calculator();
            Calculator calculator5 = new Calculator();

            Console.WriteLine(Calculator.Age);
            
        }
    }
}
