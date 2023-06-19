using AreaCalculationPacket.Calculation;

namespace AreaCalculationPacket.Tests
{
    public class TriangleAreaCalculatorTests
    {
        private TriangleAreaCalculator triangleAreaCalculator;

        public TriangleAreaCalculatorTests()
        {
            double side1 = 3.0;
            double side2 = 4.0;
            double side3 = 5.0; 

            triangleAreaCalculator = new TriangleAreaCalculator(side1, side2, side3);
        }

        [Fact]
        public void CalculateAreaTests()
        {
            double expectedArea = 6.0; 
            
            var area = triangleAreaCalculator.CalculateArea();

            Assert.Equal(expectedArea, area);
        }


        [Fact]
        public void IsRectangularTests()
        {
            var isRect = triangleAreaCalculator.IsRectangular;

            Assert.True(isRect);
        }
    }
}