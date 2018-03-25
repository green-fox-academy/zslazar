using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 10 lives. Guess my number between 1 and 100");
            int guessedNumber = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            int lifeCounter = 10;

            while ((lifeCounter > 0))
            {
                if (guessedNumber > number)
                {
                    lifeCounter--;
                    if (lifeCounter > 0)
                    {
                        Console.WriteLine("Too high, You have " + lifeCounter + " life left!");                
                    }
                    else
                    {
                        Console.WriteLine("You managed to die!");
                    }
                }
                else if (guessedNumber < number)
                {
                    lifeCounter--;
                    if (lifeCounter > 0)
                    {
                        Console.WriteLine("Too low, You have " + lifeCounter + " life left!");
                    }
                    else
                    {
                        Console.WriteLine("You managed to die!");
                    }                                                         
                }
                else
                {
                    lifeCounter = 0;
                    Console.WriteLine("Yes the number is: " + guessedNumber);
                    Console.ReadLine();
                }
                guessedNumber = int.Parse(Console.ReadLine());
            }
                        
            Console.ReadLine();
        }
    }
}
