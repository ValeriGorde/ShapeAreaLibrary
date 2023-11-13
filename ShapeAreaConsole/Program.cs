using ShapeArea.Library;
using ShapeArea.Library.Shapes;

var area = new CalculateArea();

Console.WriteLine("Калькулятор площадей");
Console.WriteLine("Выберите фигуру для расчёта: ");
Console.WriteLine("1. Круг");
Console.WriteLine("2. Треугольник");
int choiceNum = int.Parse(Console.ReadLine());

if(choiceNum == 1)
{
    Console.Write("Введите радиус круга: ");
    double radius = double.Parse(Console.ReadLine());
    var circle = new Circle(radius);
    var circleArea = circle.Accept(area);
    Console.WriteLine($"Площадь круга: {circleArea}");
}
else if(choiceNum == 2)
{
    Console.Write("Введите три стороны треугольника (через пробел): ");
    string input = Console.ReadLine();
    
    double[] sides = new double[3];

    for(int i = 0; i < input.Split(' ').Length; i++)
    {
        sides[i] = double.Parse(input.Split(' ')[i]);
    }

    var triangle = new Triangle(sides[0], sides[1], sides[2]);
    var triangleArea = triangle.Accept(area);
    Console.WriteLine($"Площадь треугольника: {triangleArea}");
}
else
{
    throw new ArgumentException("Неккоретный выбор фигуры");
}
