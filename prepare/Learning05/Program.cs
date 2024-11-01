using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle(5, "Blue");
        shapes.Add(circle);
        Rectangle rectangle = new Rectangle(5, 7, "Blue");
        shapes.Add(rectangle);
        Square square = new Square(5, "Blue");
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The Color of the shape is {color} and the area is {area}");
        }
    }
}