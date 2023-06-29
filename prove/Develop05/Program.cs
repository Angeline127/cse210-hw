using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int score = 0;

    static void Main()
    {
        MainMenu();
    }

    private static void MainMenu()
    {
        while (true)
        {
            Console.WriteLine($"You have {score} points\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }
        }
    }

    private static void CreateGoal()
    {
        if (goals.Count > 0 && !goals[goals.Count - 1].IsCompleted)
        {
            Console.WriteLine("You must achieve or record the previous goal before creating a new one.\n");
            return;
        }

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("7. Achievement Goal");

        Console.Write("Which type of goal would you like to create? ");
        string goalTypeChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalTypeChoice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());

                goals.Add(new ChecklistGoal(name, description, points, 0, targetCount));
                break;
            case "7":
                goals.Add(new AchievementGoal(name, description));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal creation failed.");
                return;
        }

        Console.WriteLine("Goal created successfully.\n");
    }

    private static void ListGoals()
    {
        Console.WriteLine("The goals are:\n");

        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.GetProgress());
        }

        Console.WriteLine();
    }

    private static void SaveGoals()
    {
        Console.Write("Enter the file name to save the goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Goals:");

            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetFormattedGoal());
            }

            writer.WriteLine("Score: " + score);
        }

        Console.WriteLine("Goals saved successfully.\n");
    }

    private static void LoadGoals()
    {
        Console.Write("Enter the file name to load the goals from: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist. Load failed.\n");
            return;
        }

        goals.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();

            if (line != "Goals:")
            {
                Console.WriteLine("Invalid file format. Load failed.\n");
                return;
            }

            while ((line = reader.ReadLine()) != null && line != "Score: ")
            {
                string goalType = line.Split(' ')[1];

                switch (goalType)
                {
                    case "SimpleGoal":
                        ParseSimpleGoal(reader);
                        break;
                    case "EternalGoal":
                        ParseEternalGoal(reader);
                        break;
                    case "ChecklistGoal":
                        ParseChecklistGoal(reader);
                        break;
                    case "AchievementGoal":
                        ParseAchievementGoal(reader);
                        break;
                    default:
                        Console.WriteLine("Invalid goal type in the file. Load failed.\n");
                        return;
                }
            }

            if (line == "Score: ")
            {
                line = reader.ReadLine();
                score = int.Parse(line);
            }
        }

        Console.WriteLine("Goals loaded successfully.\n");
    }

    private static void ParseSimpleGoal(StreamReader reader)
    {
        string line = reader.ReadLine(); // Read "name: ..."
        string name = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "description: ..."
        string description = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "points: ..."
        int points = int.Parse(line.Substring(line.IndexOf(":") + 1).Trim());

        line = reader.ReadLine(); // Read "status: ..."
        bool isCompleted = line.Substring(line.IndexOf(":") + 1).Trim() == "Completed";

        SimpleGoal goal = new SimpleGoal(name, description, points);
        goal.SetCompleted(isCompleted);
        goals.Add(goal);
    }

    private static void ParseEternalGoal(StreamReader reader)
    {
        string line = reader.ReadLine(); // Read "name: ..."
        string name = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "description: ..."
        string description = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "points: ..."
        int points = int.Parse(line.Substring(line.IndexOf(":") + 1).Trim());

        EternalGoal goal = new EternalGoal(name, description, points);
        goals.Add(goal);
    }

    private static void ParseChecklistGoal(StreamReader reader)
    {
        string line = reader.ReadLine(); // Read "name: ..."
        string name = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "description: ..."
        string description = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "points: ..."
        int points = int.Parse(line.Substring(line.IndexOf(":") + 1).Trim());

        line = reader.ReadLine(); // Read "bonus point: ..."
        int bonusPoint = int.Parse(line.Substring(line.IndexOf(":") + 1).Trim());

        line = reader.ReadLine(); // Read "time: ..."
        string time = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "status: ..."
        bool isCompleted = line.Substring(line.IndexOf(":") + 1).Trim() == "Completed";

        ChecklistGoal goal = new ChecklistGoal(name, description, points, bonusPoint, time);
        goal.SetCompleted(isCompleted);
        goals.Add(goal);
    }

    private static void ParseAchievementGoal(StreamReader reader)
    {
        string line = reader.ReadLine(); // Read "name: ..."
        string name = line.Substring(line.IndexOf(":") + 1).Trim();

        line = reader.ReadLine(); // Read "description: ..."
        string description = line.Substring(line.IndexOf(":") + 1).Trim();

        AchievementGoal goal = new AchievementGoal(name, description);
        goals.Add(goal);
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event for:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetProgress()}");
        }

        Console.Write("Enter the goal number: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number.\n");
            return;
        }

        Goal goal = goals[goalNumber - 1];

        if (goal.IsCompleted)
        {
            Console.WriteLine("Goal has already been completed.\n");
            return;
        }

        int pointsEarned = goal.RecordEvent();
        score += pointsEarned;

        Console.WriteLine($"Event recorded! You earned {pointsEarned} points.\n");

        if (goal.IsCompleted)
        {
            Console.WriteLine("Congratulations! You have completed a goal.\n");
        }
    }
}
