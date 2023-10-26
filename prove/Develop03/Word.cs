public class Word
{      
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public string GetText()
    {
        return text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}
