public class Entry
{
    public string EntryDate { get; set; }

    public string Prompt { get; set; }

    public string Response { get; set; }

    public int MyProperty { get; set; }
    public void DisplayPromptResponse()
    {
        Console.WriteLine($"({EntryDate}) {Prompt}\n{Response}");
    }

}    