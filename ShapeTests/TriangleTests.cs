using System;
using ShapeLibrary.Implementations;

namespace ShapeTests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateArea_ReturnsCorrectValue()
        {
            var triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            Assert.Equal(expectedArea, triangle.CalculateArea(), 5);
        }

        [Fact]
        public void IsRightAngled_ReturnsTrueForRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void Constructor_ThrowsArgumentExceptionForInvalidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
        }
    }
}

