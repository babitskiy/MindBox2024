using MindBox2024.Models;

namespace MindBox2024.Figures
{
    public class Triangle : Shape
    {
        private readonly double _sideA, _sideB, _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            // сторона треугольника не может быть меньше или равна нулю
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть больше 0");
            }

            // сумма двух сторон треугольника должна быть больше третьей стороны
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Сумма двух сторон треугольника должна быть больше третьей стороны");
            }

            _sideA = sideA; 
            _sideB = sideB; 
            _sideC = sideC;
        }
        
        // метод вычисления периметра треугольника
        private double GetPerimeter()
            => _sideA + _sideB + _sideC;
        
        // метод проверки является ли треугольник прямоугольным
        public bool IsRightTriangle()
            => Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) == Math.Pow(_sideC, 2) ||
                Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideB, 2) ||
                Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) == Math.Pow(_sideA, 2);


        // метод вычисления площади треугольника
        public override double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2.0;
            double area = Math.Sqrt(halfPerimeter *
                (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));

            return area;
        }
    }
}