using System;

public class Running : Activity
{
    private double _distance; // In miles

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Overridden method to get distance for running
    public override double GetDistance()
    {
        return _distance;
    }

    // Overridden method to get speed (mph)
    public override double GetSpeed()
    {
        return (_distance / Minutes) * 60;
    }

    // Overridden method to get pace (minutes per mile)
    public override double GetPace()
    {
        return Minutes / _distance;
    }
}
