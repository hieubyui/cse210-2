using System.Runtime.CompilerServices;

public class Job 
{
    public string CompanyName { get; set; } 
    public string JobTitle { get; set; }    
    public int StartYear { get; set; }  
    public int EndYear { get; set; }    

    public void DisplayCompanyDetails()
    {
        Console.WriteLine($"{JobTitle} ({CompanyName})  {StartYear}-{EndYear}");
    }
}