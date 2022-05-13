namespace ConsoleApp295
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

        public Box()
        {
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

        public double Length
        {
            get => length;
            set 
            {
                if (value <= 0) { throw new System.ArgumentException("Length cannot be zero or negative."); }
                length = value;
            }
        }
        public double Width { get => width; 
            set
            {
                if (value <= 0) { throw new System.ArgumentException("Width cannot be zero or negative."); }
                width = value;
            }
        }
        public double Heigth { get => heigth;
            set
            {
                if (value <= 0) { throw new System.ArgumentException("Heigth cannot be zero or negative."); }
                heigth = value;
            }
        }
    }
}