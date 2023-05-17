namespace Lab3
{
    public class Line2DByPoints : ILine2D
    {
        public double Slope { get; }
        public double YIntercept { get; }

        public Line2DByPoints(IPoint2D point1, IPoint2D point2)
        {
            if (point1.X == point2.X)
            {
                Slope = double.PositiveInfinity;
                YIntercept = point1.X;
            }
            else
            {
                Slope = (point2.Y - point1.Y) / (point2.X - point1.X);
                YIntercept = point1.Y - Slope * point1.X;
            }
        }
    }
}
