using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibrarySquare
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void squareCircleTest() // Тест: вычислить площадь круга
        {
            // arrange
            var circle = new Circle(4);

            // act
            var square = circle.getSquare();

            // assert
            Assert.AreEqual(50.24, square);
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void squareTriangleTest() // Тест: вычислить площадь треугольника
        {
            // arrange
            var triangle = new Triangle(4, 10, 8);

            // act
            var square = triangle.getSquare();

            // assert
            Assert.AreEqual(15.198684153570664, square);
        }

        [TestMethod]
        public void typeTriangleTest() // Тест: определить тип треугольника
        {
            // arrange
            var triangle = new Triangle(4, 10, 10);

            // act
            var type = triangle.getType();

            // assert
            Assert.AreEqual("Равнобедренный", type);
        }

        [TestMethod]
        public void isRightTriangleTest() // Тест: определить, является ли треугольник прямоугольным
        {
            // arrange
            var triangle = new Triangle(3, 4, 5);

            // act
            var isRight = triangle.isRight();

            // assert
            Assert.IsTrue(isRight);
        }
    }
}
