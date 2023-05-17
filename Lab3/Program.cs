using Lab3;

class Program
{
    static void Main(string[] args)
    {
        // Задаємо прямі різними способами
        ILine2D line1 = new Line2DBySlopeIntercept(2, 3);
        ILine2D line2 = new Line2DByPoints(new Point2D(1, 2), new Point2D(3, 8));
        ILine2D line3 = new Line2DByPoints(new Point2D(1, 2), new Point2D(3, 8));

        // Визначаємо, чи є прямі паралельними або перпендикулярними
        Console.WriteLine($"Lines are parallel: {Geometry2D.IsParallel(line3, line2)}");
        Console.WriteLine($"Lines are perpendicular: {Geometry2D.IsPerpendicular(line3, line2)}");
    }
}
