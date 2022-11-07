using Figures.Library.Figures.Interfaces;

namespace Figures.Library.Figures.Figures2D;

public class Circle : I2DFigure
{
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("The radius should be more than zero!");
        }

        this.Radius = radius;
    }

    public double Radius { get; }

    /// <inheritdoc />
    public double Area() => Math.PI * Math.Pow(this.Radius, 2);

    /// <inheritdoc />
    public double Perimeter() => 2 * Math.PI * this.Radius;
}