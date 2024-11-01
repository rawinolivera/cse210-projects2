public class BreathingActivity : Activity
{
  public BreathingActivity() : base()
  {

  }

  public void SetActivityInfo()
  {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }
  public void Run()
  {
    SetActivityInfo();
    Console.Clear();
    DisplayStartingMessage();
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(6);
    Console.WriteLine();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = DateTime.Now;
    do
    {
      if (currentTime < futureTime)
      {
        Console.Write("Breathe in...");
        ShowCountDown(4);
        Console.Write("Breathe out...");
        ShowCountDown(6);
        Console.WriteLine();
        currentTime = DateTime.Now;
      }
    } while (currentTime < futureTime);
    DisplayEndingMessage();

  }
}