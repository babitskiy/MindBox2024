using MindBox2024.Models;

namespace MindBox2024.Tests
{
    internal class TriangleTests
    {
        /// <summary>
        /// Исключение: Стороны треугольника должны быть больше нуля
        /// </summary>
        [Test]
        public void TriangleTest_SideLessThanZero_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 3, -1).GetArea());
        }

        /// <summary>
        /// Исключение: Сумма двух сторон должна быть больше третей стороны
        /// </summary>
        [Test]
        public void TriangleTest_WrongTrinagle_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 2, 2).GetArea());
        }

        /// <summary>
        /// Успех: Возвращена корректная площадь треугольника
        /// </summary>
        [Test]
        public void TriangleTest_Success()
        {
            Shape trinagle = new Triangle(4, 5, 6);
            var triangleArea = Math.Round(trinagle.GetArea(), 2);

            double correctAnswer = 9.92;

            Assert.That(triangleArea, Is.EqualTo(correctAnswer));
        }

        /// <summary>
        /// Треугольник прямоугольный
        /// </summary>
        [Test]
        public void IsRightTriangle_True()
        {
            Triangle trinagle = new(3.0, 4.0, 5.0);

            var result = trinagle.IsRightTriangle();

            Assert.That(result, Is.True);
        }

        /// <summary>
        /// Треугольник не прямоугольный
        /// </summary>
        [Test]
        public void IsRightTriangle_False()
        {
            Triangle trinagle = new(2.0, 3.0, 4.0);

            var result = trinagle.IsRightTriangle();

            Assert.That(result, Is.False);
        }
    }
}