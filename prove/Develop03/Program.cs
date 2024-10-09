using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.Write("Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter #: ");
        int chapter = int.Parse(Console.ReadLine());
        Console.Write("Initial Verse #: ");
        int verse = int.Parse(Console.ReadLine());
        Console.Write("Your scripture have more than 1 verse? (y/n): ");
        string response = Console.ReadLine();
        int lastVerse;
        if (response == "y")
        {
            Console.Write("Last Verse #: ");
            lastVerse = int.Parse(Console.ReadLine());
        }
        else if (response == "n")
        {
            Console.WriteLine("One verse reference received.");
            lastVerse = 0;
        }
        else
        {
            Console.WriteLine("Invalid Option! One verse reference received.");
            lastVerse = 0;
        }
        Reference ref1 = new Reference(book, chapter, verse, lastVerse);
        Scripture script1 = new Scripture(ref1);
        Console.Write("Scripture text: ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ');
        int size = words.Length;

        for (int i = 0; i < size; i++)
        {
            text = words[i];
            Word word = new Word(text);
            script1.SetList(word);
        }
        Console.Clear();
        Console.WriteLine(script1.GetDisplayText());

        string exit = "";
        while (exit != "quit")
        {
            Console.WriteLine();
            Console.Write("Press enter to continuo or type 'quit' to finish: ");
            exit = Console.ReadLine();
            Console.Clear();
            if (script1.IsCompletelyHidden() == true)
            {
                Environment.Exit(0);
            }
            else
            {
                script1.HideRandomWords();
                Console.WriteLine(script1.GetDisplayText());

            }


        }
    }
}