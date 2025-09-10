namespace Geometry;

public class Square : GeometricFigure
{
    private double _a;
    public double A
    {
        get => _a;
        set
        {
            if (!ValidateA(value))
                throw new ArgumentException($"Side {value} is not valid");
            _a = value;
        }
    }

    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    public override double GetArea() => A * A;
    public override double GetPerimeter() => 4 * A;

    public bool ValidateA(double a) => a > 0;
}