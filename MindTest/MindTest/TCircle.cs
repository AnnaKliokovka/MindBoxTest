using System;
//*************************************************************************************
namespace MindTestLib
{
    /// <summary>
    /// Класс фигуры - круг
    /// </summary>
    public class TCircle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        double radius;
//--------------------------------------------------------------------------------------
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public TCircle(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                throw new ArgumentException("Радиус окружности должен быть положительным дейстивтельным числом.");
            }
        }
//---------------------------------------------------------------------------------------
        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.Round(Math.PI * radius, 6);
        }
    }
}
//----------------------------------------------------------------------------------------
