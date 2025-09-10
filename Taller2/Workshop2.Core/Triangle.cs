namespace Geometry;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public double C
    {
        get => _c;
        set
        {
            if (!ValidateC(value))
                throw new ArgumentException($"Side {value} is not valid");
            _c = value;
        }
    }

    public double H
    {
        get => _h;
        set
        {
            if (!ValidateH(value))
                throw new ArgumentException($"Height {value} is not valid");
            _h = value;
        }
    }

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public override double GetArea() => (B * H) / 2;
    public override double GetPerimeter() => A + B + C;

    public bool ValidateC(double c) => c > 0;
    public bool ValidateH(double h) => h > 0;
}
