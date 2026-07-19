using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(5));
        shapes.Add(new Circle(3));
        shapes.Add(new Rectangle(5, 4));
        foreach (Shape figure in shapes)
        {
            Console.WriteLine(figure.GetColor());
            Console.WriteLine(figure.CalculateArea());

        }
    }
}