public class ChecklistGoal : Goal
{
  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public void SetAmountCompleted(int amount)
  {
    _amountCompleted = amount;
  }

  public int GetAmountCompleted()
  {
    return _amountCompleted;
  }

  public void SetTarget(int target)
  {
    _target = target;
  }

  public int GetTarget()
  {
    return _target;
  }

  public void SetBonus(int bonus)
  {
    _bonus = bonus;
  }

  public int GetBonus()
  {
    return _bonus;
  }

  public override void RecordEvent()
  {
    _amountCompleted++;
    int points = 0;
    if (IsComplete() == true)
    {
      points = _points + _bonus;
      Console.WriteLine($"Congratulatios! You have earned {points} points!");
    }
    else
    {
      points = _points;
      Console.WriteLine($"Congratulatios! You have earned {points} points!");
    }
  }

  public override int GetPoints()
  {
    if (IsComplete() == true)
    {
      return _points + _bonus;
    }
    else
    {
      return _points;
    }
  }

  public override bool IsComplete()
  {
    if (_target == _amountCompleted)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public override string GetDetailsString()
  {
    if (IsComplete() == true)
    {
      return $"[X] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    else
    {
      return $"[ ] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
  }

  public override string GetStringRepresentation()
  {
    string line = $"{GetType().Name}:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    return line;
  }


}