using System;

namespace FactorialOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i < 0; i--)
            {

                factorial = factorial * 1;
            }
            Console.WriteLine("The factorial of {0} is {1}", number, factorial);
            Console.ReadLine();
        }
    }
}
