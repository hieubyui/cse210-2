public class Entry
{
    public string EntryDate { get; set; }

    public string Prompt { get; set; }

    public string Response { get; set; }

    public Entry(string prompt, string response, string date)
    {
        EntryDate = date;
        Prompt = prompt;
        Response = response;
    }

    public string GetPrompt()
    {
        return Prompt;
    }
    
    public string GetResponse()
    {
        return Response;
    }

    public string GetDate()
    {
        return EntryDate;
    }

    public override string ToString()
    {
        return $"({EntryDate}) - Q: {Prompt}Response: {Response}";
    }

}    