namespace ovn_2_1_1
{
    internal class Program
    {
        class Point2D
        {
            public double X, Y;
            public Point2D(int x, int y) { X = x; Y = y; }
            public override string ToString()
                => $"({X} {Y})";
        }
        static void Main(string[] args)
        {
            Point2D P = new Point2D(2, 3);
            Console.WriteLine(P);
        }
    }
}