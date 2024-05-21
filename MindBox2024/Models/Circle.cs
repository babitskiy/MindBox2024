using MindBox2024.Models;

namespace MindBox2024.Figures
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            // радиус круга должен быть больше нуля
            if (radius <= 0.0)
            {
                throw new ArgumentException("Радиус круга должен быть больше нуля");
            }

            _radius = radius;
        }

        // метод вычисления площади круга
        public override double GetArea()
            => Math.PI * Math.Pow(_radius, 2);
    }
}