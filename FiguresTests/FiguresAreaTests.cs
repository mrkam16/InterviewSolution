using InterviewSolution.Models;
using System;
using Xunit;

namespace FiguresTests
{
    public class FiguresAreaTest
    {
        /// <summary>
        /// проверяет положительный ли радиус
        /// </summary>
        [Fact]
        public void CircleRadiusMoreThanZero()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }


        /// <summary>
        /// проверяет площадь круга
        /// </summary>
        [Fact]
        public void CircleAreaChecking()
        {
            // Arrange
            double expected = 314.15926535897931;
            Circle circle = new Circle(10);

            // Act
            double actual = circle.Square;

            //Assert
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// проверяет положительные ли стороны треугольника
        /// </summary>
        [Fact]
        public void TriangleSidesMoreThanZero()
        {
            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-5, 2, 4));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, -4, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 4, -5));
        }

        /// <summary>
        /// проверяет прямоугольный ли треугольник
        /// </summary>
        [Fact]
        public void TriangleNotRightAngledChecking()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool actual = triangle.IsRightAngled;

            //Assert
            Assert.True(actual);
        }

        /// <summary>
        /// проверяет является ли треугольник НЕ прямоугольным
        /// </summary>
        [Fact]
        public void TriangleRightAngledChecking()
        {
            // Arrange
            var triangle = new Triangle(4, 6, 5);

            // Act
            bool actual = triangle.IsRightAngled;

            //Assert
            Assert.True(!actual);
        }

        /// <summary>
        /// проверяет площадь треугольника
        /// </summary>
        [Fact]
        public void TriangleAreaChecking()
        {
            // Arrange
            double expected = 6;
            var triangle = new Triangle(3, 4, 5);

            // Act
            double actual = triangle.Square;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
