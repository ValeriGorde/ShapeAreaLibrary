using ShapeArea.Library.Shapes;

namespace ShapeArea.Library
{
    /// <summary>
    /// Класс для нахождения площадей фигур
    /// </summary>
    public class CalculateArea : IShapeVisitor
    {
        public double _semiPerimeter;

        // Площадь круга
        public double Visit(Circle circle)
        {
            if(circle.Radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным!");
            }
            
            return Math.Round(Math.PI * Math.Pow(circle.Radius, 2), 2);
        }

        // Площадь треугольника
        public double Visit(Triangle triangle)
        {
            if(triangle.FirstSide <= 0 || triangle.SecondSide <= 0 || triangle.ThirdSide <= 0)
            {
                throw new ArgumentException("Длины сторон треугольника должны быть положительными!");
            }
            // проверка на то, является ли треугольник прямоугольным
            if(Math.Pow(triangle.FirstSide, 2) + Math.Pow(triangle.SecondSide, 2) == Math.Pow(triangle.ThirdSide, 2))
            {
                return Math.Round((triangle.FirstSide * triangle.SecondSide) / 2, 2);
            }

            _semiPerimeter = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) / 2;
            return Math.Round(Math.Sqrt(_semiPerimeter * (_semiPerimeter - triangle.FirstSide) * (_semiPerimeter - triangle.SecondSide) * (_semiPerimeter - triangle.ThirdSide)), 2);
        }
    }
}
