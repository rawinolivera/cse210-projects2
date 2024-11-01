public class ListingActivity : Activity
{
  private int _count = 0;
  private List<string> _prompts = new List<string>();
  private List<int> _promptPositions = new List<int>();

  public ListingActivity() : base()
  {
    _count = 0;
    _prompts = new List<string>();
  }

  public void SetActivityInfo()
  {
    _name = "Listing Activity";
    _description = "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.";
  }

  public void SetPromptsList()
  {
    _prompts.Add("Who are people that you appreciate?");
    _prompts.Add("What are personal strengths of yours?");
    _prompts.Add("Who are people that you have helped this week?");
    _prompts.Add("When have you felt the Holy Ghost this month?");
    _prompts.Add("Who are some of your personal heroes?");
  }

  public void Run()
  {
    SetActivityInfo();
    SetPromptsList();
    Console.Clear();
    DisplayStartingMessage();
    Console.Clear();
    Console.Write("Get Ready...");
    ShowSpinner(6);
    Console.WriteLine("\nList as many responses you can to the following prompt:");
    Console.Write(" --- ");
    DisplayPrompt();
    Console.Write(" --- \n\nYou may beging in: ");
    ShowCountDown(5);
    Console.WriteLine();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;
    string text = "";
    do
    {
      if (currentTime < futureTime)
      {
        Console.Write("> ");
        text = Console.ReadLine();
        if (text.Length > 0) //With this validation we count when the user type something instead of just hitting enter
        {
          _count++;
        }
        text = "";
        currentTime = DateTime.Now;
      }
    } while (currentTime < futureTime);
    DisplayTotalList();
    Console.WriteLine();
    DisplayEndingMessage();
  }

  public int GetRandomPrompt()
  {
    Random random = new Random();
    int index;

    do //with this validation we keep a record of the index already used so we do not repeat them
    {
      index = random.Next(_prompts.Count);
    } while (_promptPositions.Contains(index));

    _promptPositions.Add(index);
    return index;
  }

  public void DisplayPrompt()
  {
    Console.Write(_prompts[GetRandomPrompt()]);
  }

  public void DisplayTotalList()
  {
    Console.WriteLine($"You listed {_count} items!");
  }

}