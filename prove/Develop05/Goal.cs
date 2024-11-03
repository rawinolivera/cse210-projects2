using System.Data.SqlTypes;
using System.Dynamic;

public abstract class Goal
{
  protected string _shortName = "";
  protected string _description = "";
  protected int _points = 0;

  public Goal()
  {
    _shortName = "";
    _description = "";
    _points = 0;
  }

  public void SetName(string name)
  {
    _shortName = name;
  }

  public string GetName()
  {
    return _shortName;
  }

  public void SetDescription(string desc)
  {
    _description = desc;
  }

  public string GetDescription()
  {
    return _description;
  }

  public void SetPoints(int points)
  {
    _points = points;
  }

  public virtual int GetPoints()
  {
    return _points;
  }

  public abstract void RecordEvent();

  public abstract bool IsComplete();

  public virtual string GetDetailsString()
  {
    if (IsComplete() == true)
    {
      return $"[X] {_shortName} ({_description})";
    }
    else
    {
      return $"[ ] {_shortName} ({_description})";
    }
  }

  public abstract string GetStringRepresentation();
}