namespace ConsoleApp288
{
    internal class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;

        public string Model { get => model; set => model = value; }
        public double Power { get => power; set => power = value; }
        public double Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

        public Engine(string model, double power, double displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine()
        {
        }

    }
}