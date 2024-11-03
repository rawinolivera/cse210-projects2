public class SwimmingActivity : Activity
{
  private int _numberLaps;

  public SwimmingActivity(int laps, string name, string date, int length) : base(name, date, length)
  {
    _numberLaps = laps;
  }
  public float GetDistance()
  {
    return _numberLaps * 50;
  }

  public float GetSpeed()
  {
    return GetDistance() / _lengthMin * 60;
  }

  public float GetPace()
  {
    return 60 / GetSpeed();
  }

  public override void Summary()
  {
    Console.WriteLine($"{_date} {_name} ({_lengthMin} min): Distance: {GetDistance()}, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km");
  }

}