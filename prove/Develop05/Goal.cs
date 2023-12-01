using System.Diagnostics.Contracts;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;

    public Goal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    protected void CreateBaseGoal()
    {
        Console.Write("What is the name of your goal?");
        _name = Console.ReadLine();

        Console.Write("Write a short description: \n");
        _description = Console.ReadLine();

        Console.Write("How many points should this goal have?");
        string inputGoalPoints = (Console.ReadLine());
        _goalPoints = Convert.ToInt32(inputGoalPoints);

        _status = false;

    }

    public virtual string SaveGoal()
    {
        string a = "";
        return a;
    }
    public virtual void CreateChildGoal()
    {
        
    }
    public virtual void RecordEvent()
    {

    }
    public virtual void ListGoal()
    {
        
    }
    public virtual int Calculate()
    {
        return 0;
    }
    public virtual bool CompleteBool()
    {
        return false;
    }
}