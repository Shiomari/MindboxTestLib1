namespace MindboxTestLib1
{
    public static class ShapeMath
    {

        const string POSITIVE_SIDE_THROW = "Размер каждой из строн должен быть больше 0.";



        public static double CircleArea(double radius)
        {
            if (ZeroOrNegativeCheck(radius))
                throw new ArgumentOutOfRangeException("Радиус круга должен быть больше 0.");

            return radius * radius * Math.PI;
        }

        public static double TriangleArea(double a, double b, double c)
        {
            if (ZeroOrNegativeCheck(a,b,c))
                throw new ArgumentOutOfRangeException(POSITIVE_SIDE_THROW);

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            
            if (!(area >= 0)) 
                throw new ArgumentException("Фигура с указанными сторонами не является треугольником.");

            return area;
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (ZeroOrNegativeCheck(a, b, c))
                throw new ArgumentOutOfRangeException(POSITIVE_SIDE_THROW);

            double maxSide = Math.Max(a, Math.Max(b, c));

            if (maxSide == a)
            {
                return Math.Abs(b * b + c * c - a * a) < 0.0001;
            }
            else if (maxSide == b)
            {
                return Math.Abs(a * a + c * c - b * b) < 0.0001;
            }
            else
            {
                return Math.Abs(a * a + b * b - c * c) < 0.0001;
            }
        }


        public static bool ZeroOrNegativeCheck(params double[] values)
        {
            foreach (double value in values)
            {
                if (value <= 0)
                    return true;
            }

            return false;
        }

    }
}
