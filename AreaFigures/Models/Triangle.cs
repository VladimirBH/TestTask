using AreaFigures.Interfaces;

namespace AreaFigures.Models
{
    public class Triangle(double aSide, double bSide, double cSide) : IFigure
    {
        private readonly double _aSide = aSide;
        private readonly double _bSide = bSide;
        private readonly double _cSide = cSide;

        public double CalculateArea()
        {
            double halfPerimeter = (_aSide + _bSide + _cSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _aSide) * (halfPerimeter - _bSide) * (halfPerimeter - _cSide));
        }

        public bool IsRightAngled()
        {
            return (Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2) == Math.Pow(_cSide, 2)) || 
                   (Math.Pow(_aSide, 2) + Math.Pow(_cSide, 2) == Math.Pow(_bSide, 2)) ||
                   (Math.Pow(_bSide, 2) + Math.Pow(_cSide, 2) == Math.Pow(_aSide, 2));
        }
    }
}