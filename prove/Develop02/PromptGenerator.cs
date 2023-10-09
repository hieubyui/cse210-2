public class PromptGenerator
{
    Random rnd = new Random();


    public Prompt()
    {
        int prompt = rnd.Next(prompts.Count);
    }
}