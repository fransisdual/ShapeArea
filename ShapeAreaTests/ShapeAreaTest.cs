using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeArea;
using System;

namespace ShapeAreaTests
{
    [TestClass]
    public class ShapeAreaTest
    {
        [TestMethod]
        public void ZeroCircleRadiusTest()
        {

            // arrange



            // act
            Circle circle = new ShapeArea.Circle();



            // assert
            Assert.AreEqual(0, circle.Area);

        }


        [TestMethod]
        public void ZeroTriangleSidesTest()
        {

            // arrange



            // act
            Triangle triangle = new ShapeArea.Triangle();



            // assert
            Assert.AreEqual(0, triangle.Area);

        }

        [TestMethod]
        public void CircleAreaTest()
        {

            // arrange
            double rightArea = Math.PI * Math.Pow(5, 2);


            // act
            Circle circle = new ShapeArea.Circle(5);



            // assert
            Assert.AreEqual(rightArea, circle.Area);

        }


        [TestMethod]
        public void TriangleAreaTest()
        {

            // arrange
            int a, b, c;
            a = b = c = 5;


            double p = (a + b + c) / 2;

            double result =  Math.Sqrt(p * (p - a) * (p - b) * (p - c));


            // act
            Triangle triangle = new ShapeArea.Triangle(a,b,c);



            // assert
            Assert.AreEqual(result, triangle.Area);

        }

        [TestMethod]
        public void TriangleRightTest()
        {

            // arrange



            // act
            Triangle triangle = new ShapeArea.Triangle(12,5,13);



            // assert
            Assert.AreEqual(true, triangle.IsRight());

        }

    }
}
