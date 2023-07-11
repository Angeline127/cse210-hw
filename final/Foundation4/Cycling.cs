using System;
using System.Collections.Generic;


// Derived class for cycling activity
public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double CalculateDistance()
    {
        return Speed * (LengthInMinutes / 60.0);
    }

    public override double CalculateSpeed()
    {
        return Speed;
    }

    public override double CalculatePace()
    {
        return 60.0 / Speed;
    }
}