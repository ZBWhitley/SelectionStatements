using System;

namespace SelectionStatements
{
    internal class random
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //var favNumber = r.Next(1, 1000);

            //Console.WriteLine("Please guess my favorite number:");
            //var userInput = int.Parse(Console.ReadLine());

            //if (userInput > 27)
            //{
            //    Console.WriteLine("Too high");
            //}

            //else if (userInput < 27)
            //{
            //    Console.WriteLine("Too Low");
            //}

            //else 
            
                Console.WriteLine("Congratulations, you won!");


                Console.WriteLine("What is your favorite school subject?");
                var favoriteSubject = Console.ReadLine();


                switch (favoriteSubject.ToLower())
                {
                    case "math":
                        Console.WriteLine("Your favorite subject is math!");
                        break;
                    case "english":
                        Console.WriteLine("Your favorite subject is english!");
                        break;
                    case "history":
                        Console.WriteLine("Your favorite subject is history!");
                        break;
                    case "science":
                        Console.WriteLine("Your favorite subject is science!");
                        break;
                    default:
                        Console.WriteLine("Please select from math, english, history, or science.");
                        break;


                }

            }
    }
}
