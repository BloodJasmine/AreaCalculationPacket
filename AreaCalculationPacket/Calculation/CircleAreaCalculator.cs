using AreaCalculationPacket.Interfaces;

namespace AreaCalculationPacket.Calculation
{
    public class CircleAreaCalculator : IAreaCalculator
    {
        private double _radius;
        public CircleAreaCalculator(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
