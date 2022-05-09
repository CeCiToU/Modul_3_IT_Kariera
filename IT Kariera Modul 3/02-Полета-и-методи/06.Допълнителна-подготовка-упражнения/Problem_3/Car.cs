namespace ConsoleApp288
{
    internal class Car
    {
        private string model;
        private string engine;
        private double weigth;
        private string color;

        public string Model { get => model; set => model = value; }
        public string Engine { get => engine; set => engine = value; }
        public double Weigth { get => weigth; set => weigth = value; }
        public string Color { get => color; set => color = value; }

        public Car(string model, string engine, double weigth, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weigth = weigth;
            this.color = color;
        }

        public Car()
        {
        }
    }
}