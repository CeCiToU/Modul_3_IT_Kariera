namespace ConsoleApp289
{
    internal class Rectangle
    {
        private string ID;
        private double X;
        private double X1;
        private double Y;
        private double Y1;


        public double X11 { get => X1; set => X1 = value; }
        public double x { get => X; set => X = value; }
        public double Y11 { get => Y1; set => Y1 = value; }
        public double y { get => Y; set => Y = value; }
        public string Id { get => ID; set => ID = value; }

        public Rectangle(string id, double width, double height, double x1, double y1)
        {
            Id = id;
            X11 = X1;
            Y11 = Y1;
            x = X - width;
            y = Y - height;

        }
    }
}