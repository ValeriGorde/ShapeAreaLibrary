namespace ShapeArea.Library.Shapes
{
    /// <summary>
    /// Класс фигуры треугольника
    /// </summary>
    public class Triangle : Shape
    {
        public double FirstSide;
        public double SecondSide;
        public double ThirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }        

        public override double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
