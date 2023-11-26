using GeometryLibrary;

namespace TestGeometryLibrary
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void TestCircleArea()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.54, circle.CalculateArea(), 0.01);
        }

        [Test]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 0.01);
        }

        [Test]
        public void TestRightAngledTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled());
        }


        [Test]
        public void TestNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void TestNegativeTriangleSide()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));
        }
    }
}