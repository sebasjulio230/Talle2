namespace Geometry;

public abstract class GeometricFigure
{
    public string Name{ get; set; }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        //  return $"{Name,-13}  => Area.....: {GetArea(),13:F5}  Perimeter: {GetPerimeter(),13:F5}";

        double area = GetArea();
        string areas;

        if (area >= 1000)
        {
            
            areas = area.ToString("N5");
            areas = areas.Replace(",", "#").Replace(".", ",").Replace("#", ".");
        }
        else
        {
            areas = area.ToString("F5");
            areas = areas.Replace('.', ',');
        }

        return $"{Name,-15} -> Area...... {areas,12}    Perimeter: {GetPerimeter(),12:F5}";
    }
}