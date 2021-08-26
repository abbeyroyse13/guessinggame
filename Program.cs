using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program random = new Program();

            int returnValue random.Next(1, 100);

            int numberGuess = 0;

            Console.WriteLine("Can you guess the secret number?");

            while (numberGuess != returnValue)
            {
                numberGuess = Convert.ToInt32(Console.Read());

                if (numberGuess < returnValue)
                {
                    Console.WriteLine("Sorry, you guessed" + numberGuess + "and that's not the number!");
                }
                else if (numberGuess > returnValue)
                {
                    Console.WriteLine("That's right, the number was" + numberGuess + "and you guessed it!");
                }
            }

            Console.WriteLine("The secret number is: " + numberGuess);
            Console.ReadLine();
        }
    }
}