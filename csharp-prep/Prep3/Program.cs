using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guesNumber = 9999;

        while (guesNumber != magicNumber)
        {
            Console.WriteLine("What is your guest? ");
            guesNumber = int.Parse(Console.ReadLine());
            if (guesNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guesNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}