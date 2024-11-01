public class Circle : Shape
{
  private double _radius;
  public Circle(double rad, string color) : base(color)
  {
    _radius = rad;
  }

  public override double GetArea()
  {
    double area = 3.14159 * (_radius * _radius);
    return area;
  }
}