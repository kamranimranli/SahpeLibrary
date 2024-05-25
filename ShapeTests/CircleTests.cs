using System;
using ShapeLibrary.Implementations;

namespace ShapeTests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectValue()
        {
            var circle = new Circle(5);
            double expectedArea = Math.PI * 25;
            Assert.Equal(expectedArea, circle.CalculateArea(), 5);
        }
    }
}

