using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public override bool IsCompleted => false;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // Eternal goals cannot be completed, so no action is required.
        return 0;
    }

    public override string GetProgress()
    {
        return Name;
    }

    public override string GetFormattedGoal()
    {
        return $"{Points}Points\n5. EternalGoal {{\n\tname: {Name}\n\tdescription: {Description}\n\tpoints: {Points}\n\tstatus: Not Completed\n}}";
    }
}