public class Scripture
{
    private List<Word> Word { get; set; }

    public Scripture(string text)
    {
        Word = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            Word.Add(new Word(word));
        }

    }

    public void Display()
        {
            foreach (Word word in Word)
            {
                if (word.IsHidden())
                {
                    Console.Write(new string('_', word.GetText().Length) + " ");
                }
                else
                {
                    Console.Write(word.GetText() + " ");
                }
            }
        }

    public bool HideRandomWord()
    {
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count < 2)
            return false;

        Random random = new Random();
        int randomIndex1 = random.Next(visibleWords.Count);
        int randomIndex2;

        do
        {
            randomIndex2 = random.Next(visibleWords.Count);
        }
        
        while (randomIndex1== randomIndex2);

        visibleWords[randomIndex1].Hide();
        return true;
    }

    private List<Word> GetVisibleWords()
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in Word)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }
        return visibleWords;
    }
}