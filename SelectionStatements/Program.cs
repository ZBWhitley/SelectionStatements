using System;

namespace SelectionStatements
{
    internal class random
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Please guess my favorite number:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > 27)
            {
                Console.WriteLine("Too high");
            }

            else if (userInput < 27)
            {
                Console.WriteLine("Too Low");
            }

            else 
            {
                Console.WriteLine("Congratulations, you won!");
            }

        }
    }
}
