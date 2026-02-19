public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string text)
    {
        _word = text;
        _hidden = false;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            string blanks = "";
            for (int i = 0; i < _word.Length; i++)
            {
                blanks += "_";
            }
            return blanks;
        }
        else
        {
            return _word;
        }
    }
}
