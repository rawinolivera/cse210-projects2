using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int percGrade = int.Parse(Console.ReadLine());
        string letterGrade, message;

        if (percGrade >= 90)
        {
            if ((percGrade % 10) > 3)
            {
                letterGrade = "A";
            }
            else
            {
                letterGrade = "A-";
            }
        }
        else if (percGrade >= 80)
        {
            if ((percGrade % 10) >= 7)
            {
                letterGrade = "B+";
            }
            else if ((percGrade % 10) < 3)
            {
                letterGrade = "B-";
            }
            else
            {
                letterGrade = "B";
            }

        }
        else if (percGrade >= 70)
        {
            if ((percGrade % 10) >= 7)
            {
                letterGrade = "C+";
            }
            else if ((percGrade % 10) < 3)
            {
                letterGrade = "C-";
            }
            else
            {
                letterGrade = "C";
            }
        }
        else if (percGrade >= 60)
        {
            if ((percGrade % 10) >= 7)
            {
                letterGrade = "D+";
            }
            else if ((percGrade % 10) < 3)
            {
                letterGrade = "D-";
            }
            else
            {
                letterGrade = "D";
            }
        }
        else
        {
            letterGrade = "E";
        }

        //Setting the message for the user!
        if (percGrade >= 70)
        {
            message = "Congratulations!! You passed the class!!";
        }
        else
        {
            message = "Sorry, you failed the class!";
        }

        Console.Write($"Your grade is: {letterGrade}\n {message}");
    }
}