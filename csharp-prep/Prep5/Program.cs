using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = UserName();
        int userNumber = FavNumber();
        int resultSquare = SquareNumber(userNumber);
        Result(userName, resultSquare);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int FavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int sqr = number * number;

        return sqr;
    }

    static void Result(string userName, int sqr)
    {
        Console.Write($"{userName}, the square of your number is {sqr}");
    }
}