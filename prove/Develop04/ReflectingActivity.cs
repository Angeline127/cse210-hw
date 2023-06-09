using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;



class ReflectingActivity : Activity
{
   
    private static List<string> _prompts = new List<string> {
        "---Think of a time when you stood up for someone else.---",
        "---Think of a time when you did something really difficult.---",
        "---Think of a time when you helped someone in need.---",
        "---Think of a time when you did something truly selfless."
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        originalPrompts = new List<string>(_prompts);
        allPrompts = new List<string>(originalPrompts);
    }

    protected override void DisplayActivity()
    {
        ResetPrompts();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int remainingSeconds = _duration;

        while (DateTime.Now < endTime)
        {
            string randomPrompt = SelectRandomPrompt(allPrompts);
            if (randomPrompt == null) return;

            Console.WriteLine("\rQuestion: {0} ({1} seconds remaining)  ", randomPrompt, remainingSeconds);
            Thread.Sleep(1000);
            remainingSeconds--;
        }

        LogActivity();
    }
   
}