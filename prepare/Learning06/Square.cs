// Square.cs
public class Square : Shape
{
    private double _side;

    // Constructor that accepts color and side length, then passes color to the base class
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea to calculate the area of a square
    public override double GetArea()
    {
        return _side * _side;  // Area of a square = side * side
    }
}
