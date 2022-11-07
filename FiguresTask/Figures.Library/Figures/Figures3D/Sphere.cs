using Figures.Library.Figures.Interfaces;

namespace Figures.Library.Figures.Figures3D
{
    public class Sphere : I3DFigure
    {
        public Sphere(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("The radius should be more than zero!");
            }

            this.Radius = radius;
        }

        public double Radius { get; }

        /// <inheritdoc />
        public double Area() => 4 * Math.PI * Math.Pow(this.Radius, 2);

        /// <inheritdoc />
        public double Volume() => 4.0 / 3.0 * Math.PI * Math.Pow(this.Radius, 3);
    }
}
