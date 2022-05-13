using System;

namespace ConsoleApp292
{
    internal class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = heigth;

        }
        public string Volume(Box box)
        {
            double volume = box.Heigth * box.Length * box.Width;
            
            return $"Volume – {volume:F2}";
        }

        public string SurfaceArea(Box box)
        {
            double surfaceArea = 2 * box.Length * box.Heigth + 2 * box.Width * box.Heigth + 2 * box.Length * box.Width;
            return $"Surface Area – {surfaceArea:F2}";
        }

        public string LateralSurfaceArea(Box box)
        {
            double lateralSurfaceArea = 2 * box.Length * box.Heigth + 2 * box.Width * box.Heigth;
            return $"Lateral Surface Area – {lateralSurfaceArea:F2}";
        }

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Heigth { get => heigth; set => heigth = value; }
    }
}