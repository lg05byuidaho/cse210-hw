using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Overridden method to get distance for swimming
    public override double GetDistance()
    {
        // Convert laps to distance in miles
        return (_laps * 50 / 1000) * 0.62; // 50 meters per lap, 1 km = 1000 meters, 1 mile = 1.609 km
    }

    // Overridden method to get speed (mph)
    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / Minutes) * 60;
    }

    // Overridden method to get pace (minutes per mile)
    public override double GetPace()
    {
        double distance = GetDistance();
        return Minutes / distance;
    }
}
