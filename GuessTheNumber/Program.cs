using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            var number = randNum.Next(1, 11);
            int userInput = 0;
            const int chances = 4;

            for (var i = 0; i < chances; i++)
            {
                Console.Write("Guess a number between 1 and 10:  ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("You won! 🙂");
                    break;
                }
                else if (i != chances - 1)
                {
                    Console.WriteLine("Try again! 😐");
                }
            }

            if (userInput != number)
            {
                Console.WriteLine("You lost! 😞");
            }

            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}
