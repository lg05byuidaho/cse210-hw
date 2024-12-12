// Rectangle.cs
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor that accepts color, length, and width, then passes color to the base class
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override GetArea to calculate the area of a rectangle
    public override double GetArea()
    {
        return _length * _width;  // Area of a rectangle = length * width
    }
}
