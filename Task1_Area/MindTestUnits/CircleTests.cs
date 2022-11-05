using MindTestLib;
using System;
using Xunit;

namespace MindTestUnits
{
    public class CircleTests
    {
        [Fact]
        public void ErrorWhenRadiusMinusOne()
        {
            Assert.Throws<ArgumentException>(() => new TCircle(-1));
        }

        [Fact]
        public void ErrorWhenRadiusZero()
        {
            Assert.Throws<ArgumentException>(() => new TCircle(0));
        }

        [Fact]
        public void CorrectArea_radius3()
        {
            double radius = 3;
            double expected = Math.Round(Math.PI * radius, 6);

            IFigure circle = new TCircle(radius);
            double actualArea = circle.CalculateArea();

            Assert.Equal(expected, actualArea);
        }

        [Fact]
        public void CorrectArea_radius8dot5()
        {
            double radius = 8.5;
            double expected = Math.Round(Math.PI * radius, 6);

            IFigure circle = new TCircle(radius);
            double actualArea = circle.CalculateArea();

            Assert.Equal(expected, actualArea);
        }
    }
}
