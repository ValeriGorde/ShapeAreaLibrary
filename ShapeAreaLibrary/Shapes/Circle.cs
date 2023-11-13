namespace ShapeArea.Library.Shapes
{
    /// <summary>
    /// Класс фигуры круга
    /// </summary>
    public class Circle : Shape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Accept(IShapeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
