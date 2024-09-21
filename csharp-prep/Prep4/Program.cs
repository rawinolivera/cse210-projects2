using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 9999;
        int count = -1;
        int sum = 0;
        double average;
        int largest = -9999;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);

            count++;
            sum += number;
            if (largest < number)
            {
                largest = number;
            }
        }

        average = ((float)sum) / count;

        Console.WriteLine($"The sum is {sum}\n The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        Console.WriteLine("The Sort List is:");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}