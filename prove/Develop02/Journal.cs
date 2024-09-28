using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void DisplayEntry()
  {
    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }

  public void SetPromptList()
  {
    List<string> qPrompts = new List<string>();
    qPrompts.Add("Which of your plans for today have been completed?");
    qPrompts.Add("What did you do today for fun?");
    qPrompts.Add("What has made this day different?");
    qPrompts.Add("Have you learned something new today?");
    qPrompts.Add("Are you worried about something that needs your attention?");
    qPrompts.Add("There is something from today you don't want to forget?");

    //picking a random list number
    Random random = new Random();
    int totalList = qPrompts.Count;
    int indexList = random.Next(totalList);

    //Display the prompt and catch the response
    Console.WriteLine(qPrompts[indexList]);
    string response = Console.ReadLine();

    //Catch the currentdate
    DateOnly date = DateOnly.FromDateTime(DateTime.Now);
    string strDate = date.ToString();

    //Add the entry to the Journal List
    Entry entry = new Entry();
    entry._date = strDate;
    entry._prompt = qPrompts[indexList];
    entry._response = response;
    _entries.Add(entry);
  }

  public void SaveJournal()
  {
    Console.Write("Name of the file: ");
    string fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine(entry._date);
        outputFile.WriteLine(entry._prompt);
        outputFile.WriteLine(entry._response);
      }
      Console.WriteLine($"Your Jornal is saved as {fileName}");
    }
  }

  public void LoadFile()
  {
    Console.Write("File name: ");
    string fileName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);
    int side = lines.Length;
    side = side - 1;

    int i = 0;
    int j = 1;
    int k = 2;
    for (int f = 0; f <= side; f = f + 3)
    {

      Entry entry = new Entry();
      //getting different positions from the array
      entry._date = lines[i];   //0, 3
      entry._prompt = lines[j];  //1,4
      entry._response = lines[k];   //2,5
                                    //incrementing the indexes
      i = i + 3;
      j = j + 3;
      k = k + 3;
      _entries.Add(entry);
    }
    Console.WriteLine("Journal Loaded!!");
  }
}