using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibrarySquare
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void squareCircleTest() // ����: ��������� ������� �����
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
        public void squareTriangleTest() // ����: ��������� ������� ������������
        {
            // arrange
            var triangle = new Triangle(4, 10, 8);

            // act
            var square = triangle.getSquare();

            // assert
            Assert.AreEqual(15.198684153570664, square);
        }

        [TestMethod]
        public void typeTriangleTest() // ����: ���������� ��� ������������
        {
            // arrange
            var triangle = new Triangle(4, 10, 10);

            // act
            var type = triangle.getType();

            // assert
            Assert.AreEqual("��������������", type);
        }

        [TestMethod]
        public void isRightTriangleTest() // ����: ����������, �������� �� ����������� �������������
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
