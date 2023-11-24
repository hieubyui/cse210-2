public class Assignment
{
    public string studentName { get; set; } 
    public string topic { get; set; } 

    public void GetSummary()
    {
        Console.WriteLine($"{studentName} - ({topic}");
    }
}
