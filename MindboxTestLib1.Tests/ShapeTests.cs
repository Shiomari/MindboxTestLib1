namespace MindboxTestLib1.Tests
{
    public class ShapeTests
    {

        #region Circle

        [Fact]
        public void CircleAreaCalculation()
        {
            IShape circle = new Circle(5);

            double area = circle.CalculateArea();

            Assert.Equal(78.54, area, 2);
        }

        //[Fact]
        //public void CircleAreaMethod()
        //{
        //    double area = ShapeMath.CircleArea(5);

        //    Assert.Equal(78.54, area, 2);
        //}

        [Fact]
        public void Circle_NegativeThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [Fact]
        public void CircleAreaMethod_NegativeThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ShapeMath.CircleArea(-5));
        }

        #endregion


        #region Triangle

        [Fact]
        public void TriangleAreaCalculation()
        {
            IShape triangle = new Triangle(3, 4, 5);

            double area = triangle.CalculateArea();

            Assert.Equal(6, area);
        }

        //[Fact]
        //public void TriangleAreaMethod()
        //{
        //    double area = ShapeMath.TriangleArea(3, 4, 5);

        //    Assert.Equal(6, area);
        //}

        [Fact]
        public void Triangle_NegativeThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, -4, 5));
        }

        [Fact]
        public void TriangleAreaMethod_NegativeThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ShapeMath.TriangleArea(-5, 1, 1));
        }

        [Fact]
        public void TriangleAreaCalculation_InvalidSides()
        {
            IShape triangle = new Triangle(1, 1, 3);
            Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
        }

        #endregion

    }
}
