namespace SquareFigureLib
{
    public abstract class Figure
    {
        public FigureType Name { get; private set; }

        public Figure(FigureType fig)
        {
            Name = fig;
        }

        public abstract double GetSquare();
    }
}