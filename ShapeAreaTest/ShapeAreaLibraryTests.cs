using NUnit.Framework;
using ShapeArea.Library;
using ShapeArea.Library.Shapes;

namespace ShapeArea.Tests
{
    [TestFixture]
    public class ShapeAreaLibraryTests
    {
        [Test]
        public void CaculateCircleArea_ValidRadius_ReturnCorrectArea()
        {
            double radius = 4;
            double expectedArea = 50.27;

            var circle = new Circle(radius);
            var area = new CalculateArea();
            double actualArea = circle.Accept(area);

            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void CalculateTriangle_ValidSides_ReturnCorrectArea()
        {
            double firstSide = 3;
            double secondSide = 5;
            double thirdSide = 6;
            double expectedArea = 7.48;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var area = new CalculateArea();
            double actualArea = triangle.Accept(area);

            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }

        [Test]
        public void CaculateTriangle_RightTriangle_ReturnCorrectArea()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;
            double expectedArea = 6;

            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var area = new CalculateArea();
            double actualArea = triangle.Accept(area);

            Assert.That(expectedArea, Is.EqualTo(actualArea));
        }
    }
}