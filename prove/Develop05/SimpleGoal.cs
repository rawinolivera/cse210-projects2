public class SimpleGoal : Goal
{
  private bool _isComplete;

  public override void RecordEvent()
  {
    _isComplete = true;
    Console.WriteLine($"Congratulatios! You have earned {_points} points!");
  }

  public void SetIsComplete(bool value)
  {
    _isComplete = value;
  }

  public override bool IsComplete()
  {
    if (_isComplete == true)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public override string GetStringRepresentation()
  {
    string line = $"{GetType().Name}:{_shortName},{_description},{_points},{IsComplete()}";
    return line;
  }
}