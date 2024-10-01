using System.Diagnostics;

public class Fraction
{
  private int _topNumber;
  private int _bottomNum;

  public Fraction()
  {
    _topNumber = 1;
    _bottomNum = 1;
  }

  public Fraction(int top)
  {
    _topNumber = top;
    _bottomNum = 1;
  }

  public Fraction(int top, int bottom)
  {
    _topNumber = top;
    _bottomNum = bottom;
  }

  public int GetToppy()
  {
    return _topNumber;
  }

  public int GetBottom()
  {
    return _bottomNum;
  }

  public void SetToppy(int top)
  {
    _topNumber = top;
  }

  public void SetBottom(int bottom)
  {
    _bottomNum = bottom;
  }

  public string GetFractionString()
  {
    string toppy = _topNumber.ToString();
    string bottom = _bottomNum.ToString();
    return toppy + "/" + bottom;
  }

  public double GetDecimalValue()
  {
    double value = Convert.ToDouble(_topNumber) / Convert.ToDouble(_bottomNum);
    return value;
  }
}