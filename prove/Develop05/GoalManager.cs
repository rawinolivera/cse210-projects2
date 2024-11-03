public class GoalManager
{
  private List<Goal> _goals = new List<Goal>();
  private int _score = 0;

  public void AddPoints(int points)
  {
    _score += points;
  }

  public void Start()
  {
    string option = "";
    Console.Clear();
    do
    {
      if (option == "1")
      {
        CreateGoal();
      }
      else if (option == "2")
      {
        ListGoalDetails();
      }
      else if (option == "3")
      {
        SaveGoals();
      }
      else if (option == "4")
      {
        LoadGoals();
      }
      else if (option == "5")
      {
        RecordEvent();
      }
      else if (option == "6")
      {
        Environment.Exit(0);
      }

      Console.WriteLine($"\n\nYou have {_score} points.\n");
      Console.WriteLine("Menu Options:");
      Console.WriteLine("  1. Create New Goal");
      Console.WriteLine("  2. List Goals");
      Console.WriteLine("  3. Save Goals");
      Console.WriteLine("  4. Load Goals");
      Console.WriteLine("  5. Record Events");
      Console.WriteLine("  6. Quit");
      Console.Write("Select a choice from the menu: ");
      option = Console.ReadLine();

    } while (option != "6");
  }

  public string DisplayPlayerInfo()
  {
    return $"You have {_score} points.";
  }

  public void ListGoalNames()
  {
    int indNum = 1;
    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($"  {indNum}. {_goals[i].GetName()}");
      indNum++;
    }
  }

  public void ListGoalDetails()
  {
    int indNum = 1;
    Console.WriteLine("The goals are:");
    for (int i = 0; i < _goals.Count; i++)
    {
      Console.WriteLine($" {indNum}- {_goals[i].GetDetailsString()}");
      indNum++;
    }
  }

  public void CreateGoal()
  {
    int typeGoal;
    Console.WriteLine("The types of Goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.WriteLine("Which type of goal would you like to create? ");
    typeGoal = int.Parse(Console.ReadLine());
    if (typeGoal == 1)
    {
      SimpleGoal simple = new SimpleGoal();
      Console.WriteLine("What is the name of your goal? ");
      simple.SetName(Console.ReadLine());
      Console.WriteLine("What is a short desription of it? ");
      simple.SetDescription(Console.ReadLine());
      Console.WriteLine("What is the amount of points associated with this goal? ");
      simple.SetPoints(int.Parse(Console.ReadLine()));
      _goals.Add(simple);
    }
    else if (typeGoal == 2)
    {
      EternalGoal eternal = new EternalGoal();
      Console.WriteLine("What is the name of your goal? ");
      eternal.SetName(Console.ReadLine());
      Console.WriteLine("What is a short desription of it? ");
      eternal.SetDescription(Console.ReadLine());
      Console.WriteLine("What is the amount of points associated with this goal? ");
      eternal.SetPoints(int.Parse(Console.ReadLine()));
      _goals.Add(eternal);
    }
    else if (typeGoal == 3)
    {
      ChecklistGoal checklist = new ChecklistGoal();
      Console.WriteLine("What is the name of your goal? ");
      checklist.SetName(Console.ReadLine());
      Console.WriteLine("What is a short desription of it? ");
      checklist.SetDescription(Console.ReadLine());
      Console.WriteLine("What is the amount of points associated with this goal? ");
      checklist.SetPoints(int.Parse(Console.ReadLine()));
      Console.WriteLine("How many times this goal need to be accomplished for a bonus? ");
      checklist.SetTarget(int.Parse(Console.ReadLine()));
      Console.WriteLine("What is the bonus por accomplishing it that many times? ");
      checklist.SetBonus(int.Parse(Console.ReadLine()));
      _goals.Add(checklist);
    }
  }

  public void RecordEvent()
  {
    ListGoalNames();
    Console.WriteLine("Which goal did you accomplish? ");
    int index = int.Parse(Console.ReadLine()) - 1;
    bool state = _goals[index].IsComplete(); //I added a validation that check is the goal is already completed or not!
    if (state == false)
    {
      _goals[index].RecordEvent();
      _score += _goals[index].GetPoints();
    }
    else
    {
      Console.WriteLine($"This {_goals[index].GetType().Name} was completed!\nYou can go ahead and try another or createa a new goal...");
    }

  }

  public void SaveGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      outputFile.WriteLine(_score);
      foreach (Goal goal in _goals)
      {
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadGoals()
  {
    Console.Write("What is the filename for the goal file? ");
    string fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);
    int size = lines.Length;
    string className;

    _score = int.Parse(lines[0]);
    for (int i = 1; i < size; i++)
    {
      string[] obj = lines[i].Split(":");
      className = obj[0];
      string[] data = obj[1].Split(",");
      if (className == "SimpleGoal")
      {
        SimpleGoal simple = new SimpleGoal();
        simple.SetName(data[0]);
        simple.SetDescription(data[1]);
        simple.SetPoints(int.Parse(data[2]));
        simple.SetIsComplete(bool.Parse(data[3]));
        _goals.Add(simple);
      }
      else if (className == "EternalGoal")
      {
        EternalGoal eternal = new EternalGoal();
        eternal.SetName(data[0]);
        eternal.SetDescription(data[1]);
        eternal.SetPoints(int.Parse(data[2]));
        _goals.Add(eternal);
      }
      else if (className == "ChecklistGoal")
      {
        ChecklistGoal checklist = new ChecklistGoal();
        checklist.SetName(data[0]);
        checklist.SetDescription(data[1]);
        checklist.SetPoints(int.Parse(data[2]));
        checklist.SetBonus(int.Parse(data[3]));
        checklist.SetTarget(int.Parse(data[4]));
        checklist.SetAmountCompleted(int.Parse(data[5]));
        _goals.Add(checklist);
      }
    }
  }

}