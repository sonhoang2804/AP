using System;

namespace AP.PRACTICAL
{
    public class Geometry
    {
        public static void Main(string[] args)
        {
            Cylinder c = new Cylinder();
            Console.WriteLine("Enter dimension of Cylinder");
            Console.WriteLine("Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            double h = Convert.ToDouble(Console.ReadLine());
            c.Process(r, h);
            Console.WriteLine("Cylinder characteristics");
            Console.WriteLine("Radius: " + r);
            Console.WriteLine("Height: " + h);
            c.Result();
        }
    }
}