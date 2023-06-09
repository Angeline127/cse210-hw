using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

abstract class Activity
{
     protected string _name;
    protected string _description;
    protected int _duration;
    protected static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    protected abstract void DisplayActivity();

    public void Start()
    {
        Console.WriteLine("Welcome to {0}!", _name);
        Console.WriteLine(_description);
       
       

        Console.Write("How long, in seconds, would you like your session to be? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        AnimateSpinner(3); // Animate spinner for 3 seconds

        Console.Clear();

        DisplayActivity();

        Console.WriteLine("\nWell done!");
        Console.WriteLine("You have completed {0} seconds of the {1}.", _duration, _name);

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        Console.Clear();
    }

    protected void AnimateSpinner(int seconds)
    {
        int counter = 0;
        int sleepTime = 100; // Milliseconds between spinner frames

        while (counter < seconds * 10)
        {
            Console.Write("\rLoading " + GetSpinnerFrame(counter % 4));
            counter++;
            Thread.Sleep(sleepTime);
        }

        Console.WriteLine();
    }

    private string GetSpinnerFrame(int frame)
    {
        switch (frame)
        {
            case 0:
                return "-";
            case 1:
                return "\\";
            case 2:
                return "|";
            case 3:
                return "/";
            default:
                return "-";
        }
    }

    protected string SelectRandomPrompt(List<string> prompts)
    {
        if (prompts.Count == 0)
        {
            Console.WriteLine("\nOops! We've run out of prompts. Please try again later.");
            return null;
        }

        Random random = new Random();
        int index = random.Next(0, prompts.Count);
        string prompt = prompts[index];
        prompts.RemoveAt(index);

        return prompt;
    }

    protected void CountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r{0}...", i);
            Thread.Sleep(1000);
        }
    }

    protected void AnimateLoading(int seconds)
    {
        int counter = 0;

        while (counter < seconds)
        {
            Console.Write("\rLoading" + new string('.', counter % 4));
            counter++;
            Thread.Sleep(500);
        }

        Console.WriteLine();
    }

    protected void LogActivity()
    {
        if (!_activityLog.ContainsKey(_name))
        {
            _activityLog.Add(_name, 1);
        }
        else
        {
            _activityLog[_name]++;
        }
    }

    public static void ResetPrompts()
    {
        usedPrompts.Clear();
        allPrompts = new List<string>(originalPrompts);
    }

    protected static HashSet<string> usedPrompts = new HashSet<string>();
    protected static List<string> allPrompts;
    protected static List<string> originalPrompts;

}