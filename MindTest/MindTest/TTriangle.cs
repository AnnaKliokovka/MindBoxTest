using System;
using System.Linq;
//******************************************************************************************
namespace MindTestLib
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class TTriangle : IFigure
    {
        /// <summary>
        /// Массив со сторонами треугольника (от меньшего к большему)
        /// </summary>
        double[] Sides;
//---------------------------------------------------------------------------------------
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        public TTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными дейстивтельными числами.");
            }
            if (a + b < c || b + c < a || a + c < b)
            {
                throw new ArgumentException("Нарушается правило треугольника, убедитесь, что длины стороны правильно записаны.");
            }
            Sides = new double[] { a, b, c };
            Array.Sort(Sides);
        }
//---------------------------------------------------------------------------------------------
        /// <summary>
        /// Проверка, что треугольник является прямоугоьным
        /// </summary>
        /// <returns>True - если треугольник является прямоугольным</returns>
        public bool RightTriangle()
        {
            double epsilon = 0.0001;
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) < epsilon;
        }
//---------------------------------------------------------------------------------------
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double CalculateArea()
        {
            if (RightTriangle())
            {
                return Sides[0] * Sides[1] * 0.5;
            }
            else
            {
                double P = Sides.Sum() * 0.5;
                return Math.Round(Math.Sqrt(P * (P - Sides[0]) * (P - Sides[1]) * (P - Sides[2])), 6);
            }
        }
    }
}
//-------------------------------------------------------------------------------------------
