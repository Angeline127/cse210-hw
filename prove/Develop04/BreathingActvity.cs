using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;




class BreathingActivity : Activity
{
   
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void DisplayActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int remainingSeconds = _duration;

        while (DateTime.Now < endTime)
        {
            Console.Write("\rBreathe out... {0}  ", remainingSeconds);
            Thread.Sleep(1000);
            Console.Write("\rBreathe in... {0}  ", remainingSeconds - 1);
            Thread.Sleep(1000);
            remainingSeconds -= 2;
        }

        LogActivity();
    }
}