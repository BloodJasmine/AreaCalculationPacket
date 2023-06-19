using AreaCalculationPacket.Interfaces;

namespace AreaCalculationPacket.Calculation
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public bool IsRectangular
        {
            get
            {
                if ((_side1 * _side1 + _side2 * _side2 == _side3 * _side3) ||
                    (_side1 * _side1 + _side3 * _side3 == _side2 * _side2) ||
                    (_side3 * _side3 + _side2 * _side2 == _side1 * _side1))
                    return true;
                else
                    return false;
            }
        }

        public TriangleAreaCalculator(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double p = (_side1 + _side2 + _side3) / 2.0;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

    }
}
