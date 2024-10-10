public class Comment
{
  public string _personName;
  public string _commentText;

  public Comment(string name, string commentText)
  {
    _personName = name;
    _commentText = commentText;
  }
  public void ShowComment()
  {
    Console.WriteLine($" -> {_personName}: {_commentText}");
  }
}