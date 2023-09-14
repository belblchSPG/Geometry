using System;

namespace Geometry.Shapes
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
            }
            else
            {
                throw new ArgumentException("Radius must be posotive.");
            }
        }

        public override double Area()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        private double[] _sides;

        public Triangle(double side1, double side2, double side3)
        {
            if (IsTriangleValid(side1, side2, side3))
            {
                _sides = new double[3] { side1, side2, side3 };
            }
            else
            {
                throw new ArgumentException("All sides of the triangle must be positive and the sum of each two sides must be greater than the third");
            }
        }

        public bool IsTriangleRight()
        {
            Array.Sort(_sides);

            double tmp_side1 = Math.Pow(_sides[0], 2);
            double tmp_side2 = Math.Pow(_sides[1], 2);
            double tmp_side3 = Math.Pow(_sides[2], 2);

            return (tmp_side1 + tmp_side2 == tmp_side3);
        }

        public override double Area()
        {
            double perimetr = (_sides[0] + _sides[1] + _sides[2]) / 2;
            return Math.Sqrt(perimetr * (perimetr - _sides[0]) * (perimetr - _sides[1]) * (perimetr - _sides[2]));
        }

        private bool IsTriangleValid(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1) && (side1 > 0) && (side2 > 0) && (side3 > 0);
        }
    }
}
