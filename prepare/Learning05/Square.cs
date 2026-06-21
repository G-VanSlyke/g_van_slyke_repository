public class Square : Shape
{
    private double _sideLength;

    public Square(double sideLength) : base("green")
    {
        _sideLength = sideLength;
        
    }

    public override double CalculateArea()
    {
        return _sideLength * _sideLength;
    }
}