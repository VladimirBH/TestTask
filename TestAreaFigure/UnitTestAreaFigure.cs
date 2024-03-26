using AreaFigures.Models;

namespace TestAreaFigure
{
    public class UnitTestAreaFigure
    {
        [Fact]
        public void TestAreaCircleCalculation()
        {
            var circle = new Circle(11);
            Assert.Equal(380.132711, circle.CalculateArea(), 0.000001); 
        }

        [Fact]
        public void TestAreaTriagleCalculation1()
        {
            var triangle = new Triangle(7, 8, 2);
            Assert.Equal(6.437197, triangle.CalculateArea(), 0.000001); 
        }

        [Fact]
        public void TestIsRightAngledTriangleTrue()
        {
            var triangle = new Triangle(5, 4, 3);
            Assert.True(triangle.IsRightAngled()); 
        }

        [Fact]
        public void TestIsRightAngledTriangleFalse()
        {
            var triangle = new Triangle(8, 3, 10);
            Assert.False(triangle.IsRightAngled()); 
        }

        [Fact]
        public void TestCalculateAreaFiguresWithTriangle()
        {
            var calculateAreaFigure = new CalculateAreaFigure();
            
            Assert.Equal(24, calculateAreaFigure.CalculateArea(new Triangle(6, 8, 10)), 0.000001); 
        }

        [Fact]
        public void TestCalculateAreaFiguresWithCircle()
        {
            var calculateAreaFigure = new CalculateAreaFigure();
            
            Assert.Equal(28.274333, calculateAreaFigure.CalculateArea(new Circle(3)), 0.000001); 
        }
    }
}
