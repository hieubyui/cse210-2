using System;

class Program
{
    static void Main(string[] args)
    {

        string menu = "";

        GoalsTracker goals = new GoalsTracker();

    while (menu != "6") {
        
        int points = goals.GetTotalPoints();

        Console.WriteLine($"You have {points} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goal");
        Console.WriteLine(" 3. Save Goal");
        Console.WriteLine(" 4. Load Goal");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine("\nSelect a choice from the menu: ");

        menu = Console.ReadLine();

        switch (menu) {
            case "1":

                Console.WriteLine("The Types of Goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create?");
                string goalType = Console.ReadLine();

                switch (goalType) {
                    case "1":

                        SimpleGoal newSimpleGoal = new SimpleGoal();
                        newSimpleGoal.CreateChildGoal();
                        goals.addGoal(newSimpleGoal);
                        break;
                    
                    case "2":
                        EternalGoal newEternalGoal = new EternalGoal();
                        newEternalGoal.CreateChildGoal();
                        goals.addGoal(newEternalGoal);
                        break;

                    case "3":
                        ChecklistGoal newChecklistGoal = new ChecklistGoal();
                        newChecklistGoal.CreateChildGoal();
                        goals.addGoal(newChecklistGoal);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                break;

            case "2":
                goals.ListGoal();
                break;

            case "3":
                goals.SaveGoals();
                break;
            
            case "4":
                goals.LoadGoals();
                break;
            
            case "5":
                goals.RecordEventInTracker();
                break;
            
            case "6":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid input. Please try again.");
                break;
            }
        }
    }
}