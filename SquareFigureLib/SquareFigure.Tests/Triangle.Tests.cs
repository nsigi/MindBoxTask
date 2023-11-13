using SquareFigureLib;

namespace SquaresFigs.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void CheckSqaures()
        {
            var t1 = new Triangle(FigureType.Triangle, 3, 4, 5);
            var t2 = new Triangle(FigureType.Triangle, 5, 10, 12);
            var right1 = 6;
            var right2 = 24.54;

            var res1 = t1.GetSquare();
            var res2 = t2.GetSquare();

            Assert.Equal(right1, res1);
            Assert.Equal(right2, res2);
        }

        public void IsRectangulars()
        {
            var t1 = new Triangle(FigureType.Triangle, 3, 4, 5);
            var t2 = new Triangle(FigureType.Triangle, 5, 10, 12);

            var res1 = t1.IsRectangular();
            var res2 = t2.IsRectangular();

            Assert.True(res1);
            Assert.False(res2);
        }
    }
}