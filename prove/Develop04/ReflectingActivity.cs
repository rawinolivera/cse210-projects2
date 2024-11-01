public class ReflectingActivity : Activity
{
  private List<string> _prompts = new List<string>();
  private List<string> _questions = new List<string>();
  private List<int> _promptPositions = new List<int>();
  private List<int> _promptQuestions = new List<int>();

  public ReflectingActivity() : base()
  {
    _prompts = new List<string>();
    _questions = new List<string>();
  }

  public void SetActivityInfo()
  {
    _name = "Reflecting Activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
  }

  public void SetPromptsList()
  {
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");
  }

  public void SetQuestionsList()
  {
    _questions.Add("Why was this experience meaningful to you?");
    _questions.Add("Have you ever done anything like this before?");
    _questions.Add("How did you get started?");
    _questions.Add("How did you feel when it was complete?");
    _questions.Add("What made this time different than other times when you were not as successful?");
    _questions.Add("What is your favorite thing about this experience?");
    _questions.Add("What could you learn from this experience that applies to other situations?");
    _questions.Add("What did you learn about yourself through this experience?");
    _questions.Add("How can you keep this experience in mind in the future?");
  }

  public void Run()
  {
    SetActivityInfo();
    SetPromptsList();
    SetQuestionsList();
    Console.Clear();
    DisplayStartingMessage();
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(6);
    Console.WriteLine();
    GetRandomPrompt();
    Console.WriteLine("Consider the following prompt:\n");
    Console.Write(" --- ");
    DisplayPrompt();
    Console.Write(" --- \n\nWhen you have something in mine, press enter to conitnue. ");
    Console.ReadLine();
    Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;
    do
    {
      if (currentTime < futureTime)
      {
        GetRandomQuestion();
        DisplayQuestion();
        ShowSpinner(15);
        Console.WriteLine();
        currentTime = DateTime.Now;
      }
    } while (currentTime < futureTime);
    Console.WriteLine();
    DisplayEndingMessage();
  }

  public int GetRandomPrompt()
  {
    Random random = new Random();
    int index;

    do
    {
      index = random.Next(_prompts.Count);
    } while (_promptPositions.Contains(index));

    _promptPositions.Add(index);
    return index;
  }

  public int GetRandomQuestion()
  {
    Random random = new Random();
    int index;

    do
    {
      index = random.Next(_questions.Count);
    } while (_promptQuestions.Contains(index));

    _promptQuestions.Add(index);
    return index;
  }

  public void DisplayPrompt()
  {
    Console.Write(_prompts[GetRandomPrompt()]);
  }

  public void DisplayQuestion()
  {
    Console.Write($"> {_questions[GetRandomQuestion()]} ");
  }
}