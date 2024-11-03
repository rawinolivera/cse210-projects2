public class Activity
{
  protected string _name;
  protected string _date;
  protected int _lengthMin;

  public Activity(string name, string date, int length)
  {
    _name = name;
    _date = date;
    _lengthMin = length;
  }
  public void SetName(string name)
  {
    _name = name;
  }

  public string GetName()
  {
    return _name;
  }

  public void SetDate(string date)
  {
    _date = date;
  }

  public string GetDate()
  {
    return _date;
  }

  public void SetLengthMin(int min)
  {
    _lengthMin = min;
  }

  public int GetLengthMin()
  {
    return _lengthMin;
  }

  public virtual void Summary()
  {
    Console.WriteLine($"{_date} {_name} ({_lengthMin}): ");
  }
}