namespace Workshop2.Core;

public abstract class GeometricFigure
{
    public String Name { get; set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();

    public override string ToString()
    {
        return $"{Name}: Area = {Area()}, Perimeter = {Perimeter()}";
    }

}
