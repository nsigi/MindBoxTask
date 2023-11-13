using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigureLib
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }

        public Circle(FigureType fig, double r) : base(fig)
        {
            Radius = r;
        }

        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
