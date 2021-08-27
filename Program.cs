using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Can you guess the secret number?");
            Console.WriteLine("Take a guess?");
            var numberGuess = Console.ReadLine();
            int secretNumber = 42;
            Console.WriteLine($"Your guess is {numberGuess}");
            Console.WriteLine($"The number is {secretNumber}");



            // if (secretNumber == numberGuess)
            // {
            //     Console.WriteLine("You guessed right!");
            // }
            // else if (secretNumber > numberGuess)
            // {
            //     Console.WriteLine("Wrong! Go lower.");
            // }
            // else 
            // {
            //     Console.WriteLine("Wrong! Go Higher.");
            // }

            // upper code is what I'm planning on using
            // lower code is what I tried to use previously but it didn't work

            // Program random = new Program();

            // int returnValue random.Next(1, 100);

            // int numberGuess = 0;

            // Console.WriteLine("Can you guess the secret number?");

            // while (numberGuess != returnValue)
            // {
            //     numberGuess = Convert.ToInt32(Console.Read());

            //     if (numberGuess < returnValue)
            //     {
            //         Console.WriteLine("Sorry, you guessed" + numberGuess + "and that's not the number!");
            //     }
            //     else if (numberGuess > returnValue)
            //     {
            //         Console.WriteLine("That's right, the number was" + numberGuess + "and you guessed it!");
            //     }
            // }

            // Console.WriteLine("The secret number is: " + numberGuess);
            // Console.ReadLine();
        }
    }
}