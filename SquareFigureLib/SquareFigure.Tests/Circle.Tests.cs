using SquareFigureLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresFigs.Tests
{
    public class CircleTest
    {
        [Fact]
        public void CheckSquare()
        {
            var circle = new Circle(FigureType.Circle, 7.5);
            var right = 176.71;

            var result = circle.GetSquare();

            Assert.Equal(right, result);
        }
    }
}
