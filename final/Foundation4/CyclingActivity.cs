public class CyclingActivity : Activity
{
  private float _speedKmPerHour;

  public CyclingActivity(float speed, string name, string date, int length) : base(name, date, length)
  {
    _speedKmPerHour = speed;
  }
  public float GetDistance()
  {
    float lengthHrs = _lengthMin * 60;
    return _speedKmPerHour * lengthHrs;
  }

  public float GetPace()
  {
    return 60 / _speedKmPerHour;
  }

  public override void Summary()
  {
    Console.WriteLine($"{_date} {_name} ({_lengthMin} min): Distance: {GetDistance()}, Speed: {_speedKmPerHour} Kph, Pace: {GetPace()} min per km");
  }

}