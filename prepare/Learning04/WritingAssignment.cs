public class WritingAssignment : Assignment
{
  private string _tittle = "";

  public WritingAssignment(string name, string topic, string tittle) : base(name, topic)
  {
    _tittle = tittle;
  }

  public string GetWritingInformation()
  {
    return $"Tittle: {_tittle}";
  }
}