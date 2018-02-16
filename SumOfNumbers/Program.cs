using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            int number = 0;
            int total = 0;
            while (input != "ok")
            {
                Console.WriteLine("Please a number or type 'ok' to quit");
                input = Console.ReadLine();
                int.TryParse(input, out number);

                if (number > 0)
                {
                    total = total + number;
                    number = 0;
                }
                // Console.WriteLine("Inside while loop");
                //Console.ReadLine();
            }
            //Console.WriteLine("Exited while loop!!!");
            Console.WriteLine("Total: " + total);
            Console.ReadLine();
        }
    }
}
