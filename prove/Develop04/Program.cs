using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        Console.Clear();
        do
        {
            if (option == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (option == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (option == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

        } while (option != "4");
    }
}