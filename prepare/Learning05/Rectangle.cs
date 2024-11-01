public class Rectangle : Shape
{
  private double _length;
  private double _width;
  public Rectangle(double len, double wid, string color) : base(color)
  {
    _length = len;
    _width = wid;
  }

  public override double GetArea()
  {
    double area = _length * _width;
    return area;
  }
}