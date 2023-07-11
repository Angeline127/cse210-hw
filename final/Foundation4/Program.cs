using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running
        {
            Date = DateTime.Parse("03 Nov 2022"),
            LengthInMinutes = 30,
            Distance = 3.0
        };

        Cycling cycling = new Cycling
        {
            Date = DateTime.Parse("03 Nov 2022"),
            LengthInMinutes = 30,
            Speed = 19.2
        };

        Swimming swimming = new Swimming
        {
            Date = DateTime.Parse("03 Nov 2022"),
            LengthInMinutes = 30,
            Laps = 30
        };

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
