using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; }
    public abstract bool IsCompleted { get; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetProgress();
    public abstract string GetFormattedGoal();
}