public class EternalGoal : Goal
{

  public override void RecordEvent()
  {
    Console.WriteLine($"Congratulatios! You have earned {_points} points!");
  }

  public override bool IsComplete()
  {
    return false;
  }

  public override string GetStringRepresentation()
  {
    string line = $"{GetType().Name}:{_shortName},{_description},{_points}";
    return line;
  }

}