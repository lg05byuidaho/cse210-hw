// Shape.cs
using System;

public abstract class Shape
{
    private string _color;

    // Constructor to initialize the color
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    
    
    // Abstract method to get the area, must be overridden in derived classes
    public abstract double GetArea();
}
