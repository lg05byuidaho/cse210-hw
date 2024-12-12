// Circle.cs
using System;

public class Circle : Shape
{
    private double _radius;

    // Constructor that accepts color and radius, then passes color to the base class
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea to calculate the area of a circle
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;  // Area of a circle = 3.14 * radius^2
    }
}
