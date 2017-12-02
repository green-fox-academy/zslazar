using System;

namespace Exercise33GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int numberToGuess = 8;
            int userGuess = 0;

            while (numberToGuess != userGuess)
            {

                Console.WriteLine("Take a guess");
                userGuess = int.Parse(Console.ReadLine());


                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("The stored number is higher");

                }

                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("The stored number is lower");

                }

                else
                {
                    Console.WriteLine("You found the number: 8");

                }
            }


            Console.ReadLine();
        }
    }
}