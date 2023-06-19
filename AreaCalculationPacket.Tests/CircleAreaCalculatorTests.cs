using AreaCalculationPacket.Calculation;

namespace AreaCalculationPacket.Tests
{
    public class CircleAreaCalculatorTests
    {
        private CircleAreaCalculator circleAreaCalculator;

        public CircleAreaCalculatorTests()
        {
            double radius = 3.0;

            circleAreaCalculator = new CircleAreaCalculator(radius);
        }

        [Fact]
        public void CalculateAreaTests()
        {
            double expectedArea = 28.274333882308138;

            var area = circleAreaCalculator.CalculateArea();

            Assert.Equal(expectedArea, area);
        }

    }
}
