using System.Security.Cryptography.X509Certificates;

public class Word
{
  private bool _isHidden;
  private string _text;

  public Word(string text)
  {
    _text = text;
    _isHidden = false;
  }

  public void Hide()
  {
    _isHidden = true;
  }

  public void Show()
  {
    int size = _text.Length;
    _text = "";
    for (int i = 0; i < size; i++)
    {
      _text += "-";
    }
  }

  public string GetDisplayText()
  {
    return _text;
  }

  public bool IsHidden()
  {
    return _isHidden;
  }

}