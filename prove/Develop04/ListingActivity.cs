using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;



class ListingActivity : Activity
{
   
   private static List<string> _prompts = new List<string> {
        "---Who are people that you appreciate?---",
        "---What are personal strengths of yours?---",
        "---Who are people that you have helped this week?---",
        "---When have you felt the Holy Ghost this month?---",
        "---Who are some of your personal heroes?---"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        originalPrompts = new List<string>(_prompts);
        allPrompts = new List<string>(originalPrompts);
    }

    protected override void DisplayActivity()
    {
        ResetPrompts();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int remainingSeconds = _duration;
        int responseCount = 0;

        while (DateTime.Now < endTime)
        {
            string randomPrompt = SelectRandomPrompt(allPrompts);
            if (randomPrompt == null) return;

            Console.WriteLine("\rPrompt: {0} ({1} seconds remaining)  ", randomPrompt, remainingSeconds);
            Console.Write("Your response: ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responseCount++;
            }
            remainingSeconds--;
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!");
        Console.WriteLine("You listed {0} items.", responseCount);

        LogActivity();
    }
}
