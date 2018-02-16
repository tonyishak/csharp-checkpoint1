using System;

namespace SeriesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a series of numbers separate by a comma:  ");
            string userInput = Console.ReadLine();

            string[] numbers = userInput.Split(',');
            var max = 0;

            for (var i = 0; i < numbers.GetLength(0); i++)
            {
                if (Convert.ToInt32(numbers[i]) > max)
                {
                    max = Convert.ToInt32(numbers[i]);
                }
            }
            Console.WriteLine(max);

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
