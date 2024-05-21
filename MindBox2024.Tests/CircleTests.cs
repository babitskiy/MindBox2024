using MindBox2024.Models;

namespace MindBox2024.Tests
{
    internal class CircleTest
    {
        /// <summary>
        /// Исключение: Радиус окружности должен быть больше нуля
        /// </summary>
        [Test]
        public void CicrleTest_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0).GetArea());
            Assert.Throws<ArgumentException>(() => new Circle(-2).GetArea());
        }

        /// <summary>
        /// Успех: Возвращена корректная площадь круга
        /// </summary>
        [Test]
        public void CicrleTest_Success()
        {
            var radius = 4.0;

            Shape circle = new Circle(radius);

            var result = Math.Round(circle.GetArea(), 2);

            double correctAnswer = 50.27;

            Assert.That(result, Is.EqualTo(correctAnswer));
        }
    }
}