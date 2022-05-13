using System;

namespace ConsoleApp292
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            Box box = new Box(length, width , heigth);

            Console.WriteLine();
            Console.WriteLine(box.SurfaceArea(box));
            Console.WriteLine(box.LateralSurfaceArea(box));
            Console.WriteLine(box.Volume(box));
        }
    }
}
