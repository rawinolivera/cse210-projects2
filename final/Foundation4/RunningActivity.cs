public class RunningActivity : Activity
{
  public RunningActivity(float distance, string name, string date, int length) : base(name, date, length)
  {
    _distanceKm = distance;
  }
  private float _distanceKm;
  public float GetSpeed()
  {
    return _distanceKm / _lengthMin * 60;
  }

  public float GetPace()
  {
    return 60 / GetSpeed();
  }

  public override void Summary()
  {
    Console.WriteLine($"{_date} {_name} ({_lengthMin} min): Distance: {_distanceKm}, Speed: {GetSpeed()} Kph, Pace: {GetPace()} min per km");
  }
}