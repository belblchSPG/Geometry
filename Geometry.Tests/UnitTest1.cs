using Geometry.Shapes;

namespace Geometry.Test
{
    [TestClass]
    public class UnitTest_Circle
    {
        [TestMethod]
        public void Test_1()
        {
            Circle circle = new Circle(2);

            double expected = 12.566;

            Assert.AreEqual(expected, circle.Area(), 0.001);
        }

        [TestMethod]
        public void Test_2() => Assert.ThrowsException<ArgumentException>(() => new Circle(-2));

        [TestMethod]
        public void Test_3()
        {
            Circle circle = new Circle(2.345);

            double expected = 17.275;

            Assert.AreEqual(expected, circle.Area(), 0.001);
        }
    }

    [TestClass]
    public class UnitTest_Triangle
    {
        [TestMethod]
        public void Test_1() => Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 3));

        [TestMethod]
        public void Test_2() => Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 3, -4));

        [TestMethod]
        public void Test_3()
        {
            Triangle triangle = new Triangle(2, 3, 4);

            double expected = 2.904;

            Assert.AreEqual(expected, triangle.Area(), 0.001);
        }
    }

    [TestClass]
    public class UnitTest_Shape
    {
        [TestMethod]
        public void Test_1()
        {
            Shape circle = new Circle(2);

            double expected = 12.566;

            Assert.AreEqual(expected, circle.Area(), 0.001);
        }

        [TestMethod]
        public void Test_2()
        {
            Shape triangle = new Triangle(2, 3, 4);

            double expected = 2.904;

            Assert.AreEqual(expected, triangle.Area(), 0.001);
        }
    }
}