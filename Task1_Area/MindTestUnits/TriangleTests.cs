using MindTestLib;
using System;
using Xunit;

namespace MindTestUnits
{
    public class TriangleTests
    {
        [Fact]
        public void ErrorWhenOneSideIsMinusOne()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(10,-1,5));
        }

        [Fact]
        public void ErrorWhenNotTriangle()
        {
            Assert.Throws<ArgumentException>(() => new TTriangle(20, 5, 5));
        }

        [Fact]
        public void IsRightTriangle()
        {
            TTriangle triangle = new TTriangle(4, 3, 5);
            Assert.True(triangle.RightTriangle());
        }

        [Fact]
        public void IsntRightTriangle()
        {
            TTriangle triangle = new TTriangle(5, 14, 12);
            Assert.False(triangle.RightTriangle());
        }

        [Fact]
        public void CorrectArea_a4_b5_c3()
        {
            double a = 4, b = 5, c = 3;
            double expected = 6;

            IFigure triangle = new TTriangle(a, b, c);
            double actual = triangle.CalculateArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CorrectArea_a5_b5_c2d8()
        {
            double a = 5, b = 5, c = 2.8;
            double expected = 6.72;

            IFigure triangle = new TTriangle(a, b, c);
            double actual = triangle.CalculateArea();

            Assert.Equal(expected, actual);
        }

    }
}
