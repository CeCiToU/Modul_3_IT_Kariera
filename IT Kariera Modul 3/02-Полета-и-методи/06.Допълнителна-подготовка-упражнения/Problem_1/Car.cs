namespace ConsoleApp285
{
    internal class Car
    {
       private string model;
        private double fuel;
        private double fuelUse;
        private double km;

        public string Model { get => model; set => model = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double FuelUse { get => fuelUse; set => fuelUse = value; }
        public double KM { get => km; set => km = value; }

        public override string ToString()
        {
            return $"{model} {fuel:F2} {km}";
        }
    }
}