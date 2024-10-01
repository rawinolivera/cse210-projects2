using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);
        /*
                f1.SetToppy(4);
                f1.SetBottom(5);

                f2.SetToppy(8);
                f2.SetBottom(9);

                f3.SetToppy(10);
                f3.SetBottom(20);

                f4.SetToppy(10);
                f4.SetBottom(20);
        */
        Console.WriteLine($"{f1.GetToppy()}/{f1.GetBottom()}");
        Console.WriteLine($"{f2.GetToppy()}/{f2.GetBottom()}");
        Console.WriteLine($"{f3.GetToppy()}/{f3.GetBottom()}");
        Console.WriteLine($"{f4.GetToppy()}/{f4.GetBottom()}");
        Console.WriteLine();
        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue():F2}");
        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue():F2}");
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue():F2}");
        Console.WriteLine($"{f4.GetFractionString()}");
        Console.WriteLine($"{f4.GetDecimalValue():F2}");

    }
}