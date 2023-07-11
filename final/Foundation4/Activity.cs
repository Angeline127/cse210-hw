using System;
using System.Collections.Generic;

// Base class for all activities
public abstract class Activity
{
    public DateTime Date { get; set; }
    private int _length;

    public int LengthInMinutes
    {
        get { return _length; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Length must be a positive value.");
            _length = value;
        }
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public virtual string GetSummary()
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = CalculatePace();

        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({LengthInMinutes} min) - Distance: {distance:F1} units, Speed: {speed:F1} units/hour, Pace: {pace:F1} min per unit";
    }
}