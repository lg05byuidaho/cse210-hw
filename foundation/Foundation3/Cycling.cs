using System;

public class Cycling : Activity
{
    private double _speed; // Speed in miles per hour

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Overridden method to get distance for cycling
    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    // Overridden method to get speed (mph)
    public override double GetSpeed()
    {
        return _speed;
    }

    // Overridden method to get pace (minutes per mile)
    public override double GetPace()
    {
        return 60 / _speed;
    }
}
