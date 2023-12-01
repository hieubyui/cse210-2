using System;
using System.IO;

public class GoalsTracker
{
    private List<Goal> _goals = new List<Goal>();

    private int _totalPoints = 0;

    public int GetTotalPoints() {

        int points = _totalPoints;
        return points;

    }
    public void SaveGoals()
    {
        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int total = GetTotalPoints();
            outputFile.WriteLine(total.ToString());
            
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear(); 

        string fileName = "";
        Console.Write("What is the filename? ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++ )
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal") {

                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(simpleGoal);             

            } else if (parts[0] == "EternalGoal") {

                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], Convert.ToInt32(parts[3]));
                _goals.Add(eternalGoal);

            } else if (parts[0] == "ChecklistGoal") {
                
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(checklistGoal);

            }
        }

    }
        public void RecordEventInTracker()
    {
        string goalIndex = "";
        Console.Write("Which goal did you accomplish? ");
        goalIndex = Console.ReadLine();
        int goalIndexInt = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexInt].CompleteBool() == false) {

            _goals[goalIndexInt].RecordEvent();

            int pointsEarned = _goals[goalIndexInt].Calculate();

            _totalPoints += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned.ToString()} points!");
            Console.WriteLine($"You now have {_totalPoints} points.");

        } else {

            Console.WriteLine("You have already completed this goal.");

        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count(); i++) {
            Console.Write($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    public void addGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int Calculate()
    {
        int total = _totalPoints;
        foreach(Goal goal in _goals) {
            total += goal.Calculate();
        }

        _totalPoints = total;

        return total;
    }


}