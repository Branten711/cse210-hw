public class Word
{
    private string _text;
    private bool _isHidden = false;
    public Word ( string text)
    {
        _text = text;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public string GetWordText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    public bool IsHidden()
    {
        return _isHidden; //this changes the bool to true.
    }
}