namespace Geometry;

public class Parallelogram : Rectangle
{
    private double _h;
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

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea() => B * H;
    public override double GetPerimeter() => 2 * (A + B);

    public bool ValidateH(double h) => h > 0;
}