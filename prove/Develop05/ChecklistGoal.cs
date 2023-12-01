using System;

public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _steps;
    private int _stepCounter;

    public ChecklistGoal()
    {

    }

    public ChecklistGoal(string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _stepCounter = stepCounter;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();

        Console.Write("# of times this goal needs to accomplish for bonus points: ");
        string stringChecklistSteps = Console.ReadLine();
        _steps = Convert.ToInt32(stringChecklistSteps);

        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        _stepCounter = 0;

    }

    public override bool CompleteBool() 
    {
        if (_stepCounter >= _steps) {
            return true;
        } else {
            return false;
        }
    }
    
    public override void RecordEvent()
    {
        _stepCounter ++;
    }

    public override int Calculate()
    {
        int points = 0;

        points = _stepCounter * _goalPoints;

        bool status = CompleteBool();

        if (status == true) {
            points += _bonusPoints;
        }

        return points;

    }

    public override void ListGoal()
    {
        string statusSymbol = "";
        bool status = CompleteBool();
        if (status == true) {
            statusSymbol = "X";
        } else {
            statusSymbol = " ";
        }

        Console.Write($"[{statusSymbol}] {_name} ({_description})\n Currently Completed {_stepCounter}/{_steps}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal:" + _name + "," + _description + "," + _goalPoints.ToString() + "," + _bonusPoints.ToString() + "," + _steps.ToString() + "," + _stepCounter.ToString();
        return line;
    }

}