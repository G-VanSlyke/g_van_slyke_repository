public class Circle : Shape
{
    private double _radius;

    public Circle(double radius) : base("orange")
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {
        return _radius * _radius * Math.PI;
    }
}