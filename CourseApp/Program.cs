using System;

namespace CourseApp
{
    public class Program
    {
        public static void Problem(double a, double x_begin, double x_end, double x_delta)
        {
            double y;
            for (double x = x_begin; x < x_end; x += x_delta)
            {
                y = Math.Pow(a, Math.Pow(x, 2) - 1) - Math.Log10(Math.Pow(x, 2) - 1) + Math.Pow(Math.Sqrt(Math.Pow(x, 2) - 1), 1 / 3);
                Console.WriteLine(y + " ");
            }
        }

        public static void Problem2(double[] elements, double a)
        {
            Console.WriteLine("Second one.");
            foreach (double x in elements)
            {
                double y = Math.Pow(a, Math.Pow(x, 2) - 1) - Math.Log10(Math.Pow(x, 2) - 1) + Math.Pow(Math.Sqrt(Math.Pow(x, 2) - 1), 1 / 3);
                Console.WriteLine(y);
            }
        }

        public static void Main(string[] args)
        {
            double[] xx = { 1.28, 1.36, 2.47, 3.68, 4.56 };
            CourseApp.Program.Problem(1.6, 1.2, 3.7, 0.5);
            CourseApp.Program.Problem2(xx, 1.6);
        }
    }
}