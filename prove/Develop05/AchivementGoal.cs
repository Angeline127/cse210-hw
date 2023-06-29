using System;
using System.Collections.Generic;
using System.IO;

class AchievementGoal : Goal
{
    public override bool IsCompleted => false;

    public AchievementGoal(string name, string description)
        : base(name, description, 0)
    {
    }

    public override int RecordEvent()
    {
        // Achievement goals do not offer in-game rewards, so no action is required.
        return 0;
    }

    public override string GetProgress()
    {
        return Name;
    }

    public override string GetFormattedGoal()
    {
        return $"{Points}Points\n7. AchievementGoal {{\n\tname: {Name}\n\tdescription: {Description}\n\tstatus: Not Completed\n}}";
    }
}
