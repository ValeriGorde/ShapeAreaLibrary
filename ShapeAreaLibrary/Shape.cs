namespace ShapeArea.Library
{
    /// <summary>
    /// Абстрактный класс фигуры, для лёгкости добавления других фигур
    /// </summary>
    public abstract class Shape
    {
        public abstract double Accept(IShapeVisitor visitor);
    }
}
