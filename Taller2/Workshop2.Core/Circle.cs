namespace Geometry;

public class Circle : GeometricFigure
{
    private double _r;
    public double R
    {
        get => _r;
        set
        {
            if (!ValidateR(value))
                throw new ArgumentException($"Radius {value} is not valid");
            _r = value;
        }
    }

    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    public override double GetArea() => Math.PI * R * R;
    public override double GetPerimeter() => 2 * Math.PI * R;

    public bool ValidateR(double r) => r > 0;
}