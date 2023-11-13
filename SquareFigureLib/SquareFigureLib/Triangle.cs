using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigureLib
{
    public class Triangle : Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(FigureType fig, double a, double b, double c) : base(fig)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException("Сторона не может быть отрицательной");
            if (a > (b + c) || b > (a + c) || c > (a + b)) 
                throw new ArgumentException("Такого треугольника не существует");
            
            A = a;
            B = b;
            C = c;
        }

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }

        private bool IsRightAngle(double checkSide, double side1, double side2)
        {
            return checkSide == Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }

        public bool IsRectangular()
        {
            return IsRightAngle(A, B, C) || IsRightAngle(B, A, C) || IsRightAngle(C, A, B);
        }
    }
}
