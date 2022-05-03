using System;

namespace ConsoleApp
{
    public class Program { 
        public static double Volume(double x, double y)
        { 
            Console.WriteLine("Volume = " + Math.Pow(x, y));
            return Math.Pow(x, y);
        }
        public static double Surface(double x, double y, double u)
        {
            Console.WriteLine("Surface area = " + (Math.Pow(x, y) * u));
            return Math.Pow(x, y) * u;
        }
        public static void Main(string[] args)
        {
            double x = 4;
            Volume(x, 3);
            Surface(x, 2, 6);
            Console.ReadLine();
        }
    }
}
