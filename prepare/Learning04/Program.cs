using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ryan D. Olivera", "SOLID Principles");
        MathAssignment mathAssignment = new MathAssignment("Rawin Olivera", "Encapsulation", "C8", "46-54");
        WritingAssignment writingAssignment = new WritingAssignment("Rawin Olivera", "Love Letter", "Life of Mine");
        Console.WriteLine(assignment.GetSummary() + "\n");
        Console.WriteLine(mathAssignment.GetSummary() + "\n" + mathAssignment.GetHomeworkList() + "\n");
        Console.WriteLine(writingAssignment.GetSummary() + "\n" + writingAssignment.GetWritingInformation() + "\n");
    }
}