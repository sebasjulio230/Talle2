namespace Geometry;

public class Rectangle : Square
{
    private double _b;
    public double B
    {
        get => _b;
        set
        {
            if (!ValidateB(value))
                throw new ArgumentException($"Side {value} is not valid");
            _b = value;
        }
    }

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    public override double GetArea() => A * B;
    public override double GetPerimeter() => 2 * (A + B);

    public bool ValidateB(double b) => b > 0;
}