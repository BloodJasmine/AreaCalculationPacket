using AreaCalculationPacket.Interfaces;

namespace AreaCalculationPacket.Calculation
{
    internal class AreaCalculatorStrategy
    {
        public double CalculateArea(IAreaCalculator areaCalculator)
        {
            return areaCalculator.CalculateArea();
        }
    }
}
