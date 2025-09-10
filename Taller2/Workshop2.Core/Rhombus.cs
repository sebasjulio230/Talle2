namespace Geometry;

public class Rhombus : Square
{
    private double _d1, _d2;

    public double D1
    {
        get => _d1;
        set
        {
            if (!ValidateD1(value))
                throw new ArgumentException($"Diagonal {value} is not valid");
            _d1 = value;
        }
    }

    public double D2
    {
        get => _d2;
        set
        {
            if (!ValidateD2(value))
                throw new ArgumentException($"Diagonal {value} is not valid");
            _d2 = value;
        }
    }

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 4 * A;

    public bool ValidateD1(double d1) => d1 > 0;
    public bool ValidateD2(double d2) => d2 > 0;
}
