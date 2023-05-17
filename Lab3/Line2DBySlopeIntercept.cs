namespace Lab3
{
    public class Line2DBySlopeIntercept : ILine2D
    {
        public double Slope { get; }
        public double YIntercept { get; }

        public Line2DBySlopeIntercept(double slope, double yIntercept)
        {
            Slope = slope;
            YIntercept = yIntercept;
        }
    }
}
