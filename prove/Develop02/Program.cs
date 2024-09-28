using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int mark = 0;
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    journal.SetPromptList();
                    break;
                case 2:
                    journal.DisplayEntry();
                    break;
                case 3:
                    journal.LoadFile();
                    break;
                case 4:
                    journal.SaveJournal();
                    break;
                case 5:
                    mark = option;
                    break;
                default:
                    Console.WriteLine("Invalid Option! \n");
                    break;
            }
        } while (mark != 5);
    }
}