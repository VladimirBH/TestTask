using AreaFigures.Interfaces;

namespace AreaFigures.Models
{
    public class Circle(double radius) : IFigure
    {
        private readonly double _radius = radius;
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}