namespace Geometry;

public class Trapeze : Triangle
{
    private double _d;
    public double D
    {
        get => _d;
        set
        {
            if (!ValidateD(value))
                throw new ArgumentException($"Side {value} is not valid");
            _d = value;
        }
    }

    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    public override double GetArea() => (B + D) * H / 2;
    public override double GetPerimeter() => A + B + C + D;

    public bool ValidateD(double d) => d > 0;
}