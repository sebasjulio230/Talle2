namespace Geometry;

public class Kite : Rhombus
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

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetArea() => (D1 * D2) / 2;
    public override double GetPerimeter() => 2 * (A + B);

    public bool ValidateB(double b) => b > 0;
}