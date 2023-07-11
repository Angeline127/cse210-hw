using System;
using System.Collections.Generic;

// Derived class for swimming activity
public class Swimming : Activity
{
    private const double LapLengthInMeters = 50;

    public int Laps { get; set; }

    public override double CalculateDistance()
    {
        return Laps * LapLengthInMeters / 1000.0;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return (distance / LengthInMinutes) * 60.0;
    }

    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return LengthInMinutes / distance;
    }
}