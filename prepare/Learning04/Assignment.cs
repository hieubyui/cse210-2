public class Assignment
{
    public string studentName { get; set; } 
    public string topic { get; set; } 


    public Assignment(string studentName, string topic){
        
    }
    public void GetSummary()
    {
        Console.WriteLine($"{studentName} - {topic}");
    }
}
