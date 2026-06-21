public class Rectangle : Shape
{
    double _length;
    double _width;

    public Rectangle(double length, double width) : base("blue")
    {
        _length = length;
        _width = width;
    }

    public override double CalculateArea()
    {
        return _length * _width;   
    }
}