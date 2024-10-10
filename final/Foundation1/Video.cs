using System.Reflection;
using System.Runtime.InteropServices.Marshalling;

public class Video
{
  public string videoTittle;
  public string videoAuthor;
  public int lengthInSeconds;
  public List<Comment> comments;

  public Video(string tittle, string author, int seconds)
  {
    videoTittle = tittle;
    videoAuthor = author;
    lengthInSeconds = seconds;

    comments = new List<Comment>();
  }

  public void SetListAddComment(string name, string commentText)
  {
    Comment comment = new Comment(name, commentText);
    comments.Add(comment);
  }

  public int CountComments()
  {
    int total = comments.Count;
    return total;
  }

  public void DisplayVideo()
  {
    Console.WriteLine($"{videoTittle}, {videoAuthor}, {lengthInSeconds} Seconds, " + CountComments() + " comments");
    foreach (Comment comment in comments)
    {
      comment.ShowComment();
    }
  }
}