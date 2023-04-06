using Geometry;
using Geometry.Exceptions;
using Geometry.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GeometryTests
{
    [TestFixture]
    public class FigureTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCircleTest()
        {
            Figure circle = new Circle(5);

            Assert.That(circle, Is.InstanceOf(typeof(Circle)));
            Assert.That((circle as Circle).Radius, Is.EqualTo(5));
        }

        [Test]
        [TestCase(1, ExpectedResult = 3.141593)]
        [TestCase(3, ExpectedResult = 28.274334)]
        [TestCase(5, ExpectedResult = 78.539816)]
        [TestCase(7, ExpectedResult = 153.93804)]
        [TestCase(10, ExpectedResult = 314.159265)]
        public double CircleGetAreaTest(int radius)
        {
            Circle circle = new Circle(radius);

            return Math.Round(circle.GetArea(), 6);
        }

        [Test]
        public void CreateTriangleTest()
        {
            Figure triangle = new Triangle(1, 2, 5);

            Assert.That(triangle, Is.InstanceOf(typeof(Triangle)));
            Assert.That((triangle as Triangle).A, Is.EqualTo(1));
            Assert.That((triangle as Triangle).B, Is.EqualTo(2));
            Assert.That((triangle as Triangle).C, Is.EqualTo(5));
        }

        [Test]
        public void TriangleNotExistTest()
        {
            Triangle triangle = new Triangle(1, 2, 3);

            Assert.That(() => triangle.GetArea(), 
                Throws.Exception.TypeOf<NotExistTriangleException>()
                .With.Message.EqualTo("Треугольника с такими сторонами не существует."));
        }

        [Test]
        public void TriangleExistTest()
        {
            Triangle triangle = new Triangle(5, 10, 10);

            Assert.That(() => triangle.GetArea(), Throws.Nothing);
        }

        [Test]
        [TestCase(1,2,2, ExpectedResult = 0.968246)]
        [TestCase(2,4,5, ExpectedResult = 3.799671)]
        [TestCase(3,6,7, ExpectedResult = 8.944272)]
        [TestCase(4,8,9, ExpectedResult = 15.998047)]
        [TestCase(5,10,12, ExpectedResult = 24.544602)]
        public double TriangleGetAreaTest(int a, int b, int c)
        {
            Triangle triangle = new Triangle(a, b, c);

            return Math.Round(triangle.GetArea(), 6);
        }

        [Test]
        public void FiguresAreaTest()
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Circle(5));
            figures.Add(new Triangle(1, 2, 2));

            foreach (var figure in figures)
            {
                Assert.That(figure, Is.InstanceOf<IArea>());
                Assert.That(() => figure.GetArea(), Is.Not.Null);
            }
        }

        [Test]
        [TestCase(1.4142135623731F, 1.4142135623731F, 2F, ExpectedResult = true)]
        [TestCase(2, 4, 5, ExpectedResult = false)]
        [TestCase(3, 6, 7, ExpectedResult = false)]
        [TestCase(4, 8, 9, ExpectedResult = false)]
        [TestCase(5, 10, 12, ExpectedResult = false)]
        public bool CheckRightAngleTest(float a, float b, float c)
        {
            Triangle triangle = new Triangle(a, b, c);

            return triangle.CheckRightAngle();
        }
    }
}