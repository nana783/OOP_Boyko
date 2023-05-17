namespace Lab3
{
    public class Geometry2D
    {
        public static bool IsParallel(ILine2D line1, ILine2D line2)
        {
            return line1.Slope == line2.Slope;
        }

        public static bool IsPerpendicular(ILine2D line1, ILine2D line2)
        {
            return line1.Slope * line2.Slope == -1;
        }
    }
}
