public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {        
        "Think of a time where you felt happy.",
        "Think of a situation when you faced a difficult task.",
        "Think of a moment when you extended help to someone in need.",
        "Think of a recent experiences have challenged your perspectives and prompted personal growth?",
        "Think of a moment when you successfully navigated a difficult situation and what you learned from it?",
        "Think of an occasion when you overcame a major obstacle through perseverance.", 
        "How have your priorities and values evolved over the past year?",
        "Reflect on a time when you collaborated with others to achieve a common goal—what insights did you gain from the collaboration?",
    };
    private List<string> _questions = new List<string> {
        "In what ways have you demonstrated adaptability and resilience in the face of unexpected challenges?",
        "Consider a recent accomplishment—what skills or strengths did you leverage to achieve it?",
        "Reflect on a specific interaction with someone who holds a different viewpoint—how did it impact your understanding and communication skills?",
        "Can you recall a recent experience that inspired you to seek new knowledge or skills?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {   
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.Write(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}