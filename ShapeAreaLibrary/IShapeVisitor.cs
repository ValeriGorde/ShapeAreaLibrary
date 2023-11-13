using ShapeArea.Library.Shapes;

namespace ShapeArea.Library
{
    /// <summary>
    /// Интерфейс для каждого типа фигур для реализации паттерна "Посетитель"
    /// </summary>
    public interface IShapeVisitor
    {
        double Visit(Circle circle);
        double Visit(Triangle triangle);
    }
}
