using Figures.Library.Figures.Interfaces;

namespace Figures.Library.Figures.Figures2D
{
    public class Triangle : I2DFigure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("The sides should be more than zero!");
            }

            if (sideC > sideA + sideB || sideB > sideA + sideC || sideA > sideB + sideC)
            {
                throw new ArgumentException("One side of the triangle cannot be more than the sum of the other two!");
            }

            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        /// <inheritdoc />
        public double Area()
        {
            var semiPerimeter = this.Perimeter() / 2;

            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - this.SideA) * (semiPerimeter - this.SideB) * (semiPerimeter - this.SideC));

            return area;
        }

        /// <inheritdoc />
        public double Perimeter() => this.SideA + this.SideB + this.SideC;

        public bool IsRight()
        {
            var sides = new[] { this.SideA, this.SideB, this.SideC };

            Array.Sort(sides);

            return Math.Pow(sides[2], 2).Equals(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
        }
    }
}
