public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _status = false;

    }

    public SimpleGoal(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    public override void CreateChildGoal()
    {
        CreateBaseGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false) {
            _status = true;
        } else {
            Console.WriteLine("You have already completed this goal!");
        }
    }

    public override bool CompleteBool()
    {
        if (_status == true){
            return true;
        } else {
            return false;
        }
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
        Console.Write($"[{statusSymbol}] {_name} ({_description})");
    }

    public override int Calculate()
    {
        bool status = CompleteBool();
        int points = 0;
        if (status == true) {
            points = _goalPoints;
        } else {
            points = 0;
        }
        return points;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description}{_goalPoints},{CompleteBool().ToString()}";
        return line;
    }
}