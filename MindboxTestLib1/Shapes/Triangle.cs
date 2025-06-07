namespace MindboxTestLib1
{
    public class Triangle : IShape
    {

        public Triangle(double a, double b, double c)
        {
            if (ShapeMath.ZeroOrNegativeCheck(a, b, c))
                throw new ArgumentOutOfRangeException("Размер каждой из строн треугольника должен быть больше 0.");

            A = a;
            B = b;
            C = c;
        }



        public double A { get; }

        public double B { get; }

        public double C { get; }

        public bool IsRightTriangle
        {
            get
            {
                return ShapeMath.IsRightTriangle(A, B, C);
            }
        }



        public double CalculateArea()
        {
            return ShapeMath.TriangleArea(A, B, C);
        }
    }

}
