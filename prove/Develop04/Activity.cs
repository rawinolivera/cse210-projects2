using System.Transactions;

public class Activity
{
  protected string _name = "";
  protected string _description = "";
  protected int _duration = 0;

  public Activity()
  {
    _name = "";
    _description = "";
    _duration = 0;
  }


  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Welcome to the {_name} Activity!\n\n{_description}\n");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
  }

  public void DisplayEndingMessage()
  {
    Console.WriteLine("Good Job!!");
    ShowSpinner(3);
    Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity");
    ShowSpinner(5);
    Console.Clear();
  }

  public void ShowSpinner(int seconds)
  {
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(seconds);
    DateTime currentTime = DateTime.Now;
    do
    {
      if (currentTime < futureTime)
      {
        Console.Write("-");

        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the - character

        Console.Write("\\"); // Replace it with the \ character

        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the \ character
      }
      currentTime = DateTime.Now;
      if (currentTime < futureTime)
      {
        Console.Write("|");

        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the | character

        Console.Write("/"); // Replace it with the / character

        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the / character
      }
      currentTime = DateTime.Now;
    } while (currentTime < futureTime);

  }

  public void ShowCountDown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
    Console.WriteLine();
  }
}