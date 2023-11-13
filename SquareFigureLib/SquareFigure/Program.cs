using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SquareFigureLib
{
    public class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(FigureType.Circle, 3);
            var triangle = new Triangle(FigureType.Triangle, 5, 6, 7);

            Console.WriteLine("Площадь круга с радиусом 3:  {0}", circle.GetSquare());
            Console.WriteLine("Площадь тругол-ка (5, 6, 7):  {0}", triangle.GetSquare());
        }
    }
}
