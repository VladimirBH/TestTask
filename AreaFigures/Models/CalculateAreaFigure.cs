using AreaFigures.Interfaces;

namespace AreaFigures.Models
{
    public class CalculateAreaFigure
    {
        public double CalculateArea(IFigure figure)
        {
            ArgumentNullException.ThrowIfNull(figure);
            return figure.CalculateArea();
        }
    }
}