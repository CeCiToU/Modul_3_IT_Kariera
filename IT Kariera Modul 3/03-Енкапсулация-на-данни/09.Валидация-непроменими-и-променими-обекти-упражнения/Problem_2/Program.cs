using System;

namespace ConsoleApp295
{
    class Program
    {
        static void Main(string[] args)
        {
            double heigth;
            double length;
            double width;
            Box box = new Box();
            try
            {
                 length = double.Parse(Console.ReadLine());
                box.Length = length;
            } 
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            try
            {
                 width = double.Parse(Console.ReadLine());
                box.Width = width;
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
            try
            {
                 heigth = double.Parse(Console.ReadLine());
                box.Heigth = heigth;
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }

            Console.WriteLine();
            Console.WriteLine(box.SurfaceArea(box));
            Console.WriteLine(box.LateralSurfaceArea(box));
            Console.WriteLine(box.Volume(box));
        }
    }
}
