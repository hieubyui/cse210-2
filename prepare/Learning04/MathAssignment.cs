public class MathAssignment : Assignment
{
    public string textbookSection { get; set; } 
    public string problems { get; set; } 
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            
        }
    public void GetHomeworkList()
    {
        Console.WriteLine($"{studentName} - {topic}, {textbookSection}: {problems}");
    }
}