using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    private bool isCompleted;

    public override bool IsCompleted => isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isCompleted = false;
    }

    public void SetCompleted(bool completed)
    {
        isCompleted = completed;
    }

    public override int RecordEvent()
    {
        isCompleted = true;
        return Points;
    }

    public override string GetProgress()
    {
        string progress = Name;

        if (IsCompleted)
        {
            progress += " [X]";
        }

        return progress;
    }

    public override string GetFormattedGoal()
    {
        string status = IsCompleted ? "Completed" : "Not Completed";
        return $"{Points}Points\n4. SimpleGoal {{\n\tname: {Name}\n\tdescription: {Description}\n\tpoints: {Points}\n\tstatus: {status}\n}}";
    }
}