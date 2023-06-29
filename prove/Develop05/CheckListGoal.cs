using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    private int completedCount;
    private int targetCount;

    public override bool IsCompleted => completedCount >= targetCount;

    public ChecklistGoal(string name, string description, int points, int completedCount, int targetCount)
        : base(name, description, points)
    {
        this.completedCount = completedCount;
        this.targetCount = targetCount;
    }

    public override int RecordEvent()
    {
        completedCount++;
        return Points;
    }

    public override string GetProgress()
    {
        string progress = $"{Name} ({completedCount}/{targetCount})";

        if (IsCompleted)
        {
            progress += " [X]";
        }

        return progress;
    }

    public override string GetFormattedGoal()
    {
        string status = IsCompleted ? "Completed" : "Not Completed";
        return $"{Points}Points\n6. ChecklistGoal {{\n\tname: {Name}\n\tdescription: {Description}\n\tpoints: {Points}\n\tbonus point: 200\n\ttime: 1/4\n\tstatus: {status}\n}}";
    }
}
