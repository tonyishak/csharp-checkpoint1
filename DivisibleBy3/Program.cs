using System;

namespace DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int length = 100;

            for (int i = 1; i < length; i++)
            {
                if (i % 3 == 0)
                {
                    count = count + 1;

                }
            }
            Console.WriteLine("Total count is " + count);
            Console.ReadLine();
        }
    }
}
