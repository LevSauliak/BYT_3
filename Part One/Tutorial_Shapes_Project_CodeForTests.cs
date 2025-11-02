using NUnit.Framework;
using Tut2_s20123;

namespace Tut2_s20123_Tests
{
    public class Tests
    {
        private readonly IShape sphere = new Sphere(5);
        private readonly IShape cube = new Cube(5);
        private readonly IShape cylinder = new Cylinder(5, 10);
        private readonly IShape rectangle = new Rectangle(5, 10);

        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
           Assert.That(cylinder.CalculateArea(), Is.EqualTo(471.238).Within(0.001)); 
        }
        
        [Test]

        public void TestCylinderCalculateVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(785.398).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(150));
        }
        

        [Test]
        public void TestCubeCalculateVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(125));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(50));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }
    }
}