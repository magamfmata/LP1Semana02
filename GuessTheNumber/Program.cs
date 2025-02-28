using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net;
using System.Threading;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);

            for (int a = 1 ;; a++);

            Console.WriteLine("Insert number:");

             {
                string numbertoguess, response;

                Console.Write("Insert number: ");
                numbertoguess = Console.ReadLine();

                int guessednumber = int.Parse(numberToGuess);

                if (guessednumber > 30 || guessednumber < 0)
                {
                    response = $"Numbers must be between 0 and 30. Try again.";
                    Console.WriteLine(response);
                    continue;
                }

                if (guessednumber > numberToGuess)
                {
                    response = $"The hidden number is lower than 
                    {guessednumber}. Try Again.";

                    Console.WriteLine(response);
                    continue;
                }
                if (guessednumber < numberToGuess)
                {
                    response = $"The hidden number is higher than {guessednumber}
                    . Try Again.";
                    Console.WriteLine(response);
                    continue;
                }

                if (guessednumber == numberToGuess)
                {
                    response = $"You found the hidden number {numberToGuess}
                     after {Count} tries.";
                     
                    Console.WriteLine(response);
                    break;
                }
            }
        }
    }
}






        
                


            
        }
    }
}
