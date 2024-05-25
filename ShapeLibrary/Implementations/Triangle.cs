using System;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Implementations
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            if (!IsValid())
            {
                throw new ArgumentException("The sides do not form a valid triangle.");
            }
        }

        public double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };

            if ((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2))
                || (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))
                || (Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2)))
            {
                return true;
            }

            return false;
        }

        private bool IsValid()
        {
            return (SideA + SideB > SideC) && (SideA + SideC) > SideB && (SideB + SideC > SideA);
        }
    }
}

