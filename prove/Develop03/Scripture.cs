using System.Diagnostics.Contracts;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;
  private List<int> positionToIgnore = new List<int>();

  public Scripture(Reference reference)
  {
    _reference = reference;
    _words = new List<Word>();
  }

  public void SetList(Word word)
  {
    _words.Add(word);
  }

  public string GetDisplayText()
  {
    string text = _reference.GetDisplayText();
    foreach (Word w in _words)
    {
      text += " " + w.GetDisplayText();
    }
    return text;
  }

  public bool IsCompletelyHidden()
  {
    foreach (Word word in _words)
    {
      if (!word.IsHidden())
      {
        return false;
      }
    }
    return true;

  }

  public void HideRandomWords()
  {
    Random random = new Random();
    int index;

    do
    {
      index = random.Next(_words.Count);
    } while (positionToIgnore.Contains(index));

    _words[index].Hide();
    _words[index].Show();
    positionToIgnore.Add(index);

  }
}