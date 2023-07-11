using System;
using System.Collections.Generic;



// Derived class for running activity
public class Running : Activity
{
    public double Distance { get; set; }

    public override double CalculateDistance()
    {
        return Distance;
    }

    public override double CalculateSpeed()
    {
        return (Distance / LengthInMinutes) * 60.0;
    }

    public override double CalculatePace()
    {
        return LengthInMinutes / Distance;
    }
}