namespace MindboxTestLib1
{
    public class Circle : IShape
    {

        public Circle(double radius)
        {
            if (ShapeMath.ZeroOrNegativeCheck(radius))
                throw new ArgumentOutOfRangeException("Радиус круга должен быть больше 0.");

            Radius = radius;
        }



        public double Radius { get; }



        public double CalculateArea()
        {
            return ShapeMath.CircleArea(Radius);
        }
    }
}
